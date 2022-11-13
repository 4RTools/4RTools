using System;
using System.Windows.Forms;
using _4RTools.Utils;
using _4RTools.Model;
using System.Windows.Input;
using System.Collections.Generic;
using System.Drawing;

namespace _4RTools.Forms
{
    public partial class SkillAutoBuffForm : Form, IObserver
    {

        private List<BuffContainer> skillContainers =  new List<BuffContainer>();

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

            new BuffRenderer(skillContainers, toolTip1).doRender();
            subject.Attach(this);

        }

        public void Update(ISubject subject)
        {
            switch ((subject as Subject).Message.code)
            {
                case MessageCode.PROFILE_CHANGED:
                    Dictionary<EffectStatusIDs, Key> buffMappingClone = new Dictionary<EffectStatusIDs, Key>(ProfileSingleton.GetCurrent().Autobuff.buffMapping);
                    this.updateInputValues(buffMappingClone);
                    break;
            }
        }

        private void updateInputValues(Dictionary<EffectStatusIDs, Key> autobuffDict)
        {
            FormUtils.ResetForm(this);
            foreach (EffectStatusIDs effect in autobuffDict.Keys)
            {
                Control[] c = this.Controls.Find("in" + (int)effect, true);
                if (c.Length > 0)
                {
                    TextBox textBox = (TextBox)c[0];
                    textBox.Text = autobuffDict[effect].ToString();
                }
            }
        }
    }
}
