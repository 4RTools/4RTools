using System.Windows.Forms;
using System;
using System.Windows.Input;
using _4RTools.Model;
using _4RTools.Utils;

namespace _4RTools.Forms
{
    public partial class AutopotForm : Form, IObserver
    {
        private Model.Autopot autopot;

        public AutopotForm(Subject subject)
        {
            subject.Attach(this);
            InitializeComponent();
            this.cbHPKey.DataSource = new BindingSource(KeyMap.getDict(), null);
            this.cbSPKey.DataSource = new BindingSource(KeyMap.getDict(), null);
            this.autopot = new Autopot();

            // loadProfile
            // HP
            this.autopot.delay = 10;
            this.autopot.hpKey = Key.None;
            this.autopot.hpPercent = 99;
            // SP
            this.autopot.spKey = Key.None;
            this.autopot.spPercent = 70;

            this.InitializeApplicationForm();
        }

        public void Update(ISubject subject)
        {
            switch ((subject as Subject).Message.code)
            {
                case MessageCode.PROFILE_CHANGED:
                    this.autopot = ProfileSingleton.GetCurrent().Autopot;
                    InitializeApplicationForm();
                    break;
                case MessageCode.TURN_OFF:
                    this.autopot.Stop();
                    break;
                case MessageCode.TURN_ON:
                    this.autopot.Start();
                    break;
            }
        }

        private void InitializeApplicationForm()
        {
            this.cbHPKey.SelectedValue = this.autopot.hpKey;
            this.cbSPKey.SelectedValue = this.autopot.spKey;
            this.txtHPpct.Text = this.autopot.hpPercent.ToString();
            this.txtSPpct.Text = this.autopot.spPercent.ToString();
            this.txtAutopotDelay.Text = this.autopot.delay.ToString();
        }

        //UPDATE HP HOTKEY
        private void cbHPKeySelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.autopot != null)
            {
                this.autopot.hpKey = (Key)this.cbHPKey.SelectedValue;
                ProfileSingleton.SetConfiguration(this.autopot);
            }

        }

        //UPDATE SP HOTKEY
        private void cbSPKeySelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.autopot != null)
            {
                this.autopot.spKey = (Key)this.cbSPKey.SelectedValue;
                ProfileSingleton.SetConfiguration(this.autopot);
            }
        }

        private void txtAutopotDelayTextChanged(object sender, EventArgs e)
        {
            try
            {
                this.autopot.delay = Int16.Parse(this.txtAutopotDelay.Text);
                ProfileSingleton.SetConfiguration(this.autopot);
            }
            catch (Exception) { }
        }

        private void txtHPpctTextChanged(object sender, EventArgs e)
        {
            try
            {
                this.autopot.hpPercent = Int16.Parse(this.txtHPpct.Text);
                ProfileSingleton.SetConfiguration(this.autopot);
            }
            catch (Exception) { }

        }

        private void txtSPpctTextChanged(object sender, EventArgs e)
        {
            try
            {
                this.autopot.spPercent = Int16.Parse(this.txtSPpct.Text);
                ProfileSingleton.SetConfiguration(this.autopot);
            }
            catch (Exception) { }

        }    }
}
