using System;
using System.Windows.Forms;
using _4RTools.Utils;
using _4RTools.Model;
using System.Windows.Input;

namespace _4RTools.Forms
{
    public partial class StatusEffectForm : Form, IObserver
    {

        public StatusEffectForm(Subject subject)
        {
            InitializeComponent();
            subject.Attach(this);

            this.txtStatusKey.KeyDown += new System.Windows.Forms.KeyEventHandler(FormUtils.OnKeyDown);
            this.txtStatusKey.KeyPress += new KeyPressEventHandler(FormUtils.OnKeyPress);
            this.txtStatusKey.TextChanged += new EventHandler(onStatusKeyChange);
            this.txtNewStatusKey.KeyDown += new System.Windows.Forms.KeyEventHandler(FormUtils.OnKeyDown);
            this.txtNewStatusKey.KeyPress += new KeyPressEventHandler(FormUtils.OnKeyPress);
            this.txtNewStatusKey.TextChanged += new EventHandler(on3RDStatusKeyChange);
        }

        public void Update(ISubject subject)
        {

            switch ((subject as Subject).Message.code)
            {
                case MessageCode.PROFILE_CHANGED:
                    if (ProfileSingleton.GetCurrent().StatusRecovery.buffMapping.Count > 0){
                        //For Status, the key is the same for each status, so don't matter which status i'm based to update combo box value.
                        this.txtStatusKey.Text = ProfileSingleton.GetCurrent().StatusRecovery.buffMapping[EffectStatusIDs.SILENCE].ToString();
                    }
                    break;
                case MessageCode.TURN_OFF:
                    ProfileSingleton.GetCurrent().StatusRecovery.Stop();
                    break;
                case MessageCode.TURN_ON:
                    ProfileSingleton.GetCurrent().StatusRecovery.Start();
                    break;
            }
        }

        private void onStatusKeyChange(object sender, EventArgs e)
        {
            Key k = (Key)Enum.Parse(typeof(Key), this.txtStatusKey.Text.ToString());

            ProfileSingleton.GetCurrent().StatusRecovery.AddKeyToBuff(EffectStatusIDs.POISON, k);
            ProfileSingleton.GetCurrent().StatusRecovery.AddKeyToBuff(EffectStatusIDs.SILENCE, k);
            ProfileSingleton.GetCurrent().StatusRecovery.AddKeyToBuff(EffectStatusIDs.BLIND, k);
            ProfileSingleton.GetCurrent().StatusRecovery.AddKeyToBuff(EffectStatusIDs.CONFUSION, k);
            ProfileSingleton.GetCurrent().StatusRecovery.AddKeyToBuff(EffectStatusIDs.HALLUCINATIONWALK, k);
            ProfileSingleton.GetCurrent().StatusRecovery.AddKeyToBuff(EffectStatusIDs.HALLUCINATION, k);
            ProfileSingleton.GetCurrent().StatusRecovery.AddKeyToBuff(EffectStatusIDs.CURSE, k);

            ProfileSingleton.SetConfiguration(ProfileSingleton.GetCurrent().StatusRecovery);
        }

        private void on3RDStatusKeyChange(object sender, EventArgs e)
        {
            Key k = (Key)Enum.Parse(typeof(Key), this.txtNewStatusKey.Text.ToString());

            ProfileSingleton.GetCurrent().StatusRecovery.AddKeyToBuff(EffectStatusIDs.PROPERTYUNDEAD, k);
            ProfileSingleton.GetCurrent().StatusRecovery.AddKeyToBuff(EffectStatusIDs.BLOODING, k);
            ProfileSingleton.GetCurrent().StatusRecovery.AddKeyToBuff(EffectStatusIDs.MISTY_FROST, k);
            ProfileSingleton.GetCurrent().StatusRecovery.AddKeyToBuff(EffectStatusIDs.CRITICALWOUND, k);
            ProfileSingleton.GetCurrent().StatusRecovery.AddKeyToBuff(EffectStatusIDs.OVERHEAT, k);
            ProfileSingleton.SetConfiguration(ProfileSingleton.GetCurrent().StatusRecovery);
        }
    }
}
