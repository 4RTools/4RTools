using System;
using System.Windows.Forms;
using _4RTools.Utils;
using _4RTools.Model;
using System.Windows.Input;
using System.Collections.Generic;
using _4RTools.Components;
using System.Drawing;

namespace _4RTools.Forms
{
    public partial class SkillAutoBuffForm : Form, IObserver
    {

        public SkillAutoBuffForm(Subject subject)
        {
            InitializeComponent();
            subject.Attach(this);
            ConfigureInputs();

        }

        public void Update(ISubject subject)
        {
            switch ((subject as Subject).Message.code)
            {
                case MessageCode.PROFILE_CHANGED:
                    Dictionary<EffectStatusIDs, Key> buffMappingClone = new Dictionary<EffectStatusIDs, Key>(ProfileSingleton.GetCurrent().Autobuff.buffMapping);
                    this.updateInputValues(buffMappingClone);
                    break;
                case MessageCode.TURN_OFF:
                    ProfileSingleton.GetCurrent().Autobuff.Stop();
                    break;
                case MessageCode.TURN_ON:
                    ProfileSingleton.GetCurrent().Autobuff.Start();
                    break;
            }
        }

 

        private void ConfigureInputs()
        {
            foreach (Control c in FormUtils.GetAll(this, typeof(_4RTextInput)))
                if (c is _4RTextInput)
                {
                    _4RTextInput textBox = (_4RTextInput)c;
                    textBox._TextChanged += new EventHandler(this.onTextChange);
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
                    _4RTextInput textBox = (_4RTextInput)c[0];
                    textBox.Value = autobuffDict[effect].ToString();
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
                    ProfileSingleton.GetCurrent().Autobuff.AddKeyToBuff(statusID, key);
                    ProfileSingleton.SetConfiguration(ProfileSingleton.GetCurrent().Autobuff);
                }
            }
            catch { }
        }
    }
}
