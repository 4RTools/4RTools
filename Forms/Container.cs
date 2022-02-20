using System;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;

namespace _4RTools.Forms
{
    public partial class Container : Form
    {
        Utils.Subject subject = new Utils.Subject();
        public Container()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
            SetBackGroundColorOfMDIForm();
            SetAutopotWindow();
        }

        public void SetAutopotWindow()
        {
            AutopotForm frm = new AutopotForm(subject);
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Location = new Point(0,0);
            frm.MdiParent = this;
            frm.Show();
        }

        private void SetBackGroundColorOfMDIForm()
        {
            foreach (Control ctl in this.Controls)
            {
                if ((ctl) is MdiClient)
                {
                    ctl.BackColor = Color.White;
                }
            }
        }

        private void processCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            Model.Client client = new Model.Client(this.processCB.SelectedItem.ToString());
            if (client != null)
            {
                Model.ClientSingleton.Instance(client);
                subject.Notify(new Utils.Message(Utils.MessageCode.PROCESS_CHANGED, null));
            }
        }

        private void Container_Load(object sender, EventArgs e)
        {
            this.Invoke((MethodInvoker)delegate ()
            {
                this.processCB.Items.Clear();
            });
            foreach (Process p in Process.GetProcesses())
            {
                if (p.MainWindowTitle != "")
                {
                    this.processCB.Items.Add(string.Format("{0}.exe - {1}", p.ProcessName, p.Id));
                }
            }
        }

    }
}
