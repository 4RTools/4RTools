using System;
using System.Windows.Forms;
using _4RTools.Utils;
using _4RTools.Model;
using System.Windows.Input;

namespace _4RTools.Forms
{
    public partial class StatusEffectForm : Form, IObserver
    {
        private AutoBuff autoEffectStatus = new AutoBuff("StatusAutoBuff");

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
                    this.autoEffectStatus = ProfileSingleton.GetCurrent().StatusAutoBuff;
                    FormUtils.ResetForm(this);
                    if (this.autoEffectStatus.buffMapping.Count > 0){
                        //For Status, the key is the same for each status, so don't matter which status i'm based to update combo box value.
                        this.txtStatusKey.Text = this.autoEffectStatus.buffMapping[EffectStatusIDs.SILENCE].ToString();
                    }
                    break;
                case MessageCode.TURN_OFF:
                    this.autoEffectStatus.Stop();
                    break;
                case MessageCode.TURN_ON:
                    this.autoEffectStatus.Start();
                    break;
            }
        }

        private void onStatusKeyChange(object sender, EventArgs e)
        {
            Key k = (Key)Enum.Parse(typeof(Key), this.txtStatusKey.Text.ToString());

            this.autoEffectStatus.AddKeyToBuff(EffectStatusIDs.POISON, k);
            this.autoEffectStatus.AddKeyToBuff(EffectStatusIDs.SILENCE, k);
            this.autoEffectStatus.AddKeyToBuff(EffectStatusIDs.BLIND, k);
            this.autoEffectStatus.AddKeyToBuff(EffectStatusIDs.CONFUSION, k);
            this.autoEffectStatus.AddKeyToBuff(EffectStatusIDs.HALLUCINATIONWALK, k);
            this.autoEffectStatus.AddKeyToBuff(EffectStatusIDs.HALLUCINATION, k);
            this.autoEffectStatus.AddKeyToBuff(EffectStatusIDs.CURSE, k);

            ProfileSingleton.SetConfiguration(this.autoEffectStatus);
        }
    }
}
