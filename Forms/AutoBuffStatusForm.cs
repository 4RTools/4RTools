using System;
using System.Windows.Forms;
using System.Windows.Input;
using System.Collections.Generic;
using _4RTools.Utils;
using _4RTools.Model;

namespace _4RTools.Forms
{
    public partial class AutoBuffStatusForm : Form, IObserver
    {
        private List<BuffContainer> debuffContainers = new List<BuffContainer>();

        public AutoBuffStatusForm(Subject subject)
        {
            InitializeComponent();
            debuffContainers.Add(new BuffContainer(this.DebuffsGP, Buff.GetDebuffs()));

            new DebuffRenderer(debuffContainers, toolTip1).doRender();

            subject.Attach(this);
        }

        public void Update(ISubject subject)
        {
            switch ((subject as Subject).Message.code)
            {
                case MessageCode.PROFILE_CHANGED:
                    DebuffRenderer.doUpdate(new Dictionary<EffectStatusIDs, Key>(ProfileSingleton.GetCurrent().StatusRecovery.buffMapping), this);
                    break;
                case MessageCode.TURN_OFF:
                    ProfileSingleton.GetCurrent().StatusRecovery.Stop();
                    break;
                case MessageCode.TURN_ON:
                    ProfileSingleton.GetCurrent().StatusRecovery.Start();
                    break;
            }
        }
    }
}
