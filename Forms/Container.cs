using System;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using _4RTools.Model;
using _4RTools.Utils;

namespace _4RTools.Forms
{
    public partial class Container : Form, IObserver
    {

        private Subject subject = new Subject();
        private string currentProfile;
        public Container()
        {
            this.subject.Attach(this);

            InitializeComponent();
            this.Text = AppConfig.Name + " - " + AppConfig.Version; // Window title

            //Container Configuration
            this.IsMdiContainer = true;
            SetBackGroundColorOfMDIForm();

            //Paint Children Forms 
            SetToggleApplicationStateWindow();
            SetAutopotWindow();
            SetAutopotYggWindow();
            SetSkillTimerWindow();
            SetAutoStatusEffectWindow();
            SetAHKWindow();
            SetProfileWindow();
            SetAutobuffStuffWindow();
            SetAutobuffSkillWindow();
            SetSongMacroWindow();
            SetATKDEFWindow();
            SetMacroSwitchWindow();
            SetServerWindow();
            SetAdvertisementWindow();

            TrackerSingleton.Instance().SendEvent("desktop_login", "page_view", "desktop_container_load");
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
            ProfileSingleton.Create("Default");
            this.refreshProcessList();
            this.refreshProfileList();
            this.profileCB.SelectedItem = "Default";
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
        }

        private void refreshProcessList()
        {
            this.Invoke((MethodInvoker)delegate ()
            {
                this.processCB.Items.Clear();
            });
            foreach (Process p in Process.GetProcesses())
            {
                if (p.MainWindowTitle != "" && ClientListSingleton.ExistsByProcessName(p.ProcessName))
                {
                    this.processCB.Items.Add(string.Format("{0}.exe - {1}", p.ProcessName, p.Id));
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.refreshProcessList();
        }

        protected override void OnClosed(EventArgs e)
        {
            ShutdownApplication();
            base.OnClosed(e);
        }

        private void ShutdownApplication()
        {
            KeyboardHook.Disable();
            subject.Notify(new Utils.Message(MessageCode.TURN_OFF, null));
            Environment.Exit(0);
        }

        private void lblLinkGithub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(AppConfig.GithubLink);
        }

        private void lblLinkDiscord_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(AppConfig.DiscordLink);
        }

        private void websiteLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(AppConfig.Website);
        }

        private void profileCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.profileCB.Text != currentProfile)
            {
                try
                {
                    ProfileSingleton.Load(this.profileCB.Text); //LOAD PROFILE
                    subject.Notify(new Utils.Message(MessageCode.PROFILE_CHANGED, null));
                    currentProfile = this.profileCB.Text.ToString();
                } catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void Update(ISubject subject)
        {
            switch ((subject as Subject).Message.code)
            {
                case MessageCode.TURN_ON: case MessageCode.PROFILE_CHANGED:
                    Client client = ClientSingleton.GetClient();
                    if (client != null)
                    {
                        characterName.Text = ClientSingleton.GetClient().ReadCharacterName();
                    }
                    break;
                case MessageCode.SERVER_LIST_CHANGED:
                    this.refreshProcessList();
                    break;
                case MessageCode.CLICK_ICON_TRAY:
                    this.Show();
                    this.WindowState = FormWindowState.Normal;
                    break;
                case MessageCode.SHUTDOWN_APPLICATION:
                    this.ShutdownApplication();
                    break;
            }
        }

        private void containerResize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized) { this.Hide(); }
        }

        #region Frames

        public void SetToggleApplicationStateWindow()
        {
            ToggleApplicationStateForm frm = new ToggleApplicationStateForm(subject);
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Location = new Point(350, 70);
            frm.MdiParent = this;
            frm.Show();
        }

        public void SetAdvertisementWindow()
        {
            AdvertisementForm frm = new AdvertisementForm();
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.MdiParent = this;
            this.panelAdvertisement.Controls.Add(frm);
            frm.Show();
        }

        public void SetAutopotWindow()
        {
            AutopotForm frm = new AutopotForm(subject, false);
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.MdiParent = this;
            frm.Show();
            addform(this.tabPageAutopot, frm);
        }
        public void SetAutopotYggWindow()
        {
            AutopotForm frm = new AutopotForm(subject, true);
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.MdiParent = this;
            frm.Show();
            addform(this.tabPageYggAutopot, frm);
        }

        public void SetSkillTimerWindow()
        {
            SkillTimerForm frm = new SkillTimerForm(subject);
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.MdiParent = this;
            frm.Show();
            addform(this.tabPageSkillTimer, frm);

        }
        public void SetAutoStatusEffectWindow()
        {
            StatusEffectForm form = new StatusEffectForm(subject);
            form.FormBorderStyle = FormBorderStyle.None;
            form.Location = new Point(20, 220);
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
            addform(this.tabPageSpammer, frm);
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

        public void SetServerWindow()
        {
            ServersForm frm = new ServersForm(subject);
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Location = new Point(0, 65);
            frm.MdiParent = this;
            frm.Show();
            addform(this.tabPageServer, frm);
        }

        public void SetAutobuffStuffWindow()
        {
            StuffAutoBuffForm frm = new StuffAutoBuffForm(subject);
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Location = new Point(0, 65);
            frm.MdiParent = this;
            frm.Show();
            addform(this.tabPageAutobuffStuff, frm);
        }

        public void SetAutobuffSkillWindow()
        {
            SkillAutoBuffForm frm = new SkillAutoBuffForm(subject);
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Location = new Point(0, 65);
            frm.MdiParent = this;
            addform(this.tabPageAutobuffSkill, frm);
            frm.Show();
        }

        public void SetSongMacroWindow()
        {
            MacroSongForm frm = new MacroSongForm(subject);
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Location = new Point(0, 65);
            frm.MdiParent = this;
            addform(this.tabPageMacroSongs, frm);
            frm.Show();
        }

        public void SetATKDEFWindow()
        {
            ATKDEFForm frm = new ATKDEFForm(subject);
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Location = new Point(0, 65);
            frm.MdiParent = this;
            addform(this.atkDef, frm);
            frm.Show();
        }

        public void SetMacroSwitchWindow()
        {
            MacroSwitchForm frm = new MacroSwitchForm(subject);
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Location = new Point(0, 65);
            frm.MdiParent = this;
            addform(this.tabMacroSwitch, frm);
            frm.Show();
        }

        #endregion
    }
}
