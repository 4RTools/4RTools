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
        public static int TOTAL_MACRO_LANES_FOR_SONGS = 4;
        private Macro songMacro;
        public MacroSongForm(Subject subject)
        {
            songMacro = new Macro("SongMacro", TOTAL_MACRO_LANES_FOR_SONGS);
            subject.Attach(this);
            InitializeComponent();

            for (int i = 0; i <= TOTAL_MACRO_LANES_FOR_SONGS - 1; i++)
            {
                var id = i + 1;
                Control[] c = this.Controls.Find("panelMacro" + id, true);
                if (c.Length > 0)
                {
                    Panel panel = (Panel)c[0];
                    initializeLane(panel);
                }
            }

        }

        public void Update(ISubject subject)
        {
            if ((subject as Subject).Message.code == MessageCode.PROFILE_CHANGED)
            {
                this.songMacro = ProfileSingleton.GetCurrent().SongMacro;

                for(int i = 0; i <= TOTAL_MACRO_LANES_FOR_SONGS - 1; i++)
                {
                    var id = i + 1;
                    Control[] c = this.Controls.Find("panelMacro" + id, true);
                    if (c.Length > 0)
                    {
                        Panel panel = (Panel)c[0];
                        try {
                            UpdatePanelData(panel, new MacroConfig(this.songMacro.configs[i]));
                        }
                        catch { }
                        
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
            FormUtils.ResetForm(p);
            //Update Trigger Macro Value
            Control[] c = p.Controls.Find("inTriggerMacro" + macroConfig.id, true);
            if (c.Length > 0)
            {
                TextBox textBox = (TextBox)c[0];
                textBox.Text = macroConfig.trigger.ToString();
            }

            List<string> names = new List<string>(macroConfig.macroEntries.Keys);
            foreach (string cbName in names)
            {
                Control[] controls = p.Controls.Find(cbName, true);
                if (controls.Length > 0)
                {
                    TextBox textBox = (TextBox)controls[0];
                    textBox.Text = macroConfig.macroEntries[cbName].ToString();
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

        private void onTextChange(object sender, EventArgs e)
        {

            TextBox textBox = (TextBox)sender;
            Key key = (Key)Enum.Parse(typeof(Key), textBox.Text.ToString());
            string[] parts = textBox.Name.Split(new[] { "inTriggerMacro" }, StringSplitOptions.None);
                
            if (parts.Length > 1) //It's a MacroTrigger
            {
                int id = Int16.Parse(parts[1]);
                MacroConfig mc = this.songMacro.configs.Find(songMacro => songMacro.id == id);
                mc.trigger = key;
                //If don't found a macro config with given cbTriggerMacroID
            }
            else
            {
                int macroID = Int16.Parse(textBox.Name.Split(new[] { "mac" }, StringSplitOptions.None)[1]);
                MacroConfig mc = this.songMacro.configs.Find(songMacro => songMacro.id == macroID);
                mc.macroEntries[textBox.Name] = key;
            }
            ProfileSingleton.SetConfiguration(this.songMacro);

        }

        private void onDelayChange(object sender, EventArgs e)
        {
            NumericUpDown delayInput = (NumericUpDown)sender;
            int macroID = Int16.Parse(delayInput.Name.Split(new[] { "delayMac" }, StringSplitOptions.None)[1]);
            MacroConfig mc = this.songMacro.configs.Find(songMacro => songMacro.id == macroID);
            mc.delay = Int16.Parse(delayInput.Text);
            ProfileSingleton.SetConfiguration(this.songMacro);
        }

        public void initializeLane(Panel p)
        {
            foreach (Control c in p.Controls)
            {
                if (c is TextBox)
                {
                    TextBox textBox = (TextBox)c;
                    textBox.KeyDown += new System.Windows.Forms.KeyEventHandler(FormUtils.OnKeyDown);
                    textBox.KeyPress += new KeyPressEventHandler(FormUtils.OnKeyPress);
                    textBox.TextChanged += new EventHandler(this.onTextChange);
                }

                if (c is NumericUpDown)
                {
                    NumericUpDown numericBox = (NumericUpDown)c;
                    numericBox.ValueChanged += new EventHandler(this.onDelayChange);
                }
            }
        }

    }
}
