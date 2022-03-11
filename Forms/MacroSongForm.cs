using System;
using _4RTools.Model;
using _4RTools.Utils;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Input;

namespace _4RTools.Forms
{
    public partial class MacroSongForm : Form, IObserver
    {
        private Macro songMacro = new Macro("SongMacro");
        public MacroSongForm(Subject subject)
        {
            
            subject.Attach(this);
            InitializeComponent();
            InitializeComboBoxes(this.panelMacro1);
            InitializeComboBoxes(this.panelMacro2);
            InitializeComboBoxes(this.panelMacro3);
            InitializeComboBoxes(this.panelMacro4);
        }

        public void Update(ISubject subject)
        {
            if ((subject as Subject).Message.code == MessageCode.PROFILE_CHANGED)
            {
                this.songMacro = ProfileSingleton.GetCurrent().SongMacro;

                for(int i = 0; i <= this.songMacro.configs.Count - 1; i++)
                {
                    var id = i + 1;
                    Control[] c = this.Controls.Find("panelMacro" + id, true);
                    if (c.Length > 0)
                    {
                        Panel panel = (Panel)c[0];
                        UpdatePanelData(panel, this.songMacro.configs[i]);
                    }
                }

            }
            else if ((subject as Subject).Message.code == MessageCode.TURN_ON)
            {
                this.songMacro.Start();
            }
            else if ((subject as Subject).Message.code == MessageCode.TURN_OFF)
            {
                this.songMacro.Stop();
            }
        }

        private void UpdatePanelData(Panel p, MacroConfig macroConfig)
        {
   
            //Update Trigger Macro Value
            Control[] c = p.Controls.Find("cbTriggerMacro" + macroConfig.id, true);
            if (c.Length > 0)
            {
                ComboBox combo = (ComboBox)c[0];
                combo.SelectedValue = macroConfig.trigger;
            }

            List<string> names = new List<string>(macroConfig.macroEntries.Keys);
            foreach (string cbName in names)
            {
                Control[] controls = p.Controls.Find(cbName, true);
                if (controls.Length > 0)
                {
                    ComboBox combo = (ComboBox)controls[0];
                    combo.SelectedValue = macroConfig.macroEntries[cbName];
                }
            }

            //Update Delay Macro Value
            Control[] d = p.Controls.Find("delayMac" + macroConfig.id, true);
            if(d.Length > 0)
            {
                NumericUpDown delayInput = (NumericUpDown)d[0];
                delayInput.Value = macroConfig.delay;
            }
        }

        private void onIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ComboBox cb = (ComboBox)sender;
                Key key = (Key)cb.SelectedValue;
                string[] parts = cb.Name.Split(new[] { "cbTriggerMacro" }, StringSplitOptions.None);
                
                if (parts.Length > 1) //It's a MacroTrigger
                {
                    int id = Int16.Parse(parts[1]);
                    MacroConfig mc = this.songMacro.configs.Find(songMacro => songMacro.id == id);
                    //If don't found a macro config with given cbTriggerMacroID
                    if (mc == null)
                    {
                        songMacro.configs.Add(new MacroConfig(id, key));
                    }
                    else
                    {
                        mc.trigger = key;
                    }
                }
                else
                {
                    int macroID = Int16.Parse(cb.Name.Split(new[] { "mac" }, StringSplitOptions.None)[1]);
                    MacroConfig mc = this.songMacro.configs.Find(songMacro => songMacro.id == macroID);
                    if (mc == null)
                    {
                        songMacro.configs.Add(new MacroConfig(macroID, Key.None));
                        mc = this.songMacro.configs.Find(songMacro => songMacro.id == macroID);
                    }

                    if (mc.macroEntries.ContainsKey(cb.Name))
                    {
                        mc.macroEntries.Remove(cb.Name);
                    }

                    if(key != Key.None)
                    mc.macroEntries.Add(cb.Name, key);
                }
                ProfileSingleton.SetConfiguration(this.songMacro);
            }
            catch { }
        }

        private void onDelayChange(object sender, EventArgs e)
        {
            NumericUpDown delayInput = (NumericUpDown)sender;
            int macroID = Int16.Parse(delayInput.Name.Split(new[] { "delayMac" }, StringSplitOptions.None)[1]);
            MacroConfig mc = this.songMacro.configs.Find(songMacro => songMacro.id == macroID);
            if (mc == null)
            {
                songMacro.configs.Add(new MacroConfig(macroID, Key.None));
                mc = this.songMacro.configs.Find(songMacro => songMacro.id == macroID);
            }
            mc.delay = Int16.Parse(delayInput.Text);
            ProfileSingleton.SetConfiguration(this.songMacro);
        }
        void removeWheelMouse(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            ((HandledMouseEventArgs)e).Handled = true;
        }

        public void InitializeComboBoxes(Panel p)
        {
            foreach (Control c in p.Controls)
            {
                if (c is ComboBox)
                {
                    ComboBox comboBox = (ComboBox)c;
                    comboBox.DisplayMember = "Key";
                    comboBox.ValueMember = "Value";
                    comboBox.DataSource = new BindingSource(KeyMap.getDict(), null);
                    comboBox.SelectedValueChanged += new EventHandler(this.onIndexChanged);
                    comboBox.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.removeWheelMouse);
                    Application.DoEvents(); //add this line
                }

                if(c is NumericUpDown)
                {
                    NumericUpDown numericBox = (NumericUpDown)c;
                    numericBox.ValueChanged += new EventHandler(this.onDelayChange);
                }
            }
        }

    }
}
