using System;
using System.Collections.Generic;
using System.Windows.Forms;
using _4RTools.Utils;
using _4RTools.Model;
using System.Windows.Input;

namespace _4RTools.Forms
{
    public partial class ATKDEFForm : Form, IObserver
    {
        public static int TOTAL_ATKDEF_LANES = 4;
        public static int TOTAL_EQUIPS = 6;
        public ATKDEFForm(Subject subject)
        {
            subject.Attach(this);
            InitializeComponent();
            SetupInputs();
        }

        public void Update(ISubject subject)
        {
            switch ((subject as Subject).Message.code)
            {
                case MessageCode.PROFILE_CHANGED:
                    UpdateUi();
                    break;
                case MessageCode.TURN_ON:
                    ProfileSingleton.GetCurrent().AtkDefMode.Start();
                    break;
                case MessageCode.TURN_OFF:
                    ProfileSingleton.GetCurrent().AtkDefMode.Stop();
                    break;
            }
        }

        private void UpdatePanelData(int id)
        {
            try
            {
                GroupBox group = (GroupBox)this.Controls.Find("equipGroup" + id, true)[0];
                EquipConfig exist = ProfileSingleton.GetCurrent().AtkDefMode.equipConfigs.Find(config => config.id == id);
                if (exist == null)
                {
                    ProfileSingleton.GetCurrent().AtkDefMode.equipConfigs.Add(new EquipConfig(id, Key.None));
                    ProfileSingleton.SetConfiguration(ProfileSingleton.GetCurrent().AtkDefMode);
                }
                EquipConfig equipConfig = new EquipConfig(ProfileSingleton.GetCurrent().AtkDefMode.equipConfigs[id - 1]);
                FormUtils.ResetForm(group);

                Control[] cKey = group.Controls.Find("in" + id + "SpammerKey", true);
                if (cKey.Length > 0)
                {
                    TextBox textBox = (TextBox)cKey[0];
                    textBox.Text = equipConfig.keySpammer.ToString();
                }

                Control[] cSpammerDelay = group.Controls.Find("in" + id + "SpammerDelay", true);
                if (cSpammerDelay.Length > 0)
                {
                    NumericUpDown numeric = (NumericUpDown)cSpammerDelay[0];
                    numeric.Value = equipConfig.ahkDelay;
                }

                Control[] cSwitchDelay = group.Controls.Find("in" + id + "SwitchDelay", true);
                if (cSwitchDelay.Length > 0)
                {
                    NumericUpDown numeric = (NumericUpDown)cSwitchDelay[0];
                    numeric.Value = equipConfig.switchDelay;
                }

                Control[] cSpammerClick = group.Controls.Find("in" + id + "SpammerClick", true);
                if (cSpammerClick.Length > 0)
                {
                    CheckBox checkBox = (CheckBox)cSpammerClick[0];
                    checkBox.Checked = equipConfig.keySpammerWithClick;
                }

                Dictionary<string, Key> atkKeys = new Dictionary<string, Key>(equipConfig.atkKeys);
                Dictionary<string, Key> defKeys = new Dictionary<string, Key>(equipConfig.defKeys);

                for (int i = 1; i <= TOTAL_EQUIPS; i++)
                {
                    Control[] equipDef = group.Controls.Find("in" + id + "Def" + i, true);
                    TextBox tbDef = (TextBox)equipDef[0];
                    tbDef.Text = defKeys.ContainsKey(tbDef.Name) ? defKeys[tbDef.Name].ToString() : Keys.None.ToString();

                    Control[] equipAtk = group.Controls.Find("in" + id + "Atk" + i, true);
                    TextBox tbAtk = (TextBox)equipAtk[0];
                    tbAtk.Text = atkKeys.ContainsKey(tbAtk.Name) ? atkKeys[tbAtk.Name].ToString() : Keys.None.ToString();
                }
            }
            catch (Exception ex)
            {
                var exc = ex;
            };

        }

        private void UpdateUi()
        {
            for (int i = 1; i <= TOTAL_ATKDEF_LANES; i++)
            {
                UpdatePanelData(i);
            }
        }

        private void onDelayChange(object sender, EventArgs e)
        {
            NumericUpDown delayInput = (NumericUpDown)sender;

            string[] inputTag = delayInput.Tag.ToString().Split(new[] { ":" }, StringSplitOptions.None);
            int id = short.Parse(inputTag[0]);
            string type = inputTag[1];
            EquipConfig equipConfig = ProfileSingleton.GetCurrent().AtkDefMode.equipConfigs.Find(config => config.id == id);

            if (type == "spammerDelay")
            {
                //Spammer Delay Change
                equipConfig.ahkDelay = decimal.ToInt16(delayInput.Value);
            }
            else
            {
                //Switch Delay Change
                equipConfig.switchDelay = decimal.ToInt16(delayInput.Value);
            }

            ProfileSingleton.SetConfiguration(ProfileSingleton.GetCurrent().AtkDefMode);
        }

        private void onTextChange(object sender, EventArgs e)
        {

            TextBox textBox = (TextBox)sender;
            Key key = (Key)Enum.Parse(typeof(Key), textBox.Text.ToString());

            string[] inputTag = textBox.Tag.ToString().Split(new[] { ":" }, StringSplitOptions.None);
            int id = short.Parse(inputTag[0]);
            string type = inputTag[1];
            EquipConfig equipConfig = ProfileSingleton.GetCurrent().AtkDefMode.equipConfigs.Find(config => config.id == id);

            if (type.Equals("spammerKey"))
            {
                equipConfig.keySpammer = key;
            }
            else
            {
                type = inputTag[1].Remove(inputTag[1].Length - 1).ToUpper();
                ProfileSingleton.GetCurrent().AtkDefMode.AddSwitchItem(id, textBox.Name, key, type);
            }
            ProfileSingleton.SetConfiguration(ProfileSingleton.GetCurrent().AtkDefMode);

        }

        private void ChkBox_CheckedChanged(object sender, EventArgs e)
        {

            CheckBox checkBox = (CheckBox)sender;

            string[] inputTag = checkBox.Tag.ToString().Split(new[] { ":" }, StringSplitOptions.None);
            int id = short.Parse(inputTag[0]);

            EquipConfig equipConfig = ProfileSingleton.GetCurrent().AtkDefMode.equipConfigs.Find(config => config.id == id);
            equipConfig.keySpammerWithClick = checkBox.Checked;
            ProfileSingleton.SetConfiguration(ProfileSingleton.GetCurrent().AtkDefMode);
        }

        public void SetupInputs()
        {
            try
            {
                foreach (Control c in FormUtils.GetAll(this, typeof(TextBox)))
                {
                    if (c is TextBox)
                    {
                        TextBox textBox = (TextBox)c;
                        textBox.KeyDown += new System.Windows.Forms.KeyEventHandler(FormUtils.OnKeyDown);
                        textBox.KeyPress += new KeyPressEventHandler(FormUtils.OnKeyPress);
                        textBox.TextChanged += new EventHandler(this.onTextChange);
                    }

                }

                foreach (Control c in FormUtils.GetAll(this, typeof(NumericUpDown)))
                {
                    if (c is NumericUpDown)
                    {
                        NumericUpDown numericUpDown = (NumericUpDown)c;
                        numericUpDown.ValueChanged += new EventHandler(this.onDelayChange);
                    }

                }

                foreach (Control c in FormUtils.GetAll(this, typeof(CheckBox)))
                {
                    if (c is CheckBox)
                    {
                        CheckBox numericUpDown = (CheckBox)c;
                        numericUpDown.CheckedChanged += new EventHandler(this.ChkBox_CheckedChanged);
                    }

                }
            }
            catch { }

        }
    }
}
