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
            if((subject as Subject).Message.code == MessageCode.PROCESS_CHANGED)
            {

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
            var checkbox = (CheckBox)sender;
            Key key = (Key) new KeyConverter().ConvertFromString(checkbox.Text);

            if (checkbox.Checked)
                this.ahk.AddAHKEntry(key);
            else
                this.ahk.RemoveAHKEntry(key);
            
        }

        private void txtSpammerDelay_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.ahk.ahkDelay = Int16.Parse(this.txtSpammerDelay.Text);
            }catch(Exception ex)
            {
                this.ahk.ahkDelay = 10;
            }

        }
    }
}
