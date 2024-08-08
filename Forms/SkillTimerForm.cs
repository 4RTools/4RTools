using System;
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


            // Default values skill timer 1
            this.txtSkillTimerKey.KeyDown += new System.Windows.Forms.KeyEventHandler(FormUtils.OnKeyDown);
            this.txtSkillTimerKey.KeyPress += new KeyPressEventHandler(FormUtils.OnKeyPress);
            this.txtSkillTimerKey.TextChanged += new EventHandler(this.onSkillTimerKey1Change);
            this.txtAutoRefreshDelay.ValueChanged += new EventHandler(this.txthDelay1TextChanged);

            // Default values skill timer 2
            this.txtSkillTimerKey2.KeyDown += new System.Windows.Forms.KeyEventHandler(FormUtils.OnKeyDown);
            this.txtSkillTimerKey2.KeyPress += new KeyPressEventHandler(FormUtils.OnKeyPress);
            this.txtSkillTimerKey2.TextChanged += new EventHandler(this.onSkillTimerKey2Change);
            this.txtAutoRefreshDelay2.ValueChanged += new EventHandler(this.txthDelay2TextChanged);

            // Default values skill timer 3
            this.txtSkillTimerKey3.KeyDown += new System.Windows.Forms.KeyEventHandler(FormUtils.OnKeyDown);
            this.txtSkillTimerKey3.KeyPress += new KeyPressEventHandler(FormUtils.OnKeyPress);
            this.txtSkillTimerKey3.TextChanged += new EventHandler(this.onSkillTimerKey3Change);
            this.txtAutoRefreshDelay3.ValueChanged += new EventHandler(this.txthDelay3TextChanged);
        }

        public void Update(ISubject subject)
        {
            switch ((subject as Subject).Message.code)
            {
                case MessageCode.PROFILE_CHANGED:
                    string skillTimerKey1 = ProfileSingleton.GetCurrent().AutoRefreshSpammer1.RefreshKey.ToString();
                    string autoRefreshDelay1 = ProfileSingleton.GetCurrent().AutoRefreshSpammer1.RefreshDelay.ToString();

                    string skillTimerKey2 = ProfileSingleton.GetCurrent().AutoRefreshSpammer2.RefreshKey.ToString();
                    string autoRefreshDelay2 = ProfileSingleton.GetCurrent().AutoRefreshSpammer2.RefreshDelay.ToString();

                    string skillTimerKey3 = ProfileSingleton.GetCurrent().AutoRefreshSpammer3.RefreshKey.ToString();
                    string autoRefreshDelay3 = ProfileSingleton.GetCurrent().AutoRefreshSpammer3.RefreshDelay.ToString();

                    FormUtils.ResetForm(this);

                    this.txtSkillTimerKey.Text = skillTimerKey1;
                    this.txtAutoRefreshDelay.Text = autoRefreshDelay1;

                    this.txtSkillTimerKey2.Text = skillTimerKey2;
                    this.txtAutoRefreshDelay2.Text = autoRefreshDelay2;

                    this.txtSkillTimerKey3.Text = skillTimerKey3;
                    this.txtAutoRefreshDelay3.Text = autoRefreshDelay3;
                    break;
                case MessageCode.TURN_ON:
                    ProfileSingleton.GetCurrent().AutoRefreshSpammer1.Start();
                    ProfileSingleton.GetCurrent().AutoRefreshSpammer2.Start();
                    ProfileSingleton.GetCurrent().AutoRefreshSpammer3.Start();
                    break;
                case MessageCode.TURN_OFF:
                    ProfileSingleton.GetCurrent().AutoRefreshSpammer1.Stop();
                    ProfileSingleton.GetCurrent().AutoRefreshSpammer2.Stop();
                    ProfileSingleton.GetCurrent().AutoRefreshSpammer3.Stop();
                    break;
            }
        }


        private void onSkillTimerKey1Change(object sender, EventArgs e)
        {
            Key key = (Key)Enum.Parse(typeof(Key), this.txtSkillTimerKey.Text.ToString());
            ProfileSingleton.GetCurrent().AutoRefreshSpammer1.RefreshKey = key;
            ProfileSingleton.SetConfiguration(ProfileSingleton.GetCurrent().AutoRefreshSpammer1);
        }

        private void onSkillTimerKey2Change(object sender, EventArgs e)
        {
            Key key = (Key)Enum.Parse(typeof(Key), this.txtSkillTimerKey2.Text.ToString());
            ProfileSingleton.GetCurrent().AutoRefreshSpammer2.RefreshKey = key;
            ProfileSingleton.SetConfiguration(ProfileSingleton.GetCurrent().AutoRefreshSpammer2);
        }

        private void onSkillTimerKey3Change(object sender, EventArgs e)
        {
            Key key = (Key)Enum.Parse(typeof(Key), this.txtSkillTimerKey3.Text.ToString());
            ProfileSingleton.GetCurrent().AutoRefreshSpammer3.RefreshKey = key;
            ProfileSingleton.SetConfiguration(ProfileSingleton.GetCurrent().AutoRefreshSpammer3);
        }

        private void txthDelay1TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;

            try
            {
                ProfileSingleton.GetCurrent().AutoRefreshSpammer1.RefreshDelay = Int16.Parse(this.txtAutoRefreshDelay.Text);
                ProfileSingleton.SetConfiguration(ProfileSingleton.GetCurrent().AutoRefreshSpammer1);
            }
            catch(Exception ex) {
                MessageBox.Show($"[SkillTimer] {ex.Message}", "Please share this print screen on 4RTools discord.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txthDelay2TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;

            try
            {
                ProfileSingleton.GetCurrent().AutoRefreshSpammer2.RefreshDelay = Int16.Parse(this.txtAutoRefreshDelay2.Text);
                ProfileSingleton.SetConfiguration(ProfileSingleton.GetCurrent().AutoRefreshSpammer2);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"[SkillTimer] {ex.Message}", "Please share this print screen on 4RTools discord.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txthDelay3TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;

            try
            {
                ProfileSingleton.GetCurrent().AutoRefreshSpammer3.RefreshDelay = Int16.Parse(this.txtAutoRefreshDelay3.Text);
                ProfileSingleton.SetConfiguration(ProfileSingleton.GetCurrent().AutoRefreshSpammer3);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"[SkillTimer] Error Message: {ex.Message}", "Please share this print screen on 4RTools discord.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
