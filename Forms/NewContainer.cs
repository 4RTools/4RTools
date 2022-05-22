using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using System.Collections.Generic;
using _4RTools.Utils;

namespace _4RTools.Forms
{
    public partial class NewContainer : Form
    {

        private Subject _subject = new Subject();
        private Button currentButton;
        private Panel leftBorderBtn;

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
            btnAutopot.PerformClick();
        }

        private void InstantiateForms()
        {
            forms.Add("Autopot", new AutopotForm(_subject, false));
            forms.Add("Spammer", new AHKForm(_subject));
            forms.Add("AutobuffStuff", new StuffAutoBuffForm(_subject));
            forms.Add("AutobuffSkill", new SkillAutoBuffForm(_subject));
            forms.Add("MacroSongs", new MacroSongForm(_subject));
            forms.Add("ATKDEF", new ATKDEFForm(_subject));
            forms.Add("MacroSwitch", new MacroSwitchForm(_subject));

        }


        private void ActivateButton(object senderBtn, Color color)
        {
            if(senderBtn != null)
            {
                currentButton = (Button)senderBtn;
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentButton.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
            }
        }

        private void InitializeButtonsBehaviours()
        {
            foreach(Control c in this.panelMenu.Controls)
            {
                if (c is Button)
                {
                    Button button = (Button)c;
                    button.Click += new EventHandler(this.onClickButton);
                }
            }
        }

        private void onClickButton(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(255, 255, 255));
            lblTitle.Text = ((Button)sender).Text;
            OpenChildForm(((Button)sender).Tag.ToString());
        }

        private void OpenChildForm(string formName)
        {
            if(currentChildForm != null && currentChildForm == forms[formName]) { return ; }

            Form childForm = forms[formName];
            this.currentChildForm = childForm;
            this.panelDesktop.Controls.Clear();

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Add(childForm);
            this.panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        
        private void panelTitle_MouseDown(object sender, MouseEventArgs e)
        {
            Interop.ReleaseCapture();
            Interop.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            KeyboardHook.Disable();
            //_subject.Notify(new Utils.Message(MessageCode.TURN_OFF, null)); TODO ENABLE THIS WHEN FINISH
            Environment.Exit(0);
        }

        private void containerResize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized) { this.Hide(); }
        }

        private void btnMimimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void panelDesktop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
