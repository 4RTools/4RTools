using System;
using System.Collections.Generic;
using System.Windows.Forms;
using _4RTools.Utils;
using _4RTools.Model;
using System.Windows.Input;

namespace _4RTools.Forms
{
    public partial class AHKForm : Form, IObserver
    {
        private AHK ahk = new AHK();
        private AutoRefreshSpammer autoRefreshSpammer = new AutoRefreshSpammer();

        public AHKForm(Subject subject)
        {
            InitializeComponent();
            InitializeCheckAsThreeState();
            subject.Attach(this);

            // Default values
            this.txtSkillTimerKey.KeyDown += new System.Windows.Forms.KeyEventHandler(FormUtils.OnKeyDown);
            this.txtSkillTimerKey.KeyPress += new KeyPressEventHandler(FormUtils.OnKeyPress);
            this.txtSkillTimerKey.TextChanged += new EventHandler(this.onSkillTimerKeyChange);
            this.txtAutoRefreshDelay.ValueChanged += new EventHandler(this.txtAutoRefreshDelayTextChanged);
        }

        public void Update(ISubject subject)
        {
            switch ((subject as Subject).Message.code)
            {
                case MessageCode.PROFILE_CHANGED:
                    FormUtils.ResetForm(this);
                    this.ahk = ProfileSingleton.GetCurrent().AHK;
                    this.autoRefreshSpammer = ProfileSingleton.GetCurrent().AutoRefreshSpammer;
                    Dictionary<string, KeyConfig> ahkClones = new Dictionary<string, KeyConfig>(this.ahk.ahkEntries);

                    foreach (KeyValuePair<string, KeyConfig> config in ahkClones)
                    {
                        ToggleCheckboxByName(config.Key, config.Value.clickActive);
                    }

                    ToggleCheckboxByName(this.mouseFlick.Name, this.ahk.mouseFlick);
                    this.txtSpammerDelay.Text = this.ahk.ahkDelay.ToString();
                    this.txtSkillTimerKey.Text = this.autoRefreshSpammer.refreshKey.ToString();
                    this.txtAutoRefreshDelay.Text = this.autoRefreshSpammer.refreshDelay.ToString();
                    break;
                case MessageCode.TURN_ON:
                    this.ahk.Start();
                    this.autoRefreshSpammer.Start();
                    break;
                case MessageCode.TURN_OFF:
                    this.ahk.Stop();
                    this.autoRefreshSpammer.Stop();
                    break;
            }
        }

        private void onCheckChange(object sender, EventArgs e)
        {
            CheckBox checkbox = (CheckBox)sender;

            if(checkbox.Text == "Mouse Flick")
            {
                this.ahk.mouseFlick = checkbox.Checked;
            }
            else
            {
                Key key = (Key)new KeyConverter().ConvertFromString(checkbox.Text);
                bool haveMouseClick = checkbox.CheckState == CheckState.Checked ? true : false;

                if (checkbox.CheckState == CheckState.Checked || checkbox.CheckState == CheckState.Indeterminate)
                    this.ahk.AddAHKEntry(checkbox.Name, new KeyConfig(key, haveMouseClick));
                else
                    this.ahk.RemoveAHKEntry(checkbox.Name);

            }

            ProfileSingleton.SetConfiguration(this.ahk);
        }

        private void txtSpammerDelay_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.ahk.ahkDelay = Int16.Parse(this.txtSpammerDelay.Text);
                ProfileSingleton.SetConfiguration(this.ahk);
            }
            catch{ }
        }


        private void ToggleCheckboxByName(string Name, bool state)
        {
            try
            {
                CheckBox checkBox = (CheckBox)this.Controls.Find(Name, true)[0];
                checkBox.CheckState = state ? CheckState.Checked : CheckState.Indeterminate;
                ProfileSingleton.SetConfiguration(this.ahk);
            }
            catch { }
        }

        private void onSkillTimerKeyChange(object sender, EventArgs e)
        {
            Key key = (Key)Enum.Parse(typeof(Key), txtSkillTimerKey.Text.ToString());
            this.autoRefreshSpammer.refreshKey = key;
            ProfileSingleton.SetConfiguration(this.autoRefreshSpammer);
        }

        private void txtAutoRefreshDelayTextChanged(object sender, EventArgs e)
        {
            try
            {
                this.autoRefreshSpammer.refreshDelay = Int16.Parse(this.txtAutoRefreshDelay.Text);
                ProfileSingleton.SetConfiguration(this.autoRefreshSpammer);
            }
            catch { }
        }

        private void InitializeCheckAsThreeState()
        {
            foreach (Control c in this.Controls)
                if (c is CheckBox)
                {
                    CheckBox check = (CheckBox)c;
                    if((check.Name.Split(new[] { "chk" }, StringSplitOptions.None).Length == 2)){
                        check.ThreeState = true;
                    };

                    if(check.Enabled)
                        check.CheckStateChanged += onCheckChange;
                }
        }

        private void noclicksample_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
