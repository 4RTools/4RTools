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
            this.cbStatusEffectKey.DataSource = new BindingSource(KeyMap.getDict(), null);
            this.cbStatusEffectKey.SelectedValue = Key.None;
        }

        public void Update(ISubject subject)
        {

            switch ((subject as Subject).Message.code)
            {
                case MessageCode.PROFILE_CHANGED:
                    this.autoEffectStatus = ProfileSingleton.GetCurrent().StatusAutoBuff;
                    if (this.autoEffectStatus.buffMapping.Count > 0){
                        //For Status, the key is the same for each status, so don't matter which status i'm based to update combo box value.
                        this.cbStatusEffectKey.SelectedValue = autoEffectStatus.buffMapping[EffectStatusIDs.SILENCE];
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

        private void statusEffectKeyIndexChanged(object sender, EventArgs e)
        {
            Key k = (Key)this.cbStatusEffectKey.SelectedValue;
            this.autoEffectStatus.ClearKeyMapping();

            if(k != Key.None)
            {
                this.autoEffectStatus.AddKeyToBuff(EffectStatusIDs.POISON, k);
                this.autoEffectStatus.AddKeyToBuff(EffectStatusIDs.SILENCE, k);
                this.autoEffectStatus.AddKeyToBuff(EffectStatusIDs.BLIND, k);
                this.autoEffectStatus.AddKeyToBuff(EffectStatusIDs.CONFUSION, k);
                this.autoEffectStatus.AddKeyToBuff(EffectStatusIDs.HALLUCINATIONWALK, k);
                this.autoEffectStatus.AddKeyToBuff(EffectStatusIDs.CURSE, k);
            }
            ProfileSingleton.SetConfiguration(this.autoEffectStatus);
        }
    }
}
