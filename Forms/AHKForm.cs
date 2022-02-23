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
        private const int AHK_DELAY_DEFAULT_MS = 100;

        public AHKForm(Subject subject)
        {
            InitializeComponent();
            subject.Attach(this);
            this.ahk.ahkDelay = AHK_DELAY_DEFAULT_MS;
            this.txtSpammerDelay.Text = AHK_DELAY_DEFAULT_MS.ToString();
        }

        public void Update(ISubject subject)
        {
            if((subject as Subject).Message.code == MessageCode.PROFILE_CHANGED)
            {
                FormUtils.ResetForm(this);
                this.ahk = ProfileSingleton.GetCurrent().AHK;

                foreach (string key in this.ahk.ahkEntries.Keys)
                {
                    ToggleCheckboxByName(key, true);
                }

                this.ahk.Start();
            }
            else if ((subject as Subject).Message.code == MessageCode.TURN_ON)
            {
                this.ahk.Start();
            } else if ((subject as Subject).Message.code == MessageCode.TURN_OFF)
            {
                this.ahk.Stop();
            }
        }

        private void onCheckChange(object sender, EventArgs e)
        {
            CheckBox checkbox = (CheckBox)sender;
            Key key = (Key) new KeyConverter().ConvertFromString(checkbox.Text);

            if (checkbox.Checked)
                this.ahk.AddAHKEntry(checkbox.Name, key);
            else
                this.ahk.RemoveAHKEntry(checkbox.Name);

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

    }
}
