using System;
using _4RTools.Model;
using _4RTools.Utils;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Windows.Input;

namespace _4RTools.Forms
{
    public partial class MacroSongForm : Form, IObserver
    {
        public static int TOTAL_MACRO_LANES_FOR_SONGS = 4;
        public MacroSongForm(Subject subject)
        {
            subject.Attach(this);
            InitializeComponent();
            configureMacroLanes();
        }

        public void Update(ISubject subject) 
        { 
            switch((subject as Subject).Message.code)
            {
                case MessageCode.PROFILE_CHANGED:
                    updateUi();
                    break;
                case MessageCode.TURN_ON:
                    ProfileSingleton.GetCurrent().SongMacro.Start();
                    break;
                case MessageCode.TURN_OFF:
                    ProfileSingleton.GetCurrent().SongMacro.Stop();
                    break;
            }

        }

        private void UpdatePanelData(int id)
        {
            try
            {
                Macro songMacro = ProfileSingleton.GetCurrent().SongMacro;
                Panel p = (Panel)this.Controls.Find("panelMacro" + id, true)[0];
                ChainConfig chainConfig = new ChainConfig(songMacro.chainConfigs[id - 1]);
                FormUtils.ResetForm(p);

                //Update Trigger Macro Value
                Control[] c = p.Controls.Find("inTriggerMacro" + chainConfig.id, true);
                if (c.Length > 0)
                {
                    TextBox textBox = (TextBox)c[0];
                    textBox.Text = chainConfig.trigger.ToString();
                }

                //Update Dagger Value
                Control[] cDagger = p.Controls.Find("inDaggerMacro" + chainConfig.id, true);
                if (c.Length > 0)
                {
                    TextBox textBox = (TextBox)cDagger[0];
                    textBox.Text = chainConfig.daggerKey.ToString();
                }

                //Update Instrument Value
                Control[] cInstrument = p.Controls.Find("inInstrumentMacro" + chainConfig.id, true);
                if (c.Length > 0)
                {
                    TextBox textBox = (TextBox)cInstrument[0];
                    textBox.Text = chainConfig.instrumentKey.ToString();
                }


                List<string> names = new List<string>(chainConfig.macroEntries.Keys);
                foreach (string cbName in names)
                {
                    Control[] controls = p.Controls.Find(cbName, true);
                    if (controls.Length > 0)
                    {
                        TextBox textBox = (TextBox)controls[0];
                        textBox.Text = chainConfig.macroEntries[cbName].key.ToString();
                    }
                }

                //Update Delay Macro Value
                Control[] d = p.Controls.Find("delayMac" + chainConfig.id, true);
                if (d.Length > 0)
                {
                    NumericUpDown delayInput = (NumericUpDown)d[0];
                    delayInput.Value = chainConfig.delay;
                }
            } catch { }
        }

        private void onTextChange(object sender, EventArgs e)
        {
            Macro SongMacro = ProfileSingleton.GetCurrent().SongMacro;
            TextBox textBox = (TextBox)sender;
            Key key = (Key)Enum.Parse(typeof(Key), textBox.Text.ToString());

            if(textBox.Tag != null)
            {
                //Could be Trigger, Dagger or Instrument input
                string[] inputTag = textBox.Tag.ToString().Split(new[] { ":" }, StringSplitOptions.None);
                int macroid = short.Parse(inputTag[0]);
                string type = inputTag[1];
                ChainConfig chainConfig = ProfileSingleton.GetCurrent().SongMacro.chainConfigs.Find(config => config.id == macroid);

                switch (type)
                {
                    case "Dagger":
                        chainConfig.daggerKey = key;
                        break;
                    case "Instrument":
                        chainConfig.instrumentKey= key;
                        break;
                    case "Trigger":
                        chainConfig.trigger = key;
                        break;
                }
            }
            else
            {
                int macroID = short.Parse(textBox.Name.Split(new[] { "mac" }, StringSplitOptions.None)[1]);
                ChainConfig chainConfig = SongMacro.chainConfigs.Find(songMacro => songMacro.id == macroID);
                chainConfig.macroEntries[textBox.Name] = new MacroKey(key, chainConfig.delay);
            }

            ProfileSingleton.SetConfiguration(SongMacro);
        }

        private void onDelayChange(object sender, EventArgs e)
        {
            Macro SongMacro = ProfileSingleton.GetCurrent().SongMacro;
            NumericUpDown delayInput = (NumericUpDown)sender;
            int macroID = Int16.Parse(delayInput.Name.Split(new[] { "delayMac" }, StringSplitOptions.None)[1]);
            ChainConfig chainConfig = SongMacro.chainConfigs.Find(songMacro => songMacro.id == macroID);

            chainConfig.delay = decimal.ToInt16(delayInput.Value);

            List<string> names = new List<string>(chainConfig.macroEntries.Keys);
            foreach (string cbName in names)
            {
                chainConfig.macroEntries[cbName].delay = chainConfig.delay;
            }
            ProfileSingleton.SetConfiguration(SongMacro);
        }

        private void onReset(object sender, EventArgs e)
        {
            Macro SongMacro = ProfileSingleton.GetCurrent().SongMacro;
            Button delayInput = (Button)sender;
            int btnResetID = Int16.Parse(delayInput.Name.Split(new[] { "btnResMac" }, StringSplitOptions.None)[1]);
            ProfileSingleton.SetConfiguration(SongMacro);
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
            } catch { }
        }
    }
}
