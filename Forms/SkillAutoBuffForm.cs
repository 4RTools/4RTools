using System;
using System.Windows.Forms;
using _4RTools.Utils;
using _4RTools.Model;
using System.Windows.Input;
using System.Collections.Generic;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _4RTools.Forms
{
    public partial class SkillAutoBuffForm : Form, IObserver
    {

        private List<BuffContainer> skillContainers = new List<BuffContainer>();

        public SkillAutoBuffForm(Subject subject)
        {
            this.KeyPreview = true;
            InitializeComponent();

            skillContainers.Add(new BuffContainer(this.ArcherSkillsGP, Buff.GetArcherSkills()));
            skillContainers.Add(new BuffContainer(this.SwordmanSkillGP, Buff.GetSwordmanSkill()));
            skillContainers.Add(new BuffContainer(this.MageSkillGP, Buff.GetMageSkills()));
            skillContainers.Add(new BuffContainer(this.MerchantSkillsGP, Buff.GetMerchantSkills()));
            skillContainers.Add(new BuffContainer(this.ThiefSkillsGP, Buff.GetThiefSkills()));
            skillContainers.Add(new BuffContainer(this.AcolyteSkillsGP, Buff.GetAcolyteSkills()));
            skillContainers.Add(new BuffContainer(this.TKSkillGroupBox, Buff.GetTaekwonSkills()));
            skillContainers.Add(new BuffContainer(this.NinjaSkillsGP, Buff.GetNinjaSkills()));
            skillContainers.Add(new BuffContainer(this.GunsSkillsGP, Buff.GetGunsSkills()));
            skillContainers.Add(new BuffContainer(this.summonerSkillsGP, Buff.GeSummonerSkills()));
            skillContainers.Add(new BuffContainer(this.SoulAsceticSkillsGP, Buff.GetSoulAsceticSkills()));
            skillContainers.Add(new BuffContainer(this.NightWatchSkillsGP, Buff.GetNightWatchSkills()));
            skillContainers.Add(new BuffContainer(this.HyperNoviceSkillsGP, Buff.GetHyperNoviceSkills()));
            skillContainers.Add(new BuffContainer(this.HomunculusSkillsGP, Buff.GetHomunculusBuffs()));

            new BuffRenderer("Autobuff", skillContainers, toolTip1).doRender();
            subject.Attach(this);
        }

        public void Update(ISubject subject)
        {
            switch ((subject as Subject).Message.code)
            {
                case MessageCode.PROFILE_CHANGED:
                    BuffRenderer.doUpdate(new Dictionary<EffectStatusIDs, Key>(ProfileSingleton.GetCurrent().Autobuff.buffMapping), this);
                    break;
            }
        }
    }
}