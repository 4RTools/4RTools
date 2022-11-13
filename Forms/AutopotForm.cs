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
        private bool isYgg;

        public AutopotForm(Subject subject, bool isYgg)
        {
            InitializeComponent();
            if (isYgg)
            {
                this.picBoxHP.Image = Resources._4RTools.ETCResource.Yggdrasil;
                this.picBoxSP.Image = Resources._4RTools.ETCResource.Yggdrasil;
            }
            subject.Attach(this);
            this.isYgg = isYgg;
        }

        public void Update(ISubject subject)
        {
            switch ((subject as Subject).Message.code)
            {
                case MessageCode.PROFILE_CHANGED:
                    this.autopot = this.isYgg ? ProfileSingleton.GetCurrent().AutopotYgg : ProfileSingleton.GetCurrent().Autopot;
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
            this.txtHpKey.Text = this.autopot.hpKey.ToString();
            this.txtSPKey.Text = this.autopot.spKey.ToString();
            this.txtHPpct.Text = this.autopot.hpPercent.ToString();
            this.txtSPpct.Text = this.autopot.spPercent.ToString();
            this.txtAutopotDelay.Text = this.autopot.delay.ToString();


            txtHpKey.KeyDown += new System.Windows.Forms.KeyEventHandler(FormUtils.OnKeyDown);
            txtHpKey.KeyPress += new KeyPressEventHandler(FormUtils.OnKeyPress);
            txtHpKey.TextChanged += new EventHandler(this.onHpTextChange);
            txtSPKey.KeyDown += new System.Windows.Forms.KeyEventHandler(FormUtils.OnKeyDown);
            txtSPKey.KeyPress += new KeyPressEventHandler(FormUtils.OnKeyPress);
            txtSPKey.TextChanged += new EventHandler(this.onSpTextChange);


        }

        private void onHpTextChange(object sender, EventArgs e)
        {
            Key key = (Key)Enum.Parse(typeof(Key), txtHpKey.Text.ToString());
            this.autopot.hpKey = key;
            ProfileSingleton.SetConfiguration(this.autopot);
        }

        private void onSpTextChange(object sender, EventArgs e)
        {
            Key key = (Key)Enum.Parse(typeof(Key), txtSPKey.Text.ToString());
            this.autopot.spKey = key;
            ProfileSingleton.SetConfiguration(this.autopot);
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
        }
    }
}
