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
                    UpdateUI();
                    break;
                case MessageCode.TURN_ON:
                    ProfileSingleton.GetCurrent().AtkDefMode.Start();
                    break;
                case MessageCode.TURN_OFF:
                    ProfileSingleton.GetCurrent().AtkDefMode.Stop();
                    break;
            }
        }

        private void UpdateUI()
        {
            this.inSpammerKey.Text = ProfileSingleton.GetCurrent().AtkDefMode.keySpammer.ToString();
            this.spammerDelay.Value = ProfileSingleton.GetCurrent().AtkDefMode.ahkDelay;
            Dictionary<string, Key> atkKeys = new Dictionary<string, Key>(ProfileSingleton.GetCurrent().AtkDefMode.atkKeys);
            Dictionary<string, Key> defKeys = new Dictionary<string, Key>(ProfileSingleton.GetCurrent().AtkDefMode.defKeys);


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
            ProfileSingleton.GetCurrent().AtkDefMode.ahkDelay = decimal.ToInt16(delayInput.Value);
            ProfileSingleton.SetConfiguration(ProfileSingleton.GetCurrent().AtkDefMode);
        }

        private void onTextChange(object sender, EventArgs e)
        {

            TextBox textBox = (TextBox)sender;
            Key key = (Key)Enum.Parse(typeof(Key), textBox.Text.ToString());

            //If it's ATK OR DEF
            if (textBox.Tag.Equals("spammerKey"))
            {
                ProfileSingleton.GetCurrent().AtkDefMode.keySpammer = key;
            }
            else
            {
                ATKDEFEnum mode = (ATKDEFEnum)Int16.Parse(textBox.Tag.ToString());
                ProfileSingleton.GetCurrent().AtkDefMode.AddSwitchItem(textBox.Name, key, mode);
            }            
            ProfileSingleton.SetConfiguration(ProfileSingleton.GetCurrent().AtkDefMode);

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
