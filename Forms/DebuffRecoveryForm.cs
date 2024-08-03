using System.Windows.Forms;
using _4RTools.Utils;
using _4RTools.Model;
using System.Windows.Input;
using System.Collections.Generic;
using System;
using System.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _4RTools.Forms
{
    public partial class DebuffRecoveryForm : Form, IObserver
    {

        private List<BuffContainer> skillContainers = new List<BuffContainer>();

        public DebuffRecoveryForm(Subject subject)
        {
            this.KeyPreview = true;
            InitializeComponent();

            this.txtStatusKey.KeyDown += new System.Windows.Forms.KeyEventHandler(FormUtils.OnKeyDown);
            this.txtStatusKey.KeyPress += new KeyPressEventHandler(FormUtils.OnKeyPress);
            this.txtStatusKey.TextChanged += new EventHandler(onStatusKeyChange);
            this.txtNewStatusKey.KeyDown += new System.Windows.Forms.KeyEventHandler(FormUtils.OnKeyDown);
            this.txtNewStatusKey.KeyPress += new KeyPressEventHandler(FormUtils.OnKeyPress);
            this.txtNewStatusKey.TextChanged += new EventHandler(on3RDStatusKeyChange);

            skillContainers.Add(new BuffContainer(this.DebuffRecoveryGP, Status.GetDebuffs()));

            new BuffRenderer(ProfileSingleton.GetCurrent().DebuffsRecovery, skillContainers, toolTip1).doRender();

            subject.Attach(this);
        }

        public void Update(ISubject subject)
        {
            switch ((subject as Subject).Message.code)
            {
                case MessageCode.PROFILE_CHANGED:
                    BuffRenderer.doUpdate(new Dictionary<EffectStatusIDs, Key>(ProfileSingleton.GetCurrent().DebuffsRecovery.buffMapping), this);

                    this.txtStatusKey.Text = ProfileSingleton.GetCurrent().StatusRecovery.buffMapping.Keys.Contains(EffectStatusIDs.SILENCE) ? ProfileSingleton.GetCurrent().StatusRecovery.buffMapping[EffectStatusIDs.SILENCE].ToString() : Keys.None.ToString();
                    this.txtNewStatusKey.Text = ProfileSingleton.GetCurrent().StatusRecovery.buffMapping.Keys.Contains(EffectStatusIDs.CRITICALWOUND) ? ProfileSingleton.GetCurrent().StatusRecovery.buffMapping[EffectStatusIDs.CRITICALWOUND].ToString() : Keys.None.ToString();
                    this.autoStandCB.Checked = ProfileSingleton.GetCurrent().StatusRecovery.autoStand;

                    break;
                case MessageCode.TURN_OFF:
                    ProfileSingleton.GetCurrent().StatusRecovery.Stop();
                    ProfileSingleton.GetCurrent().DebuffsRecovery.Stop();
                    break;
                case MessageCode.TURN_ON:
                    ProfileSingleton.GetCurrent().StatusRecovery.Start();
                    ProfileSingleton.GetCurrent().DebuffsRecovery.Start();
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

            ProfileSingleton.GetCurrent().StatusRecovery.AddKeyToBuff(EffectStatusIDs.CRITICALWOUND, k);
            ProfileSingleton.GetCurrent().StatusRecovery.AddKeyToBuff(EffectStatusIDs.PROPERTYUNDEAD, k);
            ProfileSingleton.GetCurrent().StatusRecovery.AddKeyToBuff(EffectStatusIDs.BLOODING, k);
            ProfileSingleton.GetCurrent().StatusRecovery.AddKeyToBuff(EffectStatusIDs.MISTY_FROST, k);
            ProfileSingleton.GetCurrent().StatusRecovery.AddKeyToBuff(EffectStatusIDs.OVERHEAT, k);

            ProfileSingleton.SetConfiguration(ProfileSingleton.GetCurrent().StatusRecovery);
        }

        private void autoStandCB_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chk = sender as CheckBox;
            ProfileSingleton.GetCurrent().StatusRecovery.autoStand = chk.Checked;
            ProfileSingleton.SetConfiguration(ProfileSingleton.GetCurrent().StatusRecovery);
        }
    }
}