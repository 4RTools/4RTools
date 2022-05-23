using System;
using System.Drawing;
using System.Windows.Forms;
using _4RTools.Utils;
using _4RTools.Model;
using System.Media;
using _4RTools.Properties;

namespace _4RTools.Forms
{
    public partial class ToggleApplicationStateForm : Form, IObserver
    {
        private Subject subject;
        private ContextMenu contextMenu;
        private MenuItem menuItem;
        private bool isRunning = false;

        public ToggleApplicationStateForm(Subject subject)
        {
            InitializeComponent();

            subject.Attach(this);
            this.subject = subject;
            KeyboardHook.Enable();
            KeyboardHook.Add(Keys.End, new KeyboardHook.KeyPressed(this.toggleStatus)); //Toggle System (ON-OFF)
            this.txtStatusToggleKey.Value = ProfileSingleton.GetCurrent().UserPreferences.toggleStateKey;
            this.txtStatusToggleKey.TextChanged += new EventHandler(this.onStatusToggleKeyChange);

            InitializeContextualMenu();
        }

        private void InitializeContextualMenu()
        {
            this.contextMenu = new ContextMenu();
            this.menuItem = new MenuItem();

            this.contextMenu.MenuItems.AddRange(
                    new MenuItem[] { this.menuItem });


            this.menuItem.Index = 0;
            this.menuItem.Text = "Close";
            this.menuItem.Click += new System.EventHandler(this.notifyShutdownApplication);

            this.notifyIconTray.ContextMenu = this.contextMenu;
        }

        public void Update(ISubject subject)
        {
            if ((subject as Subject).Message.code == MessageCode.PROFILE_CHANGED)
            {
                
                FormUtils.ResetForm(this);
                this.txtStatusToggleKey.Value = ProfileSingleton.GetCurrent().UserPreferences.toggleStateKey.ToString();
            }
        }

        private void btnToggleStatusHandler(object sender, EventArgs e) { this.toggleStatus(); }

        private void onStatusToggleKeyChange(object sender, EventArgs e)
        {
            if (this.txtStatusToggleKey.Value != ProfileSingleton.GetCurrent().UserPreferences.toggleStateKey)
            {
                Keys previousKey = (Keys)Enum.Parse(typeof(Keys), ProfileSingleton.GetCurrent().UserPreferences.toggleStateKey);
                Keys newKey = (Keys)Enum.Parse(typeof(Keys), this.txtStatusToggleKey.Value);

                KeyboardHook.Remove(previousKey);
                KeyboardHook.Add(newKey, new KeyboardHook.KeyPressed(this.toggleStatus));
                ProfileSingleton.GetCurrent().UserPreferences.toggleStateKey = this.txtStatusToggleKey.Value;
                ProfileSingleton.SetConfiguration(ProfileSingleton.GetCurrent().UserPreferences);
            }
        }

        private bool toggleStatus()
        {
            if (isRunning)
            {
                this.btnStatusToggle.Image = Resources.TurnOFF;
                this.notifyIconTray.Icon = Resources.logo_4rtools_off;
                this.subject.Notify(new Utils.Message(MessageCode.TURN_OFF, null));
                this.lblStatus.Text = "Stopped";
                this.lblStatus.ForeColor = Color.FromArgb(255,0,0);
                //this.lblStatusToggle.Text = "Press the key to start!";
                new SoundPlayer(Resources.Speech_Off).Play();
                isRunning = false;
            }
            else
            {
                    this.btnStatusToggle.Image = Resources.TurnON;
                    this.notifyIconTray.Icon = Resources.logo_4rtools_on;
                    this.subject.Notify(new Utils.Message(MessageCode.TURN_ON, null));
                    //this.lblStatusToggle.Text = "Press the key to stop!";
                    //this.lblStatusToggle.ForeColor = Color.Black;
                    this.lblStatus.Text = "Running";
                    this.lblStatus.ForeColor = Color.LimeGreen;
                    new SoundPlayer(Resources.Speech_On).Play();
                    isRunning = true;
            }

            return true;
        }

        private void notifyIconDoubleClick(object sender, MouseEventArgs e)
        {
            this.subject.Notify(new Utils.Message(MessageCode.CLICK_ICON_TRAY, null));
        }

        private void notifyShutdownApplication(object Sender, EventArgs e)
        {
            // Close the form, which closes the application.
            this.subject.Notify(new Utils.Message(MessageCode.SHUTDOWN_APPLICATION, null));
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ToggleApplicationStateForm_Load(object sender, EventArgs e)
        {

        }
    }
}
