using System;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;

namespace _4RTools.Forms
{
    public partial class Container : Form
    {

        private Utils.Subject subject = new Utils.Subject();

        public Container()
        {
            InitializeComponent();
            Text = Utils.Config.ReadSetting("Name") + " - " + Utils.Config.ReadSetting("Version");
            Utils.KeyboardHook.Enable();
            Utils.KeyboardHook.Add(Keys.End, new Utils.KeyboardHook.KeyPressed(this.onPressEnd)); //Toggle System (ON-OFF)

            //Container Configuration
            this.IsMdiContainer = true;
            SetBackGroundColorOfMDIForm();

            //Paint Children Forms Below
            SetAutopotWindow();
        }


        public void SetAutopotWindow()
        {
            AutopotForm frm = new AutopotForm(subject);
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Location = new Point(0,65);
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
            Model.ClientSingleton.Instance(client);
            subject.Notify(new Utils.Message(Utils.MessageCode.PROCESS_CHANGED, null));
            
        }

        private void Container_Load(object sender, EventArgs e)
        {
            this.refreshProcessList();
        }

        private void refreshProcessList()
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

        private void chckToggle_CheckedChanged(object sender, EventArgs e)
        {
            subject.Notify(new Utils.Message(this.chckToggle.Checked ? Utils.MessageCode.TURN_ON : Utils.MessageCode.TURN_OFF, null));
        }

        private bool onPressEnd()
        {
            this.chckToggle.Checked = !this.chckToggle.Checked;
            return true;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.refreshProcessList();
        }

        protected override void OnClosed(EventArgs e)
        {
            Utils.KeyboardHook.Disable();
            subject.Notify(new Utils.Message(Utils.MessageCode.TURN_OFF, null));
            base.OnClosed(e);
        }

        private void lblLinkGithub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(Utils.Config.ReadSetting("GithubLink"));
        }

        private void lblLinkDiscord_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(Utils.Config.ReadSetting("DiscordLink"));
        }
    }
}
