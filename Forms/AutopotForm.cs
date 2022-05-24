using System.Windows.Forms;
using System;
using System.Windows.Input;
using _4RTools.Model;
using _4RTools.Utils;

namespace _4RTools.Forms
{
    public partial class AutopotForm : Form, IObserver
    {
        private Autopot autopot;

        public AutopotForm(Subject subject, Autopot autopotInstance)
        {
            InitializeComponent();
            this.autopot = autopotInstance;
            subject.Attach(this);

            if (this.autopot.GetActionName().Equals(Autopot.ACTION_NAME_AUTOPOT_YGG))
            {
                this.picBoxHP.Image = Properties.Resources.Yggdrasil;
                this.picBoxSP.Image = Properties.Resources.Yggdrasil;
            }

            txtHpKey.TextChanged += new EventHandler(this.onHpTextChange);
            txtSPKey.TextChanged += new EventHandler(this.onSpTextChange);
        }

        public void Update(ISubject subject)
        {
            switch ((subject as Subject).Message.code)
            {
                case MessageCode.PROFILE_CHANGED:
                    this.autopot = this.autopot.GetActionName().Equals(Autopot.ACTION_NAME_AUTOPOT) ? 
                        ProfileSingleton.GetCurrent().Autopot : ProfileSingleton.GetCurrent().AutopotYgg;
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
            this.txtHpKey.Value = this.autopot.hpKey.ToString();
            this.txtSPKey.Value = this.autopot.spKey.ToString();
            this.txtHPpct.Value = this.autopot.hpPercent;
            this.txtSPpct.Value = this.autopot.spPercent;
            this.txtAutopotDelay.Value = this.autopot.delay;
        }

        private void onHpTextChange(object sender, EventArgs e)
        {
            Key key = (Key)Enum.Parse(typeof(Key), txtHpKey.Value.ToString());
            this.autopot.hpKey = key;
            this.autopot.Persist();
        }

        private void onSpTextChange(object sender, EventArgs e)
        {
            Key key = (Key)Enum.Parse(typeof(Key), txtSPKey.Value.ToString());
            this.autopot.spKey = key;
            this.autopot.Persist();
        }

        private void txtAutopotDelayTextChanged(object sender, EventArgs e)
        {
            try
            {
                this.autopot.delay = (int) this.txtAutopotDelay.Value;
                this.autopot.Persist();
            }
            catch (Exception) { }
        }

        private void txtHPpctTextChanged(object sender, EventArgs e)
        {
            try
            {
                this.autopot.hpPercent = (int)this.txtHPpct.Value;
                this.autopot.Persist();
            }
            catch (Exception) { }

        }

        private void txtSPpctTextChanged(object sender, EventArgs e)
        {
            try
            {
                this.autopot.spPercent = (int)this.txtSPpct.Value;
                this.autopot.Persist();
            }
            catch (Exception) { }
        }
    }
}
