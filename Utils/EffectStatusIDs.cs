using System;

namespace _4RTools.Utils
{
    [Flags]
    public enum EffectStatusIDs : uint
    {
        //Status
        POISON = 883,
        SILENCE = 885,
        BLIND = 887,
        CONFUSION = 886,
        CURSE = 884,
        QUAGMIRE = 8,
        HALLUCINATIONWALK = 334,
        HALLUCINATION = 34,
        PROVOKE = 0,
        PROPERTYUNDEAD = 97,
        BLOODING = 124,
        MISTY_FROST = 1141,
        CRITICALWOUND = 286,
        OVERHEAT = 373,

        ENDURE = 1,
        PAINKILLER = 1,

        SPEARQUICKEN = 68,

        MONSTER_TRANSFORM = 621,
        PRESTIGE = 402,
        INSPIRATION = 407,
        SHIELDSPELL = 1316,

        SOULLINK = 149,
        GNCARTBOOST = 461,
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
        COMBAT_PILL = 662,
        ENCHANT_BLADE = 316,
        RWC_2011_SCROLL = 664,
        INFINITY_DRINK = 1065,
        HP_INCREASE_POTION_LARGE = 480,
        SP_INCREASE_POTION_LARGE = 481,
        ENRICH_CELERMINE_JUICE = 484,
        RED_HERB_ACTIVATOR = 1170,
        BLUE_HERB_ACTIVATOR = 1171,
        REF_T_POTION = 1169,
        OVERLAPEXPUP = 618,
	PROTECTWEAPON = 54,
	PROTECTSHIELD = 55,
	PROTECTARMOR = 56,
	PROTECTHELM = 57,
        CASH_PLUSEXP = 250,
        CASH_RECEIVEITEM = 252,
        ACCELERATION = 361,
        LIMIT_POWER_BOOSTER = 867,
        GATLINGFEVER = 204,
        ASSUMPTIO = 110,
        FORCEOFVANGUARD = 391,
        UNLIMIT = 722,
        POEMBRAGI = 72,
        RUSH_WINDMILL = 442,
        MOONLIT_SERENADE = 447,
        RAISINGDRAGON = 410,
        FIRM_FAITH = 1162,
        POWERFUL_FAITH = 1160,
        GENTLETOUCH_REVITALIZE = 427,
        GENTLETOUCH_CHANGE = 426,
        GN_CARTBOOST = 461,
        WEAPONBLOCKING = 337,
        FRIGG_SONG = 715,
        RESEARCHREPORT = 1248,
        MADNESSCANCEL = 203,
        ADJUSTMENT = 209,
        ACCURACY = 210,
        FURY = 86,

        //ELEMENTAL CONVERTERS
        PROPERTYFIRE = 90,
        PROPERTYWATER = 91,
        PROPERTYWIND = 92,
        PROPERTYGROUND = 93,
        PROPERTYDARK = 146,
        PROPERTYTELEKINESIS = 148,
        WEAPONPROPERTY = 64,
        ASPERSIO = 17,

        FULL_SWINGK = 486,
        MANA_PLUS= 487,

        //POTIONS
        CONCENTRATION_POTION = 37,
        AWAKENING_POTION = 38,
        BERSERK_POTION = 39,

        //FOODS
        FOOD_STR = 241,
        FOOD_AGI = 242,
        FOOD_VIT = 243,
        FOOD_DEX = 244,
        FOOD_INT = 245,
        FOOD_LUK = 246,
        FOOD_VIT_CASH = 273,

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

        ENERGY_DRINK_RESERCH = 481,
        RECOGNIZEDSPELL = 355,
        DODGE_ON = 143,
        IZAYOI = 652,
        TARGET_BLOOD = 301,

        //Scrolls
        INC_AGI = 12,
        BLESSING = 10,

        //3RD foods
        STR_3RD_FOOD = 491,
        INT_3RD_FOOD = 492,
        VIT_3RD_FOOD = 493,
        DEX_3RD_FOOD = 494,
        AGI_3RD_FOOD = 495,
        LUK_3RD_FOOD = 496,

        BASICHIT = 248,

        //Rune Knight Runes
        OTHILA = 322,
        HAGALAZ = 320,
        THURISAZ = 319,
        LUX_AMINA = 1154,

        TELEKINESIS_INTENSE = 717,
        MYST_AMPLIFY = 113,
    }
}
