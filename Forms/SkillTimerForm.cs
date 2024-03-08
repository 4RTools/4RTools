using System;
using System.Collections.Generic;
using System.Windows.Forms;
using _4RTools.Utils;
using _4RTools.Model;
using System.Windows.Input;
namespace _4RTools.Forms
{
    public partial class SkillTimerForm : Form, IObserver
    {
        public static int TOTAL_SKILL_TIMER = 4;
        public SkillTimerForm(Subject subject)
        {
            InitializeComponent();
            subject.Attach(this);
            configureTimerLanes();
        }

        public void Update(ISubject subject)
        {
            switch ((subject as Subject).Message.code)
            {
                case MessageCode.PROFILE_CHANGED:
                    validate();
                    updateUi();
                    break;
                case MessageCode.TURN_ON:
                    ProfileSingleton.GetCurrent().AutoRefreshSpammer.Start();
                    break;
                case MessageCode.TURN_OFF:
                    ProfileSingleton.GetCurrent().AutoRefreshSpammer.Stop();
                    break;
            }
        }

        private void validate()
        {
            for (int i = 1; i <= TOTAL_SKILL_TIMER; i++)
            {
                validateAllSkillTimer(i);
            }
        }

        private void updateUi()
        {
            for (int i = 1; i <= TOTAL_SKILL_TIMER; i++)
            {
                UpdatePanelData(i);
            }
        }

        private void configureTimerLanes()
        {
            for (int i = 1; i <= TOTAL_SKILL_TIMER; i++)
            {
                initializeLane(i);
            }
        }

        private void validateAllSkillTimer(int id)
        {
            try
            {
                AutoRefreshSpammer Spammers = ProfileSingleton.GetCurrent().AutoRefreshSpammer;

                if (!Spammers.skillTimer.ContainsKey(id))
                {
                    Spammers.skillTimer.Add(id, new MacroKey(Key.None, 5));

                    Control[] c = this.Controls.Find("txtSkillTimerKey" + id, true);
                    if (c.Length > 0)
                    {
                        TextBox keyTextBox = (TextBox)c[0];
                        keyTextBox.Text = Spammers.skillTimer[id].key.ToString();
                    }

                    //Update Delay Macro Value
                    Control[] d = this.Controls.Find("txtAutoRefreshDelay" + id, true);
                    if (d.Length > 0)
                    {
                        NumericUpDown delayInput = (NumericUpDown)d[0];
                        delayInput.Value = Spammers.skillTimer[id].delay;
                    }
                }
                else
                {
                    Spammers.skillTimer.Add(id, new MacroKey(Key.None, 5));
                }

                ProfileSingleton.SetConfiguration(ProfileSingleton.GetCurrent().AutoRefreshSpammer);
            }
            catch (Exception ex) { }
        }

        private void initializeLane(int id)
        {
            try
            {

                TextBox textBox = (TextBox)this.Controls.Find("txtSkillTimerKey" + id, true)[0];
                textBox.KeyDown += new System.Windows.Forms.KeyEventHandler(FormUtils.OnKeyDown);
                textBox.KeyPress += new KeyPressEventHandler(FormUtils.OnKeyPress);
                textBox.TextChanged += new EventHandler(this.onTextChange);

                NumericUpDown txtAutoRefreshDelay = (NumericUpDown)this.Controls.Find("txtAutoRefreshDelay" + id, true)[0];
                txtAutoRefreshDelay.ValueChanged += new EventHandler(this.txtAutoRefreshDelayTextChanged);

            }
            catch { }
        }

        private void UpdatePanelData(int id)
        {
            try
            {
                AutoRefreshSpammer Spammers = ProfileSingleton.GetCurrent().AutoRefreshSpammer;

                MacroKey skillTimer = Spammers.skillTimer[id];

                //Update Trigger Macro Value
                Control[] c = this.Controls.Find("txtSkillTimerKey" + id, true);
                if (c.Length > 0)
                {
                    TextBox keyTextBox = (TextBox)c[0];
                    keyTextBox.Text = skillTimer.key.ToString();
                }

                //Update Delay Macro Value
                Control[] d = this.Controls.Find("txtAutoRefreshDelay" + id, true);
                if (d.Length > 0)
                {
                    NumericUpDown delayInput = (NumericUpDown)d[0];
                    delayInput.Value = skillTimer.delay;
                }
            }
            catch (Exception ex) { }
        }

        private void onTextChange(object sender, EventArgs e)
        {
            try
            {
                AutoRefreshSpammer Spammers = ProfileSingleton.GetCurrent().AutoRefreshSpammer;
                TextBox textBox = (TextBox)sender;
                Key key = (Key)Enum.Parse(typeof(Key), textBox.Text.ToString());

                var id = int.Parse(textBox.Name[textBox.Name.Length - 1].ToString());

                if (Spammers.skillTimer.ContainsKey(id))
                {
                    MacroKey skillTimer = Spammers.skillTimer[id];
                    skillTimer.key = key;
                }
                else
                {
                    Spammers.skillTimer.Add(id, new MacroKey(Key.None, 5));
                }

                ProfileSingleton.SetConfiguration(ProfileSingleton.GetCurrent().AutoRefreshSpammer);
            }
            catch (Exception ex) { }
        }


        private void txtAutoRefreshDelayTextChanged(object sender, EventArgs e)
        {
            try
            {
                AutoRefreshSpammer Spammers = ProfileSingleton.GetCurrent().AutoRefreshSpammer;
                NumericUpDown numericUpDown = (NumericUpDown)sender;
                int delay = (int)numericUpDown.Value;

                var id = int.Parse(numericUpDown.Name[numericUpDown.Name.Length - 1].ToString());

                if (Spammers.skillTimer.ContainsKey(id))
                {
                    var skillTimer = Spammers.skillTimer[id];
                    skillTimer.delay = delay;
                }
                else
                {
                    Spammers.skillTimer.Add(id, new MacroKey(Key.None, 5));
                }

                ProfileSingleton.SetConfiguration(ProfileSingleton.GetCurrent().AutoRefreshSpammer);
            }
            catch (Exception ex) { }
        }
        
    }
}
