using System;
using System.Collections.Generic;
using System.Windows.Forms;
using _4RTools.Utils;
using _4RTools.Model;
using System.Windows.Input;
namespace _4RTools.Forms
{
    public partial class SkillTimerForm : Form, IObserver
    {
        public SkillTimerForm(Subject subject)
        {
            InitializeComponent();
            subject.Attach(this);


            // Default values
            this.txtSkillTimerKey.KeyDown += new System.Windows.Forms.KeyEventHandler(FormUtils.OnKeyDown);
            this.txtSkillTimerKey.KeyPress += new KeyPressEventHandler(FormUtils.OnKeyPress);
            this.txtSkillTimerKey.TextChanged += new EventHandler(this.onSkillTimerKeyChange);
            this.txtAutoRefreshDelay.ValueChanged += new EventHandler(this.txtAutoRefreshDelayTextChanged);

        }

        public void Update(ISubject subject)
        {
            switch ((subject as Subject).Message.code)
            {
                case MessageCode.PROFILE_CHANGED:
                    FormUtils.ResetForm(this);
                    this.txtSkillTimerKey.Text = ProfileSingleton.GetCurrent().AutoRefreshSpammer.refreshKey.ToString();
                    this.txtAutoRefreshDelay.Text = ProfileSingleton.GetCurrent().AutoRefreshSpammer.refreshDelay.ToString();
                    break;
                case MessageCode.TURN_ON:
                    ProfileSingleton.GetCurrent().AutoRefreshSpammer.Start();
                    break;
                case MessageCode.TURN_OFF:
                    ProfileSingleton.GetCurrent().AutoRefreshSpammer.Stop();
                    break;
            }
        }


        private void onSkillTimerKeyChange(object sender, EventArgs e)
        {
            Key key = (Key)Enum.Parse(typeof(Key), txtSkillTimerKey.Text.ToString());
            ProfileSingleton.GetCurrent().AutoRefreshSpammer.refreshKey = key;
            ProfileSingleton.SetConfiguration(ProfileSingleton.GetCurrent().AutoRefreshSpammer);
        }

        private void txtAutoRefreshDelayTextChanged(object sender, EventArgs e)
        {
            try
            {
                ProfileSingleton.GetCurrent().AutoRefreshSpammer.refreshDelay = Int16.Parse(this.txtAutoRefreshDelay.Text);
                ProfileSingleton.SetConfiguration(ProfileSingleton.GetCurrent().AutoRefreshSpammer);
            }
            catch { }
        }
    }
}
