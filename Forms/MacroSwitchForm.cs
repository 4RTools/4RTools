using System;
using System.Windows.Forms;
using System.Windows.Input;
using System.Collections.Generic;
using _4RTools.Model;
using _4RTools.Utils;
using System.Text.RegularExpressions;
using System.Diagnostics;
using System.Xml.Linq;

namespace _4RTools.Forms
{
    public partial class MacroSwitchForm : Form, IObserver
    {
        public static int TOTAL_MACRO_LANES = 4;
        public MacroSwitchForm(Subject subject)
        {
            subject.Attach(this);
            InitializeComponent();
            configureMacroLanes();
        }

        public void Update(ISubject subject)
        {
            switch ((subject as Subject).Message.code)
            {
                case MessageCode.PROFILE_CHANGED:
                    updateUi();
                    break;
                case MessageCode.TURN_ON:
                    ProfileSingleton.GetCurrent().MacroSwitch.Start();
                    break;
                case MessageCode.TURN_OFF:
                    ProfileSingleton.GetCurrent().MacroSwitch.Stop();
                    break;
            }
        }

        private void UpdatePanelData(int id)
        {
            try
            {
                GroupBox group = (GroupBox)this.Controls.Find("chainGroup" + id, true)[0];
                ChainConfig chainConfig = new ChainConfig(ProfileSingleton.GetCurrent().MacroSwitch.chainConfigs[id - 1]);
                FormUtils.ResetForm(group);

                List<string> names = new List<string>(chainConfig.macroEntries.Keys);
                foreach (string cbName in names)
                {
                    Control[] controls = group.Controls.Find(cbName, true); // Keys
                    if (controls.Length > 0)
                    {
                        TextBox textBox = (TextBox)controls[0];
                        textBox.Text = chainConfig.macroEntries[cbName].key.ToString();
                    }

                    Control[] d = group.Controls.Find($"{cbName}delay", true); // Delays
                    if (d.Length > 0)
                    {
                        NumericUpDown delayInput = (NumericUpDown)d[0];
                        delayInput.Value = chainConfig.macroEntries[cbName].delay;
                    }

                    Control[] c = group.Controls.Find($"{cbName}click", true); // Clicks
                    if (d.Length > 0)
                    {
                        CheckBox checkInput = (CheckBox)c[0];
                        checkInput.Checked = chainConfig.macroEntries[cbName].hasClick;
                    }


                }
            }
            catch { };
        }

        private void onTextChange(object sender, EventArgs e, ChainConfig chainConfig)
        {                 
            TextBox textBox = (TextBox)sender;
            int chainID = Int16.Parse(textBox.Parent.Name.Split(new[] { "chainGroup" }, StringSplitOptions.None)[1]);
            GroupBox group = (GroupBox)this.Controls.Find("chainGroup" + chainID, true)[0];

            Key key = (Key)Enum.Parse(typeof(Key), textBox.Text.ToString());
            NumericUpDown delayInput = (NumericUpDown)group.Controls.Find($"{textBox.Name}delay", true)[0];
            chainConfig.macroEntries[textBox.Name] = new MacroKey(key, decimal.ToInt16(delayInput.Value));

            bool isFirstInput = Regex.IsMatch(textBox.Name, $"in1mac{chainID}");
            if (isFirstInput) { chainConfig.trigger = key; }

            ProfileSingleton.SetConfiguration(ProfileSingleton.GetCurrent().MacroSwitch);
        }

        private void onDelayChange(object sender, EventArgs e, ChainConfig chainConfig)
        {
            NumericUpDown delayInput = (NumericUpDown)sender;
            String cbName = delayInput.Name.Split(new[] { "delay" }, StringSplitOptions.None)[0];
            chainConfig.macroEntries[cbName].delay = decimal.ToInt16(delayInput.Value);
            ProfileSingleton.SetConfiguration(ProfileSingleton.GetCurrent().MacroSwitch);
        }

        private void onCheckClickChange(object sender, EventArgs e, ChainConfig chainConfig)
        {
            CheckBox checkInput = (CheckBox)sender;
            int chainID = Int16.Parse(checkInput.Parent.Name.Split(new[] { "chainGroup" }, StringSplitOptions.None)[1]);
            String cbName = checkInput.Name.Split(new[] { "click" }, StringSplitOptions.None)[0];
            chainConfig.macroEntries[cbName].hasClick = checkInput.Checked;
            ProfileSingleton.SetConfiguration(ProfileSingleton.GetCurrent().MacroSwitch);
        }

        private void updateUi()
        {
            for (int i = 1; i <= TOTAL_MACRO_LANES; i++)
            {
                UpdatePanelData(i);
            }
        }

        private void configureMacroLanes()
        {
            for (int i = 1; i <= TOTAL_MACRO_LANES; i++)
            {
                initializeLane(i);
            }
        }

        private void initializeLane(int id)
        {
            try
            {
                GroupBox p = (GroupBox)this.Controls.Find("chainGroup" + id, true)[0];
                foreach (Control control in p.Controls)
                {
                    ChainConfig chainConfig = ProfileSingleton.GetCurrent().MacroSwitch.chainConfigs.Find(config => config.id == id);

                    if (chainConfig == null) {
                        chainConfig = new ChainConfig(id, Key.None);
                        ProfileSingleton.GetCurrent().MacroSwitch.chainConfigs.Add(chainConfig);
                    }

                    if (control is TextBox)
                    {
                        TextBox textBox = (TextBox)control;
                        textBox.KeyDown += new System.Windows.Forms.KeyEventHandler(FormUtils.OnKeyDown);
                        textBox.KeyPress += new KeyPressEventHandler(FormUtils.OnKeyPress);
                        textBox.TextChanged += new EventHandler((object sender, EventArgs art) => this.onTextChange(sender, art, chainConfig));
                    }

                    if (control is NumericUpDown)
                    {
                        NumericUpDown delayInput = (NumericUpDown)control;
                        delayInput.ValueChanged += new System.EventHandler((object sender, EventArgs args) => this.onDelayChange(sender, args, chainConfig));
                    }


                    if (control is CheckBox)
                    {
                        CheckBox checkInput = (CheckBox)control;
                        checkInput.CheckedChanged += new System.EventHandler((object sender, EventArgs args) => this.onCheckClickChange(sender, args, chainConfig));
                    }
                }
            }
            catch { }
        }
    }
}
