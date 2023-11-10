using System;
using System.Windows.Forms;
using _4RTools.Utils;
using _4RTools.Model;
using System.Windows.Input;

namespace _4RTools.Forms
{
    public partial class CustomButtonForm : Form, IObserver
    {

        private Custom custom;
        public CustomButtonForm(Subject subject)
        {
            InitializeComponent();
            subject.Attach(this);

            //this.txtTransferKey.KeyDown += new System.Windows.Forms.KeyEventHandler(FormUtils.OnKeyDown);
            //this.txtTransferKey.KeyPress += new KeyPressEventHandler(FormUtils.OnKeyPress);
            //this.txtTransferKey.TextChanged += new EventHandler(onTransferKeyChange);

            //this.txtAutoClickKey.KeyDown += new System.Windows.Forms.KeyEventHandler(FormUtils.OnKeyDown);
            //this.txtAutoClickKey.KeyPress += new KeyPressEventHandler(FormUtils.OnKeyPress);
            //this.txtAutoClickKey.TextChanged += new EventHandler(onAutoClickKeyChange);
        }

        public void Update(ISubject subject)
        {

            switch ((subject as Subject).Message.code)
            {
                case MessageCode.PROFILE_CHANGED:
                    InitializeApplicationForm();
                    break;
                case MessageCode.TURN_OFF:
                    this.custom.Stop();
                    break;
                case MessageCode.TURN_ON:
                    this.custom.Start();
                    break;
            }
        }

        private void InitializeApplicationForm()
        {
            this.custom = ProfileSingleton.GetCurrent().Custom; 
            this.txtTransferKey.Text = custom.tiMode.ToString();

            this.txtTransferKey.KeyDown += new System.Windows.Forms.KeyEventHandler(FormUtils.OnKeyDown);
            this.txtTransferKey.KeyPress += new KeyPressEventHandler(FormUtils.OnKeyPress);
            this.txtTransferKey.TextChanged += new EventHandler(onTransferKeyChange);
        }

        private void onTransferKeyChange(object sender, EventArgs e)
        {
            Key key = (Key)Enum.Parse(typeof(Key), this.txtTransferKey.Text.ToString());
            try
            {
                this.custom.tiMode = key;
                ProfileSingleton.SetConfiguration(this.custom);
            }
            catch { }
            this.ActiveControl = null;
        }

        //private void onAutoClickKeyChange(object sender, EventArgs e)
        //{
        //}
    }
}
