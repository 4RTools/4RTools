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
            songMacro = new Macro(Macro.ACTION_NAME_SONG_MACRO, TOTAL_MACRO_LANES_FOR_SONGS);
            subject.Attach(this);
            InitializeComponent();
            configureMacroLanes();
        }

        public void Update(ISubject subject) 
        { 
            switch((subject as Subject).Message.code)
            {
                case MessageCode.PROFILE_CHANGED:
                    this.songMacro = ProfileSingleton.GetCurrent().SongMacro;
                    updateUi();
                    break;
                case MessageCode.TURN_ON:
                    this.songMacro.Start();
                    break;
                case MessageCode.TURN_OFF:
                    this.songMacro.Stop();
                    break;
            }

        }

        private void UpdatePanelData(int id)
        {
            try
            {
                Panel p = (Panel)this.Controls.Find("panelMacro" + id, true)[0];
                MacroConfig macroConfig = new MacroConfig(this.songMacro.configs[id - 1]);
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
                if (d.Length > 0)
                {
                    NumericUpDown delayInput = (NumericUpDown)d[0];
                    delayInput.Value = macroConfig.delay;
                }
            }catch { }
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
            mc.delay = decimal.ToInt16(delayInput.Value);
            ProfileSingleton.SetConfiguration(this.songMacro);
        }

        private void onReset(object sender, EventArgs e)
        {
            Button delayInput = (Button)sender;
            int btnResetID = Int16.Parse(delayInput.Name.Split(new[] { "btnResMac" }, StringSplitOptions.None)[1]);
            this.songMacro.ResetMacro(btnResetID);
            ProfileSingleton.SetConfiguration(this.songMacro);
            this.UpdatePanelData(btnResetID);
        }


        private void updateUi()
        {
            for (int i = 1; i <= TOTAL_MACRO_LANES_FOR_SONGS; i++)
            {
                UpdatePanelData(i);
            }
        }

        private void configureMacroLanes()
        {
            for (int i = 1; i <= TOTAL_MACRO_LANES_FOR_SONGS; i++)
            {
                initializeLane(i);
            }
        }

        private void initializeLane(int id)
        {
            try
            {
                Panel p = (Panel)this.Controls.Find("panelMacro" + id, true)[0];
                foreach (Control c in p.Controls)
                {
                    if (c is TextBox)
                    {
                        TextBox textBox = (TextBox)c;
                        textBox.KeyDown += new System.Windows.Forms.KeyEventHandler(FormUtils.OnKeyDown);
                        textBox.KeyPress += new KeyPressEventHandler(FormUtils.OnKeyPress);
                        textBox.TextChanged += new EventHandler(this.onTextChange);
                    }

                    if (c is Button)
                    {
                        Button resetButton = (Button)c;
                        resetButton.Click += new EventHandler(this.onReset);
                    }
                }
            }catch { }
           
        }
    }
}
