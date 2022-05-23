using System;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using System.Collections.Generic;
using _4RTools.Utils;
using _4RTools.Model;

namespace _4RTools.Forms
{
    public partial class NewContainer : Form, IObserver
    {

        private Subject _subject = new Subject();
        private Button currentButton;
        private Panel leftBorderBtn;
        private string currentProfile;

        private Form currentChildForm;
        private Dictionary<string, Form> forms = new Dictionary<string, Form>();

        public NewContainer()
        {
            InitializeComponent();
            InstantiateForms();

            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 42);
            panelMenu.Controls.Add(leftBorderBtn);

            this.Text = String.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            InitializeButtonsBehaviours();
            AttachFormToPanel("ApplicationState", this.appStatePanel);
        }

        #region OnFormLoad
        private void InstantiateForms()
        {
            forms.Add("Autopot", new AutopotForm(_subject, false));
            forms.Add("Spammer", new AHKForm(_subject));
            forms.Add("AutobuffStuff", new StuffAutoBuffForm(_subject));
            forms.Add("AutobuffSkill", new SkillAutoBuffForm(_subject));
            forms.Add("MacroSongs", new MacroSongForm(_subject));
            forms.Add("ATKDEF", new ATKDEFForm(_subject));
            forms.Add("MacroSwitch", new MacroSwitchForm(_subject));
            forms.Add("ApplicationState", new ToggleApplicationStateForm(_subject));
        }

        private void NewContainer_Load(object sender, EventArgs e)
        {
            ProfileSingleton.Create("Default");
            this.refreshProcessList();
            this.refreshProfileList();
            this.profileCB.Texts = "Default";
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

        private void InitializeButtonsBehaviours()
        {
            foreach (Control c in this.panelMenu.Controls)
            {
                if (c is Button)
                {
                    Button button = (Button)c;
                    button.Click += new EventHandler(this.onClickButton);
                }
            }
        }

        #endregion

        #region OnUpdate
        public void Update(ISubject subject)
        {
            switch ((subject as Subject).Message.code)
            {
                case MessageCode.TURN_ON:
                case MessageCode.PROFILE_CHANGED:
                    Client client = ClientSingleton.GetClient();
                    if (client != null)
                    {
                        lblCharacterName.Text = ClientSingleton.GetClient().ReadCharacterName();
                    }
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

        #endregion

        #region Handlers

        private void AttachFormToPanel(string formName, Panel p)
        {
            if (currentChildForm != null && currentChildForm == forms[formName]) { return; }

            Form childForm = forms[formName];
            this.currentChildForm = childForm;
            p.Controls.Clear();

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            p.Controls.Add(childForm);
            p.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                currentButton = (Button)senderBtn;
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentButton.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
            }
        }

        private void onClickButton(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(255, 255, 255));
            lblTitle.Text = ((Button)sender).Text;
            AttachFormToPanel(((Button)sender).Tag.ToString(), this.panelDesktop);
        }

        private void panelTitle_MouseDown(object sender, MouseEventArgs e)
        {
            Interop.ReleaseCapture();
            Interop.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            ShutdownApplication();
        }

        private void containerResize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized) { this.Hide(); }
        }

        private void btnMimimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnRefreshProcess_Click(object sender, EventArgs e)
        {
            this.refreshProcessList();
        }

        private void onProfileChanged(object sender, EventArgs e)
        {
            if (this.profileCB.Texts != currentProfile)
            {
                try
                {
                    ProfileSingleton.Load(this.profileCB.Texts); //LOAD PROFILE
                    _subject.Notify(new Utils.Message(MessageCode.PROFILE_CHANGED, null));
                    currentProfile = this.profileCB.Texts.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void onProcessChange(object sender, EventArgs e)
        {
            Client client = new Client(this.processCB.SelectedItem.ToString());
            ClientSingleton.Instance(client);
            lblCharacterName.ForeColor = Color.Green;
            lblCharacterName.Text = client.ReadCharacterName();
            _subject.Notify(new Utils.Message(Utils.MessageCode.PROCESS_CHANGED, null));

        }

        #endregion

        #region OnShutdownAPP
        private void ShutdownApplication()
        {
            KeyboardHook.Disable();
            _subject.Notify(new Utils.Message(MessageCode.TURN_OFF, null));
            Environment.Exit(0);
        }

        #endregion

    }
}
