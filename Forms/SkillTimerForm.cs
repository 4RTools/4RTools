using _4RTools.Utils;
using _4RTools.Model;
using System.Windows.Forms;
using System.Windows.Input;
using System;

namespace _4RTools.Forms
{
    public partial class SkillTimerForm : Form, IObserver
    {
        public SkillTimerForm(Subject _subject)
        {
            InitializeComponent();
            _subject.Attach(this);
            this.BackColor = ProfileSingleton.GetCurrent().Theme.Panels.BackgroundColor;
        }

        public void Update(ISubject subject)
        {
            switch ((subject as Subject).Message.code)
            {
                case MessageCode.PROFILE_CHANGED:
                    FormUtils.ResetForm(this);

                    this.txtSkillTimerKey.Value = ProfileSingleton.GetCurrent().SkillTimer.refreshKey.ToString();
                    this.txtAutoRefreshDelay.Text = ProfileSingleton.GetCurrent().SkillTimer.refreshDelay.ToString();
                    break;
                case MessageCode.TURN_ON:
                    ProfileSingleton.GetCurrent().SkillTimer.Start();
                    break;
                case MessageCode.TURN_OFF:
                    ProfileSingleton.GetCurrent().SkillTimer.Stop();
                    break;
            }
        }

        private void onSkillTimerKeyChange(object sender, EventArgs e)
        {
            Key key = (Key)Enum.Parse(typeof(Key), txtSkillTimerKey.Value.ToString());
            ProfileSingleton.GetCurrent().SkillTimer.refreshKey = key;
            ProfileSingleton.GetCurrent().SkillTimer.Persist();
        }

        private void onSkillTimerDelayChange(object sender, EventArgs e)
        {
            try
            {
                ProfileSingleton.GetCurrent().SkillTimer.refreshDelay = Int16.Parse(this.txtAutoRefreshDelay.Text);
                ProfileSingleton.GetCurrent().SkillTimer.Persist();
            }
            catch { }
        }


    }
}
