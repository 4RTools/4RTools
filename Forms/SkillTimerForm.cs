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

            this.txtSkillTimerKey1.KeyDown += new System.Windows.Forms.KeyEventHandler(FormUtils.OnKeyDown);
            this.txtSkillTimerKey1.KeyPress += new KeyPressEventHandler(FormUtils.OnKeyPress);
            this.txtSkillTimerKey1.TextChanged += new EventHandler(this.onSkillTimerKeyChange1);
            this.txtAutoRefreshDelay1.ValueChanged += new EventHandler(this.txtAutoRefreshDelayTextChanged1);

        }

        public void Update(ISubject subject)
        {
            switch ((subject as Subject).Message.code)
            {
                case MessageCode.PROFILE_CHANGED:
                    //FormUtils.ResetForm(this);
                    this.txtSkillTimerKey.Text = ProfileSingleton.GetCurrent().AutoRefreshSpammer.refreshKey.ToString();
                    this.txtAutoRefreshDelay.Text = ProfileSingleton.GetCurrent().AutoRefreshSpammer.refreshDelay.ToString();
                    this.txtSkillTimerKey1.Text = ProfileSingleton.GetCurrent().AutoRefreshSpammer.refreshKey1.ToString();
                    this.txtAutoRefreshDelay1.Text = ProfileSingleton.GetCurrent().AutoRefreshSpammer.refreshDelay1.ToString();
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
        private void onSkillTimerKeyChange1(object sender, EventArgs e)
        {
            Key key = (Key)Enum.Parse(typeof(Key), txtSkillTimerKey1.Text.ToString());
            ProfileSingleton.GetCurrent().AutoRefreshSpammer.refreshKey1 = key;
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
        private void txtAutoRefreshDelayTextChanged1(object sender, EventArgs e)
        {
            try
            {
                ProfileSingleton.GetCurrent().AutoRefreshSpammer.refreshDelay1 = Int16.Parse(this.txtAutoRefreshDelay1.Text);
                ProfileSingleton.SetConfiguration(ProfileSingleton.GetCurrent().AutoRefreshSpammer);
            }
            catch { }
        }
    }
}
