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

        }

        public void Update(ISubject subject)
        {

            switch ((subject as Subject).Message.code)
            {
                case MessageCode.PROFILE_CHANGED:
                    if (ProfileSingleton.GetCurrent().StatusAutoBuff.buffMapping.Count > 0){
                        //For Status, the key is the same for each status, so don't matter which status i'm based to update combo box value.
                        this.txtStatusKey.Text = ProfileSingleton.GetCurrent().StatusAutoBuff.buffMapping[EffectStatusIDs.SILENCE].ToString();
                    }
                    break;
                case MessageCode.TURN_OFF:
                    ProfileSingleton.GetCurrent().StatusAutoBuff.Stop();
                    break;
                case MessageCode.TURN_ON:
                    ProfileSingleton.GetCurrent().StatusAutoBuff.Start();
                    break;
            }
        }

        private void onStatusKeyChange(object sender, EventArgs e)
        {
            Key k = (Key)Enum.Parse(typeof(Key), this.txtStatusKey.Text.ToString());

            ProfileSingleton.GetCurrent().StatusAutoBuff.AddKeyToBuff(EffectStatusIDs.POISON, k);
            ProfileSingleton.GetCurrent().StatusAutoBuff.AddKeyToBuff(EffectStatusIDs.SILENCE, k);
            ProfileSingleton.GetCurrent().StatusAutoBuff.AddKeyToBuff(EffectStatusIDs.BLIND, k);
            ProfileSingleton.GetCurrent().StatusAutoBuff.AddKeyToBuff(EffectStatusIDs.CONFUSION, k);
            ProfileSingleton.GetCurrent().StatusAutoBuff.AddKeyToBuff(EffectStatusIDs.HALLUCINATIONWALK, k);
            ProfileSingleton.GetCurrent().StatusAutoBuff.AddKeyToBuff(EffectStatusIDs.HALLUCINATION, k);
            ProfileSingleton.GetCurrent().StatusAutoBuff.AddKeyToBuff(EffectStatusIDs.CURSE, k);

            ProfileSingleton.SetConfiguration(ProfileSingleton.GetCurrent().StatusAutoBuff);
        }
    }
}
