﻿using System.Windows.Forms;
using System.Windows.Input;
using System.Collections.Generic;
using _4RTools.Utils;
using _4RTools.Model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _4RTools.Forms
{
    public partial class StuffAutoBuffForm : Form, IObserver
    {
        private List<BuffContainer> stuffContainers = new List<BuffContainer>();

        public StuffAutoBuffForm(Subject subject)
        {
            InitializeComponent();
            stuffContainers.Add(new BuffContainer(this.PotionsGP, Buff.GetPotionsBuffs()));
            stuffContainers.Add(new BuffContainer(this.ElementalsGP, Buff.GetElementalsBuffs()));
            stuffContainers.Add(new BuffContainer(this.BoxesGP, Buff.GetBoxesBuffs()));
            stuffContainers.Add(new BuffContainer(this.FoodsGP, Buff.GetFoodBuffs()));
            stuffContainers.Add(new BuffContainer(this.ScrollBuffsGP, Buff.GetScrollBuffs()));
            stuffContainers.Add(new BuffContainer(this.EtcGP, Buff.GetETCBuffs()));
            stuffContainers.Add(new BuffContainer(this.CandiesGP, Buff.GetCandiesBuffs()));
            stuffContainers.Add(new BuffContainer(this.ExpGP, Buff.GetEXPBuffs()));

            new BuffRenderer("Autobuff", stuffContainers, toolTip1).doRender();

            subject.Attach(this);
        }

        public void Update(ISubject subject)
        {
            switch ((subject as Subject).Message.code)
            {
                case MessageCode.PROFILE_CHANGED:
                    BuffRenderer.doUpdate(new Dictionary<EffectStatusIDs, Key>(ProfileSingleton.GetCurrent().Autobuff.buffMapping), this);
                    break;
                case MessageCode.TURN_OFF:
                    ProfileSingleton.GetCurrent().Autobuff.Stop();
                    break;
                case MessageCode.TURN_ON:
                    ProfileSingleton.GetCurrent().Autobuff.Start();
                    break;
            }
        }
    }
}