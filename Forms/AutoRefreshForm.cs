using System;
using System.Windows.Forms;
using _4RTools.Utils;
using _4RTools.Model;
using System.Windows.Input;

namespace _4RTools.Forms
{
    public partial class AutoRefreshForm : Form, IObserver
    {
        private AutoRefreshSpammer autoRefreshSpammer = new AutoRefreshSpammer();

        public AutoRefreshForm(Subject subject)
        {
            InitializeComponent();
            subject.Attach(this);

            // Default values
            this.txtSkillTimerKey.KeyDown += new System.Windows.Forms.KeyEventHandler(FormUtils.OnKeyDown);
            this.txtSkillTimerKey.KeyPress += new KeyPressEventHandler(FormUtils.OnKeyPress);
            this.txtSkillTimerKey.TextChanged += new EventHandler(this.onSkillTimerKeyChange);
        }

        public void Update(ISubject subject)
        {
            switch ((subject as Subject).Message.code)
            {
                case MessageCode.PROFILE_CHANGED:
                    this.autoRefreshSpammer = ProfileSingleton.GetCurrent().AutoRefreshSpammer;
                    InitializeApplicationForm();
                    break;
                case MessageCode.TURN_OFF:
                    this.autoRefreshSpammer.Stop();
                    break;
                case MessageCode.TURN_ON:
                    this.autoRefreshSpammer.Start();
                    break;
            }
        }

        private void InitializeApplicationForm()
        {
            this.txtSkillTimerKey.Text = this.autoRefreshSpammer.refreshKey.ToString();
            this.txtAutoRefreshDelay.Text = this.autoRefreshSpammer.refreshDelay.ToString();
        }

        private void onSkillTimerKeyChange(object sender, EventArgs e)
        {
            Key key = (Key)Enum.Parse(typeof(Key), txtSkillTimerKey.Text.ToString());
            this.autoRefreshSpammer.refreshKey = key;
            ProfileSingleton.SetConfiguration(this.autoRefreshSpammer);
        }



        private void txtAutoRefreshDelayTextChanged(object sender, EventArgs e)
        {
            try
            {
                this.autoRefreshSpammer.refreshDelay = Int16.Parse(this.txtAutoRefreshDelay.Text);
                ProfileSingleton.SetConfiguration(this.autoRefreshSpammer);
            }
            catch (Exception) { }
        }
    }
}
