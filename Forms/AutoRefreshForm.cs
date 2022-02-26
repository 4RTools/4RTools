using System;
using System.Windows.Forms;
using _4RTools.Utils;
using _4RTools.Model;
using System.Windows.Input;

namespace _4RTools.Forms
{
    public partial class AutoRefreshForm : Form, IObserver
    {
        private AutoRefreshBuff autoRefreshBuff = new AutoRefreshBuff();

        public AutoRefreshForm(Subject subject)
        {
            InitializeComponent();
            subject.Attach(this);

            // Default values
            this.cbRefreshKey.DataSource = new BindingSource(KeyMap.getDict(), null);
            this.cbRefreshKey.SelectedValue = Key.None;
        }

        public void Update(ISubject subject)
        {
            switch ((subject as Subject).Message.code)
            {
                case MessageCode.PROFILE_CHANGED:
                    InitializeApplicationForm();
                    this.autoRefreshBuff.Start();
                    break;
                case MessageCode.TURN_OFF:
                    this.autoRefreshBuff.Stop();
                    break;
                case MessageCode.TURN_ON:
                    this.autoRefreshBuff.Start();
                    break;
            }
        }

        private void InitializeApplicationForm()
        {
            this.cbRefreshKey.SelectedValue = this.autoRefreshBuff.refreshKey;
            this.txtAutoRefreshDelay.Text = this.autoRefreshBuff.refreshDelay.ToString();
        }

        private void autoRefreshKeyIndexChanged(object sender, EventArgs e)
        {
            this.autoRefreshBuff.refreshKey = (Key)this.cbRefreshKey.SelectedValue;
        }

        private void txtAutoRefreshDelayTextChanged(object sender, EventArgs e)
        {
            try
            {
                this.autoRefreshBuff.refreshDelay = Int16.Parse(this.txtAutoRefreshDelay.Text);
            }
            catch (Exception) { }
        }
    }
}
