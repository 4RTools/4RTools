using System;
using System.Windows.Forms;
using _4RTools.Utils;
using _4RTools.Model;
using System.Windows.Input;

namespace _4RTools.Forms
{
    public partial class AHKForm : Form, IObserver
    {
        private AHK ahk = new AHK();
        private AutoRefreshSpammer autoRefreshSpammer = new AutoRefreshSpammer();

        public AHKForm(Subject subject)
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
            if((subject as Subject).Message.code == MessageCode.PROFILE_CHANGED)
            {
                FormUtils.ResetForm(this);
                this.ahk = ProfileSingleton.GetCurrent().AHK;
                this.autoRefreshSpammer = ProfileSingleton.GetCurrent().AutoRefreshSpammer;

                foreach (string key in this.ahk.ahkEntries.Keys)
                {
                    ToggleCheckboxByName(key, true);
                }
                ToggleCheckboxByName(this.chkMouseFlick.Name, this.ahk.mouseFlick);
                this.txtSpammerDelay.Text = this.ahk.ahkDelay.ToString();
                this.txtSkillTimerKey.Text = this.autoRefreshSpammer.refreshKey.ToString();
                this.txtAutoRefreshDelay.Text = this.autoRefreshSpammer.refreshDelay.ToString();
            }
            else if ((subject as Subject).Message.code == MessageCode.TURN_ON)
            {
                this.ahk.Start();
                this.autoRefreshSpammer.Start();
            } else if ((subject as Subject).Message.code == MessageCode.TURN_OFF)
            {
                this.ahk.Stop();
                this.autoRefreshSpammer.Stop();
            }
        }

        private void onCheckChange(object sender, EventArgs e)
        {
            CheckBox checkbox = (CheckBox)sender;

            if(checkbox.Text == "Mouse Flick")
            {
                this.ahk.mouseFlick = checkbox.Checked;
            }
            else
            {
                Key key = (Key)new KeyConverter().ConvertFromString(checkbox.Text);
                if (checkbox.Checked)
                    this.ahk.AddAHKEntry(checkbox.Name, key);
                else
                    this.ahk.RemoveAHKEntry(checkbox.Name);

            }

            ProfileSingleton.SetConfiguration(this.ahk);

        }

        private void txtSpammerDelay_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.ahk.ahkDelay = Int16.Parse(this.txtSpammerDelay.Text);
                ProfileSingleton.SetConfiguration(this.ahk);
            }
            catch(Exception)
            {
                this.ahk.ahkDelay = 10;
            }
        }


        private void ToggleCheckboxByName(string Name, bool state)
        {
            foreach (Control c in this.Controls)
                if (c.Name == Name)
                {
                    CheckBox a = (CheckBox)c;
                    a.Checked = state;
                }
            ProfileSingleton.SetConfiguration(this.ahk);
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
            catch (Exception)
            {
            }
        }
    }
}
