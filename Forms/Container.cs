using System;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using _4RTools.Model;
using _4RTools.Utils;

namespace _4RTools.Forms
{
    public partial class Container : Form
    {

        private Subject subject = new Subject();
        
        public Container()
        {
            Config.Load();
            if (!Directory.Exists(Config.ReadSetting("ProfileFolder")))
            {
                Directory.CreateDirectory(Utils.Config.ReadSetting("ProfileFolder")); //Create Profile Folder if don't exists.
            }
            InitializeComponent();
            Text = Config.ReadSetting("Name") + " - " + Utils.Config.ReadSetting("Version");
            KeyboardHook.Enable();
            KeyboardHook.Add(Keys.End, new KeyboardHook.KeyPressed(this.toggleStatus)); //Toggle System (ON-OFF)

            //Container Configuration
            this.IsMdiContainer = true;
            SetBackGroundColorOfMDIForm();

            //Paint Children Forms Below
            SetAutopotWindow();
            SetAutoStatusEffectWindow();
            SetAutoRefreshWindow();
            SetAHKWindow();
            SetProfileWindow();
            SetAutobuffSkillWindow();
        }

        public void SetAutopotWindow()
        {
            AutopotForm frm = new AutopotForm(subject);
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Location = new Point(0,90);
            frm.MdiParent = this;
            frm.Show();
        }

        public void SetAutoStatusEffectWindow()
        {
            StatusEffectForm form = new StatusEffectForm(subject);
            form.FormBorderStyle = FormBorderStyle.None;
            form.Location = new Point(225, 70);
            form.MdiParent = this;
            form.Show();
        }

        public void SetAutoRefreshWindow()
        {
            AutoRefreshForm form = new AutoRefreshForm(subject);
            form.FormBorderStyle = FormBorderStyle.None;
            form.Location = new Point(225, 136);
            form.MdiParent = this;
            form.Show();
        }

        public void SetAHKWindow()
        {
            AHKForm frm = new AHKForm(subject);
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Location = new Point(0, 65);
            frm.MdiParent = this;
            frm.Show();
            addform(this.tabPageSpammer, frm) ;
        }

        public void SetProfileWindow()
        {
            ProfileForm frm = new ProfileForm(this);
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Location = new Point(0, 65);
            frm.MdiParent = this;
            frm.Show();
            addform(this.tabPageProfiles, frm);
        }

        public void SetAutobuffSkillWindow()
        {
            StuffAutoBuffForm frm = new StuffAutoBuffForm(subject);
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Location = new Point(0, 65);
            frm.MdiParent = this;
            frm.Show();
            addform(this.tabPageAutobuffStuff, frm);
        }

        public void addform(TabPage tp, Form f)
        {

            if (!tp.Controls.Contains(f))
            {
                tp.Controls.Add(f);
                f.Dock = DockStyle.Fill;
                f.Show();
                Refresh();
            }
            Refresh();
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
            Client client = new Client(this.processCB.SelectedItem.ToString());
            ClientSingleton.Instance(client);
            characterName.Text = client.ReadCharacterName();
            subject.Notify(new Utils.Message(Utils.MessageCode.PROCESS_CHANGED, null));
            
        }

        private void Container_Load(object sender, EventArgs e)
        {
            if (!Profile.ProfileExists("Default")) {
                new Profile("Default").Save();
            }

            this.refreshProcessList();
            this.refreshProfileList();
        }

        public void refreshProfileList()
        {
            this.Invoke((MethodInvoker)delegate ()
            {
                this.profileCB.Items.Clear();
            });
            foreach (string p in Profile.ListAll())
            {
                this.profileCB.Items.Add(p);
            }
            this.profileCB.SelectedIndex = 0;
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

        private void btnToggleStatusHandler(object sender, EventArgs e)
        {
            this.toggleStatus();
        }

        private bool toggleStatus()
        {
            bool statusOn = this.btnStatusToggle.Text == "ON";

            if (statusOn) {
                this.btnStatusToggle.BackColor = Color.Red;
                this.btnStatusToggle.Text = "OFF";
                subject.Notify(new Utils.Message(MessageCode.TURN_OFF, null));
            } else {
                this.btnStatusToggle.BackColor = Color.Green;
                this.btnStatusToggle.Text = "ON";
                subject.Notify(new Utils.Message(MessageCode.TURN_ON, null));
            }

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

        private void profileCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProfileSingleton.Load(this.profileCB.Text); //LOAD PROFILE
            subject.Notify(new Utils.Message(Utils.MessageCode.PROFILE_CHANGED, null));
        }

        private void containerResize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                Hide();
                this.notifyIconTray.Visible = true;
            }
        }

        private void notifyIconDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            this.notifyIconTray.Visible = false;
        }
    }
}
