using System;
using System.Drawing;
using _4RTools.Utils;

namespace _4RTools.Model
{
    internal class Buff
    {
        private String _name;
        private Classe _class;
        private EffectStatusIDs _effectStatusID;
        private Bitmap _icon;

        public Buff(string name, Classe clazz, EffectStatusIDs effectStatus, Bitmap icon)
        {
            this._name = name;
            this._class = clazz;
            this._effectStatusID = effectStatus;
            this._icon = icon;
        }

    }
}
