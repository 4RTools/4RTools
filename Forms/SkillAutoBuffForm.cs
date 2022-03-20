using System;
using System.Windows.Forms;
using _4RTools.Utils;
using _4RTools.Model;
using System.Windows.Input;
using System.Collections.Generic;

namespace _4RTools.Forms
{
    public partial class SkillAutoBuffForm : Form, IObserver
    {
        private AutoBuff autobuff = new AutoBuff("SkillAutoBuff");

        public SkillAutoBuffForm(Subject subject)
        {
            this.KeyPreview = true;
            InitializeComponent();
            subject.Attach(this);
            ConfigureInputs();

        }

        public void Update(ISubject subject)
        {
            switch ((subject as Subject).Message.code)
            {
                case MessageCode.PROFILE_CHANGED:
                    this.autobuff = ProfileSingleton.GetCurrent().SkillAutoBuff;
                    Dictionary<EffectStatusIDs, Key> buffMappingClone = new Dictionary<EffectStatusIDs, Key>(this.autobuff.buffMapping);
                    this.updateInputValues(buffMappingClone);
                    break;
                case MessageCode.TURN_OFF:
                    this.autobuff.Stop();
                    break;
                case MessageCode.TURN_ON:
                    this.autobuff.Start();
                    break;
            }
        }

 

        private void ConfigureInputs()
        {
            foreach (Control c in this.Controls)
                if (c is TextBox)
                {
                    TextBox textBox = (TextBox)c;
                    textBox.KeyDown += new System.Windows.Forms.KeyEventHandler(FormUtils.OnKeyDown);
                    textBox.KeyPress += new KeyPressEventHandler(FormUtils.OnKeyPress);
                    textBox.TextChanged += new EventHandler(this.onTextChange);
                }
        }

        private void updateInputValues(Dictionary<EffectStatusIDs, Key> autobuffDict)
        {
            FormUtils.ResetForm(this);
            foreach (EffectStatusIDs effect in autobuffDict.Keys)
            {
                Control[] c = this.Controls.Find("in" + (int)effect, true);
                if (c.Length > 0)
                {
                    TextBox textBox = (TextBox)c[0];
                    textBox.Text = autobuffDict[effect].ToString();
                }
            }
        }

        private void onTextChange(object sender, EventArgs e)
        {
            try
            {

                TextBox txtBox = (TextBox)sender;
                if (txtBox.Text.ToString() != String.Empty)
                {
                    Key key = (Key)Enum.Parse(typeof(Key), txtBox.Text.ToString());
                    EffectStatusIDs statusID = (EffectStatusIDs)Int16.Parse(txtBox.Name.Split(new[] { "in" }, StringSplitOptions.None)[1]);

                    switch (key)
                    {
                        case Key.Escape:
                            this.autobuff.RemoveKey(statusID);
                            break;
                        case Key.Back:
                            this.autobuff.RemoveKey(statusID);
                            break;
                        case Key.None:
                            this.autobuff.RemoveKey(statusID);
                            break;
                        default:
                            this.autobuff.AddKeyToBuff(statusID, key);
                            break;
                    }

                    ProfileSingleton.SetConfiguration(this.autobuff);
                }
            }
            catch { }
        }
    }
}
