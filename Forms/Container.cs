using System;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using _4RTools.Model;
using System.Media;
using _4RTools.Utils;
using _4RTools.Properties;

namespace _4RTools.Forms
{
    public partial class Container : Form
    {

        private Subject subject = new Subject();
        private String currentProfile;
        
        public Container()
        {
            Config.Load();
            if (!Directory.Exists(Config.ReadSetting("ProfileFolder")))
            {
                Directory.CreateDirectory(Config.ReadSetting("ProfileFolder")); //Create Profile Folder if don't exists.
            }
            InitializeComponent();
            this.Text = Config.ReadSetting("Name") + " - " + Config.ReadSetting("Version");
            KeyboardHook.Enable();
            KeyboardHook.Add(Keys.End, new KeyboardHook.KeyPressed(this.toggleStatus)); //Toggle System (ON-OFF

            //Container Configuration
            this.IsMdiContainer = true;
            SetBackGroundColorOfMDIForm();

            //Paint Children Forms Below
            SetAutopotWindow();
            SetAutopotYggWindow();
            SetAutoStatusEffectWindow();
            SetAHKWindow();
            SetProfileWindow();
            SetAutobuffStuffWindow();
            SetAutobuffSkillWindow();
            SetSongMacroWindow();

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
        public void SetAutoStatusEffectWindow()
        {
            StatusEffectForm form = new StatusEffectForm(subject);
            form.FormBorderStyle = FormBorderStyle.None;
            form.Location = new Point(50, 220);
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
                this.notifyIconTray.Icon = Resources.logo_4rtools_off;
                subject.Notify(new Utils.Message(MessageCode.TURN_OFF, null));
                new SoundPlayer(Resources.Speech_Off).Play();
            } else {
                this.btnStatusToggle.BackColor = Color.Green;
                this.btnStatusToggle.Text = "ON";
                this.notifyIconTray.Icon = Resources.logo_4rtools_on;
                subject.Notify(new Utils.Message(MessageCode.TURN_ON, null));
                new SoundPlayer(Resources.Speech_On).Play();
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
            Process.Start(Config.ReadSetting("GithubLink"));
        }

        private void lblLinkDiscord_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(Config.ReadSetting("DiscordLink"));
        }

        private void profileCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.profileCB.Text != currentProfile)
            {
                ProfileSingleton.Load(this.profileCB.Text); //LOAD PROFILE
                subject.Notify(new Utils.Message(MessageCode.PROFILE_CHANGED, null));
                currentProfile = this.profileCB.Text.ToString();
                Console.WriteLine("Profile Loaded:" + this.profileCB.Text.ToString());
            }
          
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
