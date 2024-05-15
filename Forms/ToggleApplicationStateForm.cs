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

        //Store key used for last profile - necessarly to clean when change profile
        private Keys lastKey;
        private Keys healLastKey;
        private Keys cityLastKey;
        private Keys ridingLastKey;

        public ToggleApplicationStateForm() { }

        public ToggleApplicationStateForm(Subject subject)
        {
            InitializeComponent();

            subject.Attach(this);
            this.subject = subject;
            KeyboardHook.Enable();
            this.txtStatusToggleKey.Text = ProfileSingleton.GetCurrent().UserPreferences.toggleStateKey;
            this.txtStatusToggleKey.KeyDown += new KeyEventHandler(FormUtils.OnKeyDown);
            this.txtStatusToggleKey.KeyPress += new KeyPressEventHandler(FormUtils.OnKeyPress);
            this.txtStatusToggleKey.TextChanged += new EventHandler(this.onStatusToggleKeyChange);

            this.txtStatusHealToggleKey.Text = ProfileSingleton.GetCurrent().UserPreferences.toggleStateHealKey;
            this.txtStatusHealToggleKey.KeyDown += new KeyEventHandler(FormUtils.OnKeyDown);
            this.txtStatusHealToggleKey.KeyPress += new KeyPressEventHandler(FormUtils.OnKeyPress);
            this.txtStatusHealToggleKey.TextChanged += new EventHandler(this.onStatusHealToggleKeyChange);

            this.txtCityToggleKey.Text = ProfileSingleton.GetCurrent().UserPreferences.toggleCityKey;
            this.txtCityToggleKey.KeyDown += new KeyEventHandler(FormUtils.OnKeyDown);
            this.txtCityToggleKey.KeyPress += new KeyPressEventHandler(FormUtils.OnKeyPress);
            this.txtCityToggleKey.TextChanged += new EventHandler(this.onCityToggleKeyChange);

            this.txtReinToggleKey.Text = ProfileSingleton.GetCurrent().UserPreferences.toggleReinKey;
            this.txtReinToggleKey.KeyDown += new KeyEventHandler(FormUtils.OnKeyDown);
            this.txtReinToggleKey.KeyPress += new KeyPressEventHandler(FormUtils.OnKeyPress);
            this.txtReinToggleKey.TextChanged += new EventHandler(this.onReinToggleKeyChange);
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
            this.menuItem.Click += new EventHandler(this.notifyShutdownApplication);

            this.notifyIconTray.ContextMenu = this.contextMenu;
        }

        public void Update(ISubject subject)
        {
            switch ((subject as Subject).Message.code)
            {
                case MessageCode.PROFILE_CHANGED:
                    Keys currentToggleKey = (Keys)Enum.Parse(typeof(Keys), ProfileSingleton.GetCurrent().UserPreferences.toggleStateKey);
                    KeyboardHook.RemoveDown(lastKey); //Remove last key hook to prevent toggle with last profile key used.

                    this.txtStatusToggleKey.Text = currentToggleKey.ToString();
                    KeyboardHook.AddKeyDown(currentToggleKey, new KeyboardHook.KeyPressed(this.toggleStatus));
                    lastKey = currentToggleKey;

                    Keys currentHealToggleKey = (Keys)Enum.Parse(typeof(Keys), ProfileSingleton.GetCurrent().UserPreferences.toggleStateHealKey);
                    KeyboardHook.RemoveUp(healLastKey); //Remove last key hook to prevent toggle with last profile key used.

                    this.txtStatusHealToggleKey.Text = currentHealToggleKey.ToString();
                    KeyboardHook.AddKeyUp(currentHealToggleKey, new KeyboardHook.KeyPressed(this.toggleStatusHeal));
                    healLastKey = currentHealToggleKey;

                    Keys currentCityToggleKey = (Keys)Enum.Parse(typeof(Keys), ProfileSingleton.GetCurrent().UserPreferences.toggleCityKey);
                    KeyboardHook.RemoveUp(cityLastKey); //Remove last key hook to prevent toggle with last profile key used.

                    this.txtCityToggleKey.Text = currentCityToggleKey.ToString();
                    KeyboardHook.AddKeyUp(currentCityToggleKey, new KeyboardHook.KeyPressed(this.toggleOnCity));
                    cityLastKey = currentCityToggleKey;

                    Keys currentRidingToggleKey = (Keys)Enum.Parse(typeof(Keys), ProfileSingleton.GetCurrent().UserPreferences.toggleReinKey);
                    KeyboardHook.RemoveUp(ridingLastKey); //Remove last key hook to prevent toggle with last profile key used.

                    this.txtReinToggleKey.Text = currentRidingToggleKey.ToString();
                    KeyboardHook.AddKeyUp(currentRidingToggleKey, new KeyboardHook.KeyPressed(this.toggleOnRein));
                    ridingLastKey = currentRidingToggleKey;
                    break;
                case MessageCode.TURN_CITY_ON:
                    ProfileSingleton.GetCurrent().UserPreferences.toggleCity = true; //Update profile key
                    ProfileSingleton.SetConfiguration(ProfileSingleton.GetCurrent().UserPreferences);
                    break;
                case MessageCode.TURN_CITY_OFF:
                    ProfileSingleton.GetCurrent().UserPreferences.toggleCity = false; //Update profile key
                    ProfileSingleton.SetConfiguration(ProfileSingleton.GetCurrent().UserPreferences);
                    break;
                case MessageCode.TURN_REIN_ON:
                    ProfileSingleton.GetCurrent().UserPreferences.toggleRein = true; //Update profile key
                    ProfileSingleton.SetConfiguration(ProfileSingleton.GetCurrent().UserPreferences);
                    break;
                case MessageCode.TURN_REIN_OFF:
                    ProfileSingleton.GetCurrent().UserPreferences.toggleRein = false; //Update profile key
                    ProfileSingleton.SetConfiguration(ProfileSingleton.GetCurrent().UserPreferences);
                    break;
            }
        }

        private void btnToggleStatusHandler(object sender, EventArgs e) { this.toggleStatus(); }

        private void onStatusToggleKeyChange(object sender, EventArgs e)
        {
            //Get last key from profile before update it in json
            Keys currentToggleKey = (Keys)Enum.Parse(typeof(Keys), this.txtStatusToggleKey.Text);
            KeyboardHook.RemoveDown(lastKey);
            KeyboardHook.AddKeyDown(currentToggleKey, new KeyboardHook.KeyPressed(this.toggleStatus));
            ProfileSingleton.GetCurrent().UserPreferences.toggleStateKey = currentToggleKey.ToString(); //Update profile key
            ProfileSingleton.SetConfiguration(ProfileSingleton.GetCurrent().UserPreferences);

            lastKey = currentToggleKey; //Refresh lastKey to update 
        }

        private bool toggleStatus()
        {
            bool isOn = this.btnStatusToggle.Text == "ON";
            if (isOn)
            {
                this.btnStatusToggle.BackColor = Color.Red;
                this.btnStatusToggle.Text = "OFF";
                this.notifyIconTray.Icon = Resources._4RTools.ETCResource.logo_4rtools_off;
                this.subject.Notify(new Utils.Message(MessageCode.TURN_OFF, null));
                this.lblStatusToggle.Text = "Press the key to start!";
                this.lblStatusToggle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(155)))), ((int)(((byte)(164)))));
                new SoundPlayer(Resources._4RTools.ETCResource.Speech_Off).Play();
            }
            else
            {
                Client client = ClientSingleton.GetClient();
                if (client != null)
                {
                    this.btnStatusToggle.BackColor = Color.Green;
                    this.btnStatusToggle.Text = "ON";
                    this.notifyIconTray.Icon = Resources._4RTools.ETCResource.logo_4rtools_on;
                    this.subject.Notify(new Utils.Message(MessageCode.TURN_ON, null));
                    this.lblStatusToggle.Text = "Press the key to stop!";
                    this.lblStatusToggle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(155)))), ((int)(((byte)(164)))));
                    new SoundPlayer(Resources._4RTools.ETCResource.Speech_On).Play();
                }
                else
                {
                    this.lblStatusToggle.Text = "Please select a valid Ragnarok Client!";
                    this.lblStatusToggle.ForeColor = Color.Red;
                }
            }

            return true;
        }

        public bool TurnOFF()
        {
            bool isOn = this.btnStatusToggle.Text == "ON";
            if (isOn)
            {
                this.btnStatusToggle.BackColor = Color.Red;
                this.btnStatusToggle.Text = "OFF";
                this.notifyIconTray.Icon = Resources._4RTools.ETCResource.logo_4rtools_off;
                this.subject.Notify(new Utils.Message(MessageCode.TURN_OFF, null));
                this.lblStatusToggle.Text = "Press the key to start!";
                this.lblStatusToggle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(155)))), ((int)(((byte)(164)))));
                new SoundPlayer(Resources._4RTools.ETCResource.Speech_Off).Play();
            }

            bool isOnheal = this.btnStatusHealToggle.Text == "ON";
            if (isOnheal)
            {
                this.btnStatusHealToggle.BackColor = Color.Red;
                this.btnStatusHealToggle.Text = "OFF";
                this.subject.Notify(new Utils.Message(MessageCode.TURN_HEAL_OFF, null));
                this.lblStatusHealToggle.Text = "Press the key to start healing!";
                this.lblStatusHealToggle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(155)))), ((int)(((byte)(164)))));
                new SoundPlayer(Resources._4RTools.ETCResource.Healing_Off).Play();
            }
            return true;
        }


        private void btnToggleStatusHealHandler(object sender, EventArgs e) { this.toggleStatusHeal(); }

        private void onStatusHealToggleKeyChange(object sender, EventArgs e)
        {
            //Get last key from profile before update it in json
            Keys currentHealToggleKey = (Keys)Enum.Parse(typeof(Keys), this.txtStatusHealToggleKey.Text);
            KeyboardHook.RemoveUp(healLastKey);
            KeyboardHook.AddKeyUp(currentHealToggleKey, new KeyboardHook.KeyPressed(this.toggleStatusHeal));
            ProfileSingleton.GetCurrent().UserPreferences.toggleStateHealKey = currentHealToggleKey.ToString(); //Update profile key
            ProfileSingleton.SetConfiguration(ProfileSingleton.GetCurrent().UserPreferences);

            healLastKey = currentHealToggleKey; //Refresh lastKey to update 
        }

        private bool toggleStatusHeal()
        {
            bool isOn = this.btnStatusHealToggle.Text == "ON";
            if (isOn)
            {
                this.btnStatusHealToggle.BackColor = Color.Red;
                this.btnStatusHealToggle.Text = "OFF";
                this.subject.Notify(new Utils.Message(MessageCode.TURN_HEAL_OFF, null));
                this.lblStatusHealToggle.Text = "Press the key to start healing!";
                this.lblStatusHealToggle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(155)))), ((int)(((byte)(164)))));
                new SoundPlayer(Resources._4RTools.ETCResource.Healing_Off).Play();
            }
            else
            {
                Client client = ClientSingleton.GetClient();
                if (client != null)
                {
                    this.btnStatusHealToggle.BackColor = Color.Green;
                    this.btnStatusHealToggle.Text = "ON";
                    this.subject.Notify(new Utils.Message(MessageCode.TURN_HEAL_ON, null));
                    this.lblStatusHealToggle.Text = "Press the key to stop healing!";
                    this.lblStatusHealToggle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(155)))), ((int)(((byte)(164)))));
                    new SoundPlayer(Resources._4RTools.ETCResource.Healing_On).Play();
                }
                else
                {
                    this.lblStatusHealToggle.Text = "Please select a valid Ragnarok Client!";
                    this.lblStatusHealToggle.ForeColor = Color.Red;
                }
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


        private void activateOnCityButton_Click(object sender, EventArgs e) { this.toggleOnCity(); }

        private bool toggleOnCity()
        {        
            bool isOn = this.activateOnCityButton.Text == "ON";
            if (isOn)
            {
                this.activateOnCityButton.BackColor = Color.Red;
                this.activateOnCityButton.Text = "OFF";
                this.subject.Notify(new Utils.Message(MessageCode.TURN_CITY_OFF, null));
                this.activateOnCityLabel.Text = "To enable on city";
                this.activateOnCityLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(155)))), ((int)(((byte)(164)))));
            }
            else
            {
                Client client = ClientSingleton.GetClient();
                if (client != null)
                {
                    this.activateOnCityButton.BackColor = Color.Green;
                    this.activateOnCityButton.Text = "ON";
                    this.subject.Notify(new Utils.Message(MessageCode.TURN_CITY_ON, null));
                    this.activateOnCityLabel.Text = "To disable on city";
                    this.activateOnCityLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(155)))), ((int)(((byte)(164)))));
                }
                else
                {
                    this.activateOnCityLabel.Text = "Please select a valid Ragnarok Client!";
                    this.activateOnCityLabel.ForeColor = Color.Red;
                }
            }

            return true;
        }

        private void onCityToggleKeyChange(object sender, EventArgs e)
        {
            //Get last key from profile before update it in json
            Keys currentCityToggleKey = (Keys)Enum.Parse(typeof(Keys), this.txtCityToggleKey.Text);
            KeyboardHook.RemoveUp(cityLastKey);
            KeyboardHook.AddKeyUp(currentCityToggleKey, new KeyboardHook.KeyPressed(this.toggleOnCity));
            ProfileSingleton.GetCurrent().UserPreferences.toggleCityKey = currentCityToggleKey.ToString(); //Update profile key
            ProfileSingleton.SetConfiguration(ProfileSingleton.GetCurrent().UserPreferences);

            cityLastKey = currentCityToggleKey; //Refresh lastKey to update 
        }


        private void activateOnRein_Click(object sender, EventArgs e) { this.toggleOnRein(); }

        private bool toggleOnRein()
        {
            bool isOn = this.activateOnReinButton.Text == "ON";
            if (isOn)
            {
                this.activateOnReinButton.BackColor = Color.Red;
                this.activateOnReinButton.Text = "OFF";
                this.subject.Notify(new Utils.Message(MessageCode.TURN_REIN_OFF, null));
                this.activateOnReinLabel.Text = "To enable skills on ridding";
                this.activateOnReinLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(155)))), ((int)(((byte)(164)))));
            }
            else
            {
                Client client = ClientSingleton.GetClient();
                if (client != null)
                {
                    this.activateOnReinButton.BackColor = Color.Green;
                    this.activateOnReinButton.Text = "ON";
                    this.subject.Notify(new Utils.Message(MessageCode.TURN_REIN_ON, null));
                    this.activateOnReinLabel.Text = "To disable skills on ridding";
                    this.activateOnReinLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(155)))), ((int)(((byte)(164)))));
                }
                else
                {
                    this.activateOnReinLabel.Text = "Please select a valid Ragnarok Client!";
                    this.activateOnReinLabel.ForeColor = Color.Red;
                }
            }

            return true;
        }

        private void onReinToggleKeyChange(object sender, EventArgs e)
        {
            //Get last key from profile before update it in json
            Keys currentRidingToggleKey = (Keys)Enum.Parse(typeof(Keys), this.txtReinToggleKey.Text);
            KeyboardHook.RemoveUp(ridingLastKey);
            KeyboardHook.AddKeyUp(currentRidingToggleKey, new KeyboardHook.KeyPressed(this.toggleOnRein));
            ProfileSingleton.GetCurrent().UserPreferences.toggleReinKey = currentRidingToggleKey.ToString(); //Update profile key
            ProfileSingleton.SetConfiguration(ProfileSingleton.GetCurrent().UserPreferences);

            ridingLastKey = currentRidingToggleKey; //Refresh lastKey to update 
        }


    }
}
