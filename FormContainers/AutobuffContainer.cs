using _4RTools.Components;
using _4RTools.Model;
using _4RTools.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace _4RTools.FormContainers
{
    internal class AutobuffContainer : IObserver
    {
        private Form parentForm;
        public AutobuffContainer(Form _parentForm, Subject subject)
        {
            this.parentForm = _parentForm;
            subject.Attach(this);
        }

        public void StartConfiguration()
        {
            this.ConfigureInputs();
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
            foreach (_4RTextInput textBox in FormUtils.GetAll(this.parentForm, typeof(_4RTextInput)))
            {
                textBox._TextChanged += new EventHandler(this.onTextChange);
            }
        }

        private void updateInputValues(Dictionary<EffectStatusIDs, Key> autobuffDict)
        {
            FormUtils.ResetTextInputInForm(this.parentForm);
            foreach (EffectStatusIDs effect in autobuffDict.Keys)
            {
                string inputName = "in" + (int)effect;
                _4RTextInput cFiltered = (_4RTextInput) FormUtils.GetByName(this.parentForm, typeof(_4RTextInput), inputName);
                if (cFiltered != null)
                {
                    cFiltered.Value = autobuffDict[effect].ToString();
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
                    ProfileSingleton.GetCurrent().Autobuff.Persist();
                }
            }
            catch { }
        }

    }
}
