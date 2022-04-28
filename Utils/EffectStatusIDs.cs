using System;

namespace _4RTools.Utils
{
    [Flags]
    public enum EffectStatusIDs : uint
    {
        POISON = 883,
        SILENCE = 885,
        BLIND = 887,
        CONFUSION = 886,
        CURSE = 884,
        QUAGMIRE = 8,
        HALLUCINATIONWALK = 334,
        HALLUCINATION = 34, // Also known as Illusion

        //BUFFS
        PROVOKE = 0,
        ENDURE = 1,
        CONCENTRATION  = 3,
        TRUESIGHT = 115,
        GLORIA = 21,
        MAGNIFICAT = 20,
        ANGELUS = 9,
        WINDWALK = 116,
        OVERTHRUST = 25,
        OVERTHRUSTMAX = 188,
        WEAPONPERFECT = 24,
        MAXIMIZE = 26,
        CRAZY_UPROAR = 30,
        CARTBOOST = 118,
        MELTDOWN = 117,
        ADRENALINE = 23,
        ADRENALINE2 = 147,
        ENERGYCOAT = 31,
        SIGHTBLASTER = 198,
        AUTOSPELL = 65,
        DOUBLECASTING = 186,
        MEMORIZE = 127,
        PRESERVE = 181,
        SWORDREJECT = 120,
        EDP = 114,
        POISONREACT = 7,
        AUTOGUARD = 58,
        REFLECTSHIELD = 59,
        DEFENDER = 62,
        CR_SHRINK = 197,
        TWOHANDQUICKEN = 2,
        AURABLADE = 103,
        LKCONCENTRATION = 105,
        PARRYING = 104,
        BERSERK = 107,
        AUTOBERSERK = 132,
        AURA_NINJA = 208,
        PEEL_CHANGE = 206,

        //ASPD POTIONS
        CONCENTRATION_POTION = 37,
        AWAKENING_POTION = 38,
        BERSERK_POTION = 39,

        FOOD_STR = 241,
        FOOD_AGI = 242,
        FOOD_VIT = 243,
        FOOD_DEX = 244,
        FOOD_INT = 245,
        FOOD_LUK = 246,

        REGENERATION_POTION = 292,

        CRITICALPERCENT = 295, // Abrasive

        //Boxes
        DROWSINESS_BOX = 151, //SONOLENCIA
        RESENTMENT_BOX = 150, //RESSENTIMENTO
        SUNLIGHT_BOX = 184,

        //Elemental Potions
        RESIST_PROPERTY_WATER = 908,
        RESIST_PROPERTY_GROUND = 909,
        RESIST_PROPERTY_FIRE = 910,
        RESIST_PROPERTY_WIND = 911,

        BOX_OF_THUNDER = 289,
        SPEED_POT = 41,

        //Scrolls
        INC_AGI = 12,
        BLESSING = 10,
    }
}
