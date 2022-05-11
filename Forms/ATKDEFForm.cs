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
        private ATKDEFMode atkDefMode = new ATKDEFMode();
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
                    this.atkDefMode = ProfileSingleton.GetCurrent().AtkDefMode;
                    UpdateUI();
                    break;
                case MessageCode.TURN_ON:
                    this.atkDefMode.Start();
                    break;
                case MessageCode.TURN_OFF:
                    this.atkDefMode.Stop();
                    break;
            }
        }

        private void UpdateUI()
        {
            this.inSpammerKey.Text = this.atkDefMode.keySpammer.ToString();
            this.spammerDelay.Value = this.atkDefMode.ahkDelay;
            Dictionary<string, Key> atkKeys = new Dictionary<string, Key>(this.atkDefMode.atkKeys);
            Dictionary<string, Key> defKeys = new Dictionary<string, Key>(this.atkDefMode.defKeys);


            foreach(Control control in this.panelSwitch.Controls)
            {
                if(control is TextBox)
                {
                    try
                    {
                        TextBox tb = (TextBox)control;
                        if (!tb.Tag.ToString().Equals("spammerKey"))
                        {
                            ATKDEFEnum mode = (ATKDEFEnum)Int16.Parse(tb.Tag.ToString());
                            if (mode == ATKDEFEnum.DEF)
                            {
                                tb.Text = defKeys.ContainsKey(tb.Name) ? defKeys[tb.Name].ToString() : Keys.None.ToString();
                            }
                            else
                            {
                                tb.Text = atkKeys.ContainsKey(tb.Name) ? atkKeys[tb.Name].ToString() : Keys.None.ToString();
                            }
                        }
                    }
                    catch(Exception e) { }
                }
            }
        }

        private void onDelayChange(object sender, EventArgs e)
        {
            NumericUpDown delayInput = (NumericUpDown)sender;
            this.atkDefMode.ahkDelay = decimal.ToInt16(delayInput.Value);
            ProfileSingleton.SetConfiguration(this.atkDefMode);
        }

        private void onTextChange(object sender, EventArgs e)
        {

            TextBox textBox = (TextBox)sender;
            Key key = (Key)Enum.Parse(typeof(Key), textBox.Text.ToString());

            //If it's ATK OR DEF
            if (textBox.Tag.Equals("spammerKey"))
            {
                this.atkDefMode.keySpammer = key;
            }
            else
            {
                ATKDEFEnum mode = (ATKDEFEnum)Int16.Parse(textBox.Tag.ToString());
                this.atkDefMode.AddSwitchItem(textBox.Name, key, mode);
            }            
            ProfileSingleton.SetConfiguration(this.atkDefMode);

        }

        public void SetupInputs()
        {
            try
            {
                foreach (Control c in this.panelSwitch.Controls)
                {
                    if (c is TextBox)
                    {
                        TextBox textBox = (TextBox)c;
                        textBox.KeyDown += new System.Windows.Forms.KeyEventHandler(FormUtils.OnKeyDown);
                        textBox.KeyPress += new KeyPressEventHandler(FormUtils.OnKeyPress);
                        textBox.TextChanged += new EventHandler(this.onTextChange);
                    }
                }
            }
            catch { }

        }
    }
}
