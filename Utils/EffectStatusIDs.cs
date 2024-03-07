using System;

namespace _4RTools.Utils
{
    [Flags]
    public enum EffectStatusIDs : uint
    {
        //Status
        QUAGMIRE = 8,
        HALLUCINATIONWALK = 334,
        HALLUCINATION = 34,
        PROVOKE = 2015,
        PROPERTYUNDEAD = 97,

        MISTY_FROST = 1141,
        OVERHEAT = 373,

        ENDURE = 1,
        PAINKILLER = 577,

        SPEARQUICKEN = 68,

        MONSTER_TRANSFORM = 621,
        PRESTIGE = 402,
        INSPIRATION = 407,
        SHIELDSPELL = 1316,

        SPIRIT = 1401,
        WARM = 165,
        SUN_COMFORT = 169,
        MOON_COMFORT = 170,
        STAR_COMFORT = 171,
        FEARBREEZE = 352,
        SOULLINK = 149,
        GNCARTBOOST = 461,
        CONCENTRATION = 3,
        TRUESIGHT = 115,
        GLORIA = 21,
        MAGNIFICAT = 20,
        ANGELUS = 9,
        LAUDA_AGNUS = 331,
        LAUDA_RAMUS = 332,
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
        ONEHANDQUICKEN = 161,
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
        PROTECTARMOR = 56,
        CASH_PLUSEXP = 1400,
        CASH_PLUSECLASSXP = 312,
        CASH_RECEIVEITEM = 252,
        ACCELERATION = 361,
        LIMIT_POWER_BOOSTER = 867,
        GATLINGFEVER = 204,
        ASSUMPTIO = 110,
        FORCEOFVANGUARD = 391,
        UNLIMIT = 722,
        POEMBRAGI = 72,
        APPLEIDUN = 73,
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
        IMPOSITIO = 15,
        E_CHAIN = 753,
        AUTOSHADOWSPELL = 393,
        CLOAKING = 5,
        HIDING = 4,
        MAGNUM = 131,
        FIGHTINGSPIRIT = 322, // aura de combate
        BASILICA = 1122,
        EDEN = 9999,

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
        MANA_PLUS = 487,

        //POTIONS
        CONCENTRATION_POTION = 37,
        AWAKENING_POTION = 38,
        BERSERK_POTION = 39,
        ASPDPOTIONINFINITY = 40,

        //FOODS
        FOOD_STR = 241,
        FOOD_AGI = 242,
        FOOD_VIT = 243,
        FOOD_DEX = 244,
        FOOD_INT = 245,
        FOOD_LUK = 246,
        FOOD_VIT_CASH = 273,
        ACARAJE = 414,
        STR_Biscuit_Stick = 2035,
        VIT_Biscuit_Stick = 2036,
        AGI_Biscuit_Stick = 2037,
        INT_Biscuit_Stick = 2038,
        DEX_Biscuit_Stick = 2039,
        LUK_Biscuit_Stick = 2040,


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
        BUNSINJYUTSU = 207,
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

        // DEBUFFS
        // validados
        CRITICALWOUND = 286,
        FREEZING = 351,
        CURSE = 884,
        BLEEDING = 124,
        SILENCE = 885,
        DECREASE_AGI = 13,
        CONFUSION = 886,
        STUN = 877,
        DEEP_SLEEP = 435,
        POISON = 883,

        // não validados
        FEAR = 891,
        BLIND = 887,

        // pergaminhos cheffenia

        GHOSTRING = 302,
        ANGELING = 302,
        TAO_GUNKA = 368,
        SR_ORCS = 371,
        ORC_HEROI = 370,
        ABELHA = 369,

        DANCE_WITH_WUG = 441,
        SIT = 622,

    }
}
