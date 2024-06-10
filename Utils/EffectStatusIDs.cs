using System;
using System.ComponentModel;

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
        [Description("Vigor")]
        ENDURE = 1,
        PAINKILLER = 577,
        [Description("Rapidez com Lança")]
        SPEARQUICKEN = 68,

        MONSTER_TRANSFORM = 621,
        [Description("Prestígio Divino")]
        PRESTIGE = 402,
        [Description("Consagração")]
        INSPIRATION = 407,
        [Description("Aegis Domini")]
        SHIELDSPELL = 1316,

        [Description("Milagre Solar, Lunar e Estelar")]
        SPIRIT = 1401,
        [Description("Calor Solar, Lunar, Estelar")]
        WARM = 165,
        [Description("Proteção Solar")]
        SUN_COMFORT = 169,
        [Description("Proteção Lunar")]
        MOON_COMFORT = 170,
        [Description("Proteção Estelar")]
        STAR_COMFORT = 171,
        [Description("Disparo Selvagem")]
        FEARBREEZE = 352,
        SOULLINK = 149,
        [Description("Concentração")]
        CONCENTRATION = 3,
        [Description("Visão Real")]
        TRUESIGHT = 115,
        [Description("Glória")]
        GLORIA = 21,
        [Description("Magnificat")]
        MAGNIFICAT = 20,
        [Description("Angelus")]
        ANGELUS = 9,
        [Description("Lauda Agnus")]
        LAUDA_AGNUS = 331,
        [Description("Lauda Ramus")]
        LAUDA_RAMUS = 332,
        [Description("Caminho do vento")]
        WINDWALK = 116,
        [Description("Força Violenta")]
        OVERTHRUST = 25,
        [Description("Força Violentíssima")]
        OVERTHRUSTMAX = 188,
        [Description("Manejo Perfeito")]
        WEAPONPERFECT = 24,
        [Description("Amplificar Poder")]
        MAXIMIZE = 26,
        [Description("Grito de Guerra")]
        CRAZY_UPROAR = 30,
        [Description("Impulso no Carrinho")]
        CARTBOOST = 118,
        [Description("Golpe Estilhaçante")]
        MELTDOWN = 117,
        [Description("Adrenalina Pura")]
        ADRENALINE = 23,
        [Description("Adrenalina Concentrada")]
        ADRENALINE2 = 147,
        [Description("Proteção Arcana")]
        ENERGYCOAT = 31,
        [Description("Explosão Protetora")]
        SIGHTBLASTER = 198,
        [Description("Desejo Arcano")]
        AUTOSPELL = 65,
        [Description("Lanças Duplas")]
        DOUBLECASTING = 186,
        [Description("Presciência")]
        MEMORIZE = 127,
        [Description("Preservar")]
        PRESERVE = 181,
        [Description("Instinto de Defesa")]
        SWORDREJECT = 120,
        [Description("Encantar com Veneno Mortal")]
        EDP = 114,
        [Description("Refletir Veneno")]
        POISONREACT = 7,
        [Description("Bloqueio")]
        AUTOGUARD = 58,
        [Description("Escudo Refletor")]
        REFLECTSHIELD = 59,
        [Description("Aura Sagrada")]
        DEFENDER = 62,
        [Description("Submissão")]
        CR_SHRINK = 197,
        ONEHANDQUICKEN = 161,
        [Description("Rapidez com Duas Mãos")]
        TWOHANDQUICKEN = 2,
        [Description("Lâmina de Aura")]
        AURABLADE = 103,
        [Description("Dedicação")]
        LKCONCENTRATION = 105,
        [Description("Aparar Golpe")]
        PARRYING = 104,
        [Description("Frenesi")]
        BERSERK = 107,
        [Description("Instinto de Sobrevivência")]
        AUTOBERSERK = 132,
        [Description("Aura Ninja")]
        AURA_NINJA = 208,
        [Description("Troca de Pele")]
        PEEL_CHANGE = 206,
        COMBAT_PILL = 662,
        [Description("Encantar Lâmina")]
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
        [Description("Aceleração")]
        ACCELERATION = 361,
        LIMIT_POWER_BOOSTER = 867,
        [Description("Ataque Gatling")]
        GATLINGFEVER = 204,
        ASSUMPTIO = 110,
        [Description("Proteção da Vanguarda")]
        FORCEOFVANGUARD = 391,
        [Description("Ilimitar")]
        UNLIMIT = 722,
        [Description("Poema de Bragi")]
        POEMBRAGI = 72,
        APPLEIDUN = 73,
        [Description("Sinfonia dos Ventos")]
        RUSH_WINDMILL = 442,
        [Description("Serenata ao Luar")]
        MOONLIT_SERENADE = 447,
        [Description("Dragão Ascendente")]
        RAISINGDRAGON = 410,
        [Description("Firm Faith")]
        FIRM_FAITH = 1162,
        [Description("Powerful Faith")]
        POWERFUL_FAITH = 1160,
        [Description("Chakra do Vigor")]
        GENTLETOUCH_REVITALIZE = 427,
        [Description("Chakra da Fúria")]
        GENTLETOUCH_CHANGE = 426,
        [Description("Propulsão do Carrinho")]
        GN_CARTBOOST = 461,
        [Description("Reflexo de Combate")]
        WEAPONBLOCKING = 337,
        [Description("Canção de Frigga")]
        FRIGG_SONG = 715,
        [Description("Research Report")]
        RESEARCHREPORT = 1248,
        [Description("Resistência Final")]
        MADNESSCANCEL = 203,
        [Description("Pânico do Justiceiro")]
        ADJUSTMENT = 209,
        [Description("Aumentar Precisão")]
        ACCURACY = 210,
        [Description("Fúria Interior")]
        FURY = 86,
        [Description("Impositio Manus")]
        IMPOSITIO = 15,
        [Description("Reação Ilimitada")]
        E_CHAIN = 753,
        AUTOSHADOWSPELL = 393,
        [Description("Furtividade")]
        CLOAKING = 5,
        [Description("Esconderijo")]
        HIDING = 4,
        MAGNUM = 131,
        FIGHTINGSPIRIT = 322,
        [Description("Basílica")]
        BASILICA = 1122,
        EDEN = 9999,

        //ELEMENTAL CONVERTERS
        [Description("Brisa Leve (Fogo)")]
        PROPERTYFIRE = 90,
        [Description("Brisa Leve (Água)")]
        PROPERTYWATER = 91,
        [Description("Brisa Leve (Vento)")]
        PROPERTYWIND = 92,
        [Description("Brisa Leve (Terra)")]
        PROPERTYGROUND = 93,
        [Description("Brisa Leve (Sombrio)")]
        PROPERTYDARK = 146,
        [Description("Brisa Leve (Fantasma)")]
        PROPERTYTELEKINESIS = 148,
        WEAPONPROPERTY = 64,
        [Description("Brisa Leve (Sagrado)")]
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

        CRITICALPERCENT = 295,


        //Boxes
        DROWSINESS_BOX = 151,
        RESENTMENT_BOX = 150,
        SUNLIGHT_BOX = 184,

        //Elemental Potions
        RESIST_PROPERTY_WATER = 908,
        RESIST_PROPERTY_GROUND = 909,
        RESIST_PROPERTY_FIRE = 910,
        RESIST_PROPERTY_WIND = 911,

        BOX_OF_THUNDER = 289,
        SPEED_POT = 41,

        ENERGY_DRINK_RESERCH = 481,
        [Description("Maestria Arcana")]
        RECOGNIZEDSPELL = 355,
        [Description("Cambalhota")]
        DODGE_ON = 143,
        [Description("Inspiração")]
        IZAYOI = 652,
        [Description("Imagem Falsa")]
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

        //Rune Knight Runes
        //OTHILA = 322,
        HAGALAZ = 320,
        THURISAZ = 319,
        LUX_AMINA = 1154,

        [Description("Telecinesia")]
        TELEKINESIS_INTENSE = 717,
        [Description("Amplificação Mística")]
        MYST_AMPLIFY = 113,

        // DEBUFFS
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

        SLOW_CAST = 282,
        MANDRAGORA = 470,
        BURNING = 881,

        FEAR = 891,
        BLIND = 887,

        // pergaminhos cheffenia

        GHOSTRING = 302,
        ANGELING = 302,
        TAO_GUNKA = 368,
        SR_ORCS = 371,
        ORC_HEROI = 370,
        ABELHA = 369,

        [Description("Dança com Lobos")]
        DANCE_WITH_WUG = 441,
        SIT = 622,

        SPELLBREAKER = 300,
        HALOHALO = 2011,
        FLEE_SCROLL = 247,
        ACCURACY_SCROLL = 248,
        GLASS_OF_ILLUSION = 296,
        MENTAL_POTION = 298,
        VITATA_POTION = 483,
        RIDDING = 613,

    }

}

