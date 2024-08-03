using System;
using System.Collections.Generic;
using System.Drawing;
using _4RTools.Utils;

namespace _4RTools.Model
{
    internal class Status
    {
        public String name { get; set; }
        public EffectStatusIDs effectStatusID { get; set; }
        public Bitmap icon { get; set; }

        public Status(string name, EffectStatusIDs effectStatus, Bitmap icon)
        {
            this.name = name;
            this.effectStatusID = effectStatus;
            this.icon = icon;
        }

        //--------------------- DEBUFFS ------------------------------
        public static List<Status> GetDebuffs()
        {
            List<Status> skills = new List<Status>
            {
                new Status("Critical Wounds", EffectStatusIDs.CRITICALWOUND, Resources._4RTools.Icons.critical_wound),
                new Status("FREEZING", EffectStatusIDs.EFST_FREEZING, Resources._4RTools.Icons.freezing),
                new Status("Curse", EffectStatusIDs.CURSE, Resources._4RTools.Icons.curse),
                new Status("Bleeding", EffectStatusIDs.EFST_BLEEDING, Resources._4RTools.Icons.bleeding),
                new Status("Silence", EffectStatusIDs.SILENCE, Resources._4RTools.Icons.silence),
                new Status("Decrease Agi", EffectStatusIDs.EFST_DECREASE_AGI, Resources._4RTools.Icons.decrease_agi),
                new Status("Confusion / chaos", EffectStatusIDs.CONFUSION, Resources._4RTools.Icons.chaos),
                new Status("STUN", EffectStatusIDs.EFST_STUN, Resources._4RTools.Icons.stun),
                new Status("Deep Sleep", EffectStatusIDs.EFST_DEEP_SLEEP, Resources._4RTools.Icons.deep_sleep),
                new Status("Posion", EffectStatusIDs.POISON, Resources._4RTools.Icons.poison_status),
                new Status("Lucky Water", EffectStatusIDs.EFST_HANDICAPSTATE_MISFORTUNE, Resources._4RTools.Icons.water_of_lucky),
            };

            return skills;
        }
    }
}