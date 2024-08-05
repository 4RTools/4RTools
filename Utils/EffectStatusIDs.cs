using System;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Metadata;

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
        EFST_SIT = 622,
        EFST_FREEZING = 351,
        EFST_BLEEDING = 124,
        EFST_DECREASE_AGI = 13,
        EFST_STUN = 877,
        EFST_DEEP_SLEEP = 435,
        EFST_HANDICAPSTATE_MISFORTUNE = 1213,

        ENDURE = 1,
        PAINKILLER = 1,

        SPEARQUICKEN = 68,

        MONSTER_TRANSFORM = 621,
        PRESTIGE = 402,
        INSPIRATION = 407,
        SHIELDSPELL = 1316,

        SOULLINK = 149,
        GNCARTBOOST = 461,
        CONCENTRATION = 3,
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
        HP_INCREASE_POTION_LARGE = 480,
        SP_INCREASE_POTION_LARGE = 481,
        ENRICH_CELERMINE_JUICE = 484,
        RED_HERB_ACTIVATOR = 1170,
        BLUE_HERB_ACTIVATOR = 1171,
        REF_T_POTION = 1169,
        OVERLAPEXPUP = 618,
        PROTECTARMOR = 56,
        ACCELERATION = 361,
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
        MADNESSCANCEL = 203,
        ADJUSTMENT = 209,
        ACCURACY = 210,
        FURY = 86,
        IMPOSITIO = 15,
        SERVANTWEAPON = 1172,
        REFLECTDAMAGE = 390,

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

        // ASPD POTIONS
        CONCENTRATION_POTION = 37,
        AWAKENING_POTION = 38,
        BERSERK_POTION = 39,
        ASPDPOTIONINFINITY = 40,

        // POTIONS
        EFST_LIMIT_POWER_BOOSTER = 867,
        EFST_INFINITY_DRINK = 1065,

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
        EFST_ACARAJE = 414,

        // Ragna Tales
        STR_Biscuit_Stick = 2035,
        VIT_Biscuit_Stick = 2036,
        AGI_Biscuit_Stick = 2037,
        INT_Biscuit_Stick = 2038,
        DEX_Biscuit_Stick = 2039,
        LUK_Biscuit_Stick = 2040,
        // Ragna Tales

        // FOOD Bubble Gums
        EFST_Bubble_Gum_Green = 1508,
        EFST_Bubble_Gum_Yellow = 1505,
        EFST_Bubble_Gum_Orange = 1507,
        EFST_Bubble_Gum_Red = 1506,

        // ETC
        EFST_GVG_GIANT = 686,
        EFST_GVG_GOLEM = 687,
        EFST_MAGIC_CANDY = 611,
        EFST_ATK_POPCORN = 1031,
        EFST_MATK_POPCORN = 1032,
        EFST_ARMOR_PROPERTY = 302,

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
        EFST_GHOSTRING = 302,
        EFST_ANGELING = 302,
        EFST_TAO_GUNKA = 368,
        EFST_ORC_LORD = 371,
        EFST_ORC_HERO = 370,
        EFST_MISTRESS = 369,
        EFST_KIEL_CARD = 990,
        EFST_EDEN = 9999,
        EFST_BURNT_INCENSE = 1401,
        EFST_SOULSCROLL = 514,
        EFST_RESIST_PROPERTY_UNDEAD = 916,

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

        // EXP
        CASH_PLUSEXP = 1400,
        CASH_PLUSECLASSXP = 312,
        CASH_RECEIVEITEM = 252,

        // Third Class

        // Fourth Class
        // [Arch Mage](https://irowiki.org/wiki/Arch_Mage)
        EFST_CLIMAX = 1152,

        // [Dragon Knight](https://irowiki.org/wiki/Dragon_Knight)
        EFST_VIGOR = 1178,

        // [Troubadour](https://irowiki.org/wiki/Troubadour)/[Trouvere](https://irowiki.org/wiki/Trouvere)
        EFST_MYSTIC_SYMPHONY = 1256,
        EFST_JAWAII_SERENADE = 1262,
        EFST_MUSICAL_INTERLUDE = 1261,
        EFST_PRON_MARCH = 1263,

        // [Abyss Chaser](https://irowiki.org/wiki/Abyss_Chaser)
        EFST_ABYSS_SLAYER = 1245,
        EFST_ABYSS_DAGGER = 1243,

        // [Summoner / Spirit Handler](https://irowiki.org/wiki/Summoner)
        EFST_SHRIMP = 920,
        EFST_TEMPORARY_COMMUNION = 1377,
        EFST_MARINE_FESTIVAL = 1367,
        EFST_SANDY_FESTIVAL = 1368,
        EFST_COLORS_OF_HYUN_ROK_1 = 1370,
        EFST_COLORS_OF_HYUN_ROK_2 = 1371,
        EFST_COLORS_OF_HYUN_ROK_3 = 1372,
        EFST_COLORS_OF_HYUN_ROK_4 = 1373,
        EFST_COLORS_OF_HYUN_ROK_5 = 1374,
        EFST_COLORS_OF_HYUN_ROK_6 = 1375,

        // [Shadow Cross](https://irowiki.org/wiki/Shadow_Cross)
        EFST_DANCING_KNIFE = 1193,
        EFST_SHADOW_WEAPON = 1226,
        EFST_POTENT_VENOM = 1194,
        EFST_SHADOW_EXCEED = 1192,

        // [Cardinal](https://irowiki.org/wiki/Cardinal)
        EFST_COMPETENTIA = 1201,
        EFST_OFFERTORIUM = 16,

        // [Wind Hawk](https://irowiki.org/wiki/Wind_Hawk)
        EFST_CALAMITYGALE = 1252,
        EFST_FEARBREEZE = 352,

        // [Imperial Guard](https://irowiki.org/wiki/Imperial_Guard)
        EFST_ATTACK_STANCE = 1203,
        EFST_GUARD_STANCE = 1202,
        EFST_REBOUND_S = 1217,
        EFST_GUARDIAN_S = 1204,
        EFST_HOLY_S = 1220,

        // [Biolo](https://irowiki.org/wiki/Biolo)
        EFST_RESEARCHREPORT = 1248,
        EFST_BO_HELL_DUSTY = 1249,

        // [Inquisitor](https://irowiki.org/wiki/Inquisitor)
        EFST_SINCERE_FAITH = 1161,

        // [Soul Ascetic](https://wiki.historyreborn.org/index.php/Soul_Ascetic)
        EFST_HEAVEN_AND_EARTH = 1365,

        // [Night Watch](https://wiki.ragna4th.com/Night_Watch)
        EFST_HIDDEN_CARD = 1354,
        EFST_GRENADE_FRAGMENT_1 = 1347,
        EFST_GRENADE_FRAGMENT_2 = 1348,
        EFST_GRENADE_FRAGMENT_3 = 1349,
        EFST_GRENADE_FRAGMENT_4 = 1350,
        EFST_GRENADE_FRAGMENT_5 = 1351,
        EFST_GRENADE_FRAGMENT_6 = 1352,

        // [Hyper Novice](https://www.divine-pride.net/tools/skilltree/4307)
        EFST_RULEBREAK = 1384,
        EFST_BREAKINGLIMIT = 1347,

        // Star Emperor(https://irowiki.org/wiki/Star_Emperor)
        EFST_SKY_ENCHANT = 1392,
        EFST_UNIVERSESTANCE = 1039,
    }
}