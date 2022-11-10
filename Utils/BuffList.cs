using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _4RTools.Model;

namespace _4RTools.Utils
{
    internal class BuffList
    {
        private List<Buff> buffs = new List<Buff>();

        public List<Buff> GetBuffList()
        {
            buffs.Add(new Buff("Concentração", Classe.ARCHER, EffectStatusIDs.CONCENTRATION, Resources._4RTools.Icons.abrasive));

            return buffs;
        }
    }
}
