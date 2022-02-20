using System.Windows.Forms;
using System;
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
            this.autopot = new Model.Autopot();

            // loadProfile
            this.autopot.hpKey = Keys.F2;
            this.autopot.hpPercent = 99;
            this.autopot.delay = 10;

            this.autopot.spKey = Keys.F3;
            this.autopot.spPercent = 70;

            this.InitializeApplicationForm();
        }

        public void Update(ISubject subject)
        {

            if ((subject as Subject).Message.code == MessageCode.PROCESS_CHANGED)
            {
                this.progressBarHP.Maximum = (int)Model.ClientSingleton.GetClient().ReadMaxHp();
                this.progressBarHP.Value = (int)Model.ClientSingleton.GetClient().ReadCurrentHp();

                this.progressBarSP.Maximum = (int)Model.ClientSingleton.GetClient().ReadMaxSp();
                this.progressBarSP.Value = (int)Model.ClientSingleton.GetClient().ReadCurrentSp();

                this.txtAutopotDelay.Text = this.autopot.delay.ToString();
            }else if((subject as Subject).Message.code == MessageCode.TURN_OFF)
            {
                this.autopot.Stop();
            }
            else if ((subject as Subject).Message.code == MessageCode.TURN_ON)
            {
                this.autopot.Start();
            }
        }

        private void InitializeApplicationForm()
        {
            this.cbHPKey.SelectedValue = this.autopot.hpKey;
            this.cbSPKey.SelectedValue = this.autopot.spKey;
        }

        //UPDATE HP HOTKEY
        private void cbHPKey_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.autopot != null)
            {
                this.autopot.hpKey = (Keys)this.cbHPKey.SelectedValue;
            }
            
        }

        //UPDATE SP HOTKEY
        private void cbSPKey_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.autopot != null)
            {
                this.autopot.spKey = (Keys)this.cbSPKey.SelectedValue;
            }
        }

        private void txtAutopotDelay_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.autopot.delay = Int16.Parse(this.txtAutopotDelay.Text);
            }
            catch
            {

            }
        }

        private void txtHPpct_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.autopot.hpPercent = Int16.Parse(this.txtHPpct.Text);
            }
            catch (Exception ex) { }
            
        }

        private void txtSPpct_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.autopot.spPercent = Int16.Parse(this.txtSPpct.Text);
            }catch (Exception ex) { }
            
        }
    }
}
