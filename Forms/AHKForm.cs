using System;
using System.Collections.Generic;
using System.Windows.Forms;
using _4RTools.Utils;
using _4RTools.Model;
using _4RTools.Components;
using System.Windows.Input;

namespace _4RTools.Forms
{
    public partial class AHKForm : Form, IObserver
    {
        KeyConverter _keyConverter = new KeyConverter();

        public AHKForm(Subject subject)
        {
            InitializeComponent();
            this.
            InitializeCheckAsThreeState();
            subject.Attach(this);
            FormUtils.AttachFormToPanel(new SkillTimerForm(subject), panelSkillTimer);
        }

        public void Update(ISubject subject)
        {
            switch ((subject as Subject).Message.code)
            {
                case MessageCode.PROFILE_CHANGED:
                    FormUtils.ResetForm(this);
                    Dictionary<string, KeyConfig> ahkClones = new Dictionary<string, KeyConfig>(ProfileSingleton.GetCurrent().AHK.ahkEntries);

                    foreach (KeyValuePair<string, KeyConfig> config in ahkClones)
                    {
                        ToggleCheckboxByName(config.Key, config.Value.clickActive);
                    }

                    this.txtSpammerDelay.Text = ProfileSingleton.GetCurrent().AHK.ahkDelay.ToString();
                    break;
                case MessageCode.TURN_ON:
                    ProfileSingleton.GetCurrent().AHK.Start();
                    break;
                case MessageCode.TURN_OFF:
                    ProfileSingleton.GetCurrent().AHK.Stop();
                    break;
            }
        }

        private void onCheckChange(object sender, EventArgs e)
        {
            _4RCheckBox checkbox = (_4RCheckBox)sender;

            Key key = (Key) _keyConverter.ConvertFromString(checkbox.Tag.ToString()) ;
            bool haveMouseClick = checkbox.CheckState == CheckState.Checked ? true : false;


            if (checkbox.CheckState == CheckState.Checked || checkbox.CheckState == CheckState.Indeterminate)
                ProfileSingleton.GetCurrent().AHK.AddAHKEntry(checkbox.Name, new KeyConfig(key, haveMouseClick));
            else
                ProfileSingleton.GetCurrent().AHK.RemoveAHKEntry(checkbox.Name);

            ProfileSingleton.GetCurrent().AHK.Persist();
        }

        private void txtSpammerDelay_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ProfileSingleton.GetCurrent().AHK.ahkDelay = Int16.Parse(this.txtSpammerDelay.Text);
                ProfileSingleton.GetCurrent().AHK.Persist();
            }
            catch{ }
        }


        private void ToggleCheckboxByName(string Name, bool state)
        {
            try
            {
                CheckBox checkBox = (CheckBox)this.Controls.Find(Name, true)[0];
                checkBox.CheckState = state ? CheckState.Checked : CheckState.Indeterminate;
                ProfileSingleton.SetConfiguration(ProfileSingleton.GetCurrent().AHK);
            }
            catch { }
        }


        private void InitializeCheckAsThreeState()
        {
            foreach (_4RCheckBox check in FormUtils.GetAll(this, typeof(_4RCheckBox)))
            {
                if ((check.Name.Split(new[] { "chk" }, StringSplitOptions.None).Length == 2))
                {
                    check.ThreeState = true;
                };

                if (check.Enabled)
                    check.CheckStateChanged += onCheckChange;
                }
        }
    }
}
