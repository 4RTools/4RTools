using System;
using System.Collections.Generic;
using System.Drawing;
using _4RTools.Utils;

namespace _4RTools.Model
{
    internal class Buff
    {
        public String name { get; set; }
        public EffectStatusIDs effectStatusID { get; set; }
        public Bitmap icon { get; set; }

        public Buff(string name, EffectStatusIDs effectStatus, Bitmap icon)
        {
            this.name = name;
            this.effectStatusID = effectStatus;
            this.icon = icon;
        }

        //--------------------- SKILLS ------------------------------

        //Archer Skills
        public static List<Buff> GetArcherSkills()
        {
            List<Buff> skills = new List<Buff>
            {
                new Buff("Concentration", EffectStatusIDs.CONCENTRATION, Resources._4RTools.Icons.ac_concentration),
                new Buff("Wind Walk", EffectStatusIDs.WINDWALK, Resources._4RTools.Icons.sn_windwalk),
                new Buff("True Sight", EffectStatusIDs.TRUESIGHT, Resources._4RTools.Icons.sn_sight),
                new Buff("Ilimitar", EffectStatusIDs.UNLIMIT, Resources._4RTools.Icons.Ilimitar),
                new Buff("A Poem of Bragi", EffectStatusIDs.POEMBRAGI, Resources._4RTools.Icons.poem_of_bragi),
                new Buff("Windmill Rush", EffectStatusIDs.RUSH_WINDMILL, Resources._4RTools.Icons.windmill_rush),
                new Buff("Moonlight Serenade", EffectStatusIDs.MOONLIT_SERENADE, Resources._4RTools.Icons.moonlight_serenade),
                new Buff("Frigg's Song", EffectStatusIDs.FRIGG_SONG, Resources._4RTools.Icons.friggs_song),
                new Buff("Mystic Symphony", EffectStatusIDs.EFST_MYSTIC_SYMPHONY, Resources._4RTools.Icons.mystic_symphony),
                new Buff("Jawaii Serenade", EffectStatusIDs.EFST_JAWAII_SERENADE, Resources._4RTools.Icons.jawaii_serenade),
                new Buff("Musical Interlude", EffectStatusIDs.EFST_MUSICAL_INTERLUDE, Resources._4RTools.Icons.musical_interlude),
                new Buff("Prontera March", EffectStatusIDs.EFST_PRON_MARCH, Resources._4RTools.Icons.prontera_march),
                new Buff("Swing Dance", EffectStatusIDs.EFST_SWING, Resources._4RTools.Icons.swing_dance),
                new Buff("Calamity Gale", EffectStatusIDs.EFST_CALAMITYGALE, Resources._4RTools.Icons.calamity_gale),
                new Buff("Fear Breeze", EffectStatusIDs.EFST_FEARBREEZE, Resources._4RTools.Icons.fear_breeze),
            };

            return skills;
        }

        //Swordsman Skills
        public static List<Buff> GetSwordmanSkill()
        {
            List<Buff> skills = new List<Buff>
            {
                new Buff("Endure", EffectStatusIDs.ENDURE, Resources._4RTools.Icons.sm_endure),
                new Buff("Auto Beserk", EffectStatusIDs.AUTOBERSERK, Resources._4RTools.Icons.sm_autoberserk),
                new Buff("Guard", EffectStatusIDs.AUTOGUARD, Resources._4RTools.Icons.cr_autoguard),
                new Buff("Shield Reflection", EffectStatusIDs.REFLECTSHIELD, Resources._4RTools.Icons.cr_reflectshield),
                new Buff("Spear Quicken", EffectStatusIDs.SPEARQUICKEN, Resources._4RTools.Icons.cr_spearquicken),
                new Buff("Defending Aura", EffectStatusIDs.DEFENDER, Resources._4RTools.Icons.cr_defender),
                new Buff("Dedication", EffectStatusIDs.LKCONCENTRATION, Resources._4RTools.Icons.lk_concentration),
                new Buff("Frenzy", EffectStatusIDs.BERSERK, Resources._4RTools.Icons.lk_berserk),
                new Buff("Twohand Quicken", EffectStatusIDs.TWOHANDQUICKEN, Resources._4RTools.Icons.mer_quicken),
                new Buff("Parry", EffectStatusIDs.PARRYING, Resources._4RTools.Icons.ms_parrying),
                new Buff("Aura Blade", EffectStatusIDs.AURABLADE, Resources._4RTools.Icons.lk_aurablade),
                new Buff("Enchant Blade", EffectStatusIDs.ENCHANT_BLADE, Resources._4RTools.Icons.enchant_blade),
                new Buff("Shrink", EffectStatusIDs.CR_SHRINK, Resources._4RTools.Icons.cr_shrink),
                new Buff("Inspiration", EffectStatusIDs.INSPIRATION, Resources._4RTools.Icons.lg_inspiration),
                new Buff("Prestige", EffectStatusIDs.PRESTIGE, Resources._4RTools.Icons.lg_prestige),
                new Buff("Shield Spell", EffectStatusIDs.SHIELDSPELL, Resources._4RTools.Icons.lg_shieldspell),
                new Buff("Vanguard Force", EffectStatusIDs.FORCEOFVANGUARD, Resources._4RTools.Icons.vanguard_force),
                new Buff("Reflect Damage", EffectStatusIDs.REFLECTDAMAGE, Resources._4RTools.Icons.reflect_damage),
                new Buff("Vigor", EffectStatusIDs.EFST_VIGOR, Resources._4RTools.Icons.vigor),
                new Buff("Servant Weapon", EffectStatusIDs.SERVANTWEAPON, Resources._4RTools.Icons.servant_weapon),
                new Buff("Attack Stance", EffectStatusIDs.EFST_ATTACK_STANCE, Resources._4RTools.Icons.attack_stance),
                new Buff("Guard Stance", EffectStatusIDs.EFST_GUARD_STANCE, Resources._4RTools.Icons.guard_stance),
                new Buff("Rebound Shield", EffectStatusIDs.EFST_REBOUND_S, Resources._4RTools.Icons.rebound_shield),
                new Buff("Guardian Shield", EffectStatusIDs.EFST_GUARDIAN_S, Resources._4RTools.Icons.guardian_shield),
                new Buff("Holy Shield", EffectStatusIDs.EFST_HOLY_S, Resources._4RTools.Icons.holy_shield),
                new Buff("Exceed Break", EffectStatusIDs.EFST_EXEEDBREAK, Resources._4RTools.Icons.exceed_break),
            };

            return skills;
        }

        //Mage Skills
        public static List<Buff> GetMageSkills()
        {
            List<Buff> skills = new List<Buff>
            {
                new Buff("Energy Coat", EffectStatusIDs.ENERGYCOAT, Resources._4RTools.Icons.mg_energycoat),
                new Buff("Sight Blaster", EffectStatusIDs.SIGHTBLASTER, Resources._4RTools.Icons.wz_sightblaster),
                new Buff("Autospell", EffectStatusIDs.AUTOSPELL, Resources._4RTools.Icons.sa_autospell),
                new Buff("Double Casting", EffectStatusIDs.DOUBLECASTING, Resources._4RTools.Icons.pf_doublecasting),
                new Buff("Memorize", EffectStatusIDs.MEMORIZE, Resources._4RTools.Icons.pf_memorize),
                new Buff("Telekinesis Intense", EffectStatusIDs.TELEKINESIS_INTENSE, Resources._4RTools.Icons.telecinese),
                new Buff("Amplification", EffectStatusIDs.MYST_AMPLIFY, Resources._4RTools.Icons.amplify),
                new Buff("Recognized Spell", EffectStatusIDs.RECOGNIZEDSPELL, Resources._4RTools.Icons.recognized_spell),
                new Buff("Climax", EffectStatusIDs.EFST_CLIMAX, Resources._4RTools.Icons.climax),
            };

            return skills;
        }

        //Merchant Skills
        public static List<Buff> GetMerchantSkills()
        {
            List<Buff> skills = new List<Buff>
            {
                new Buff("Crazy Uproar", EffectStatusIDs.CRAZY_UPROAR, Resources._4RTools.Icons.mc_loud),
                new Buff("Power-Thrust", EffectStatusIDs.OVERTHRUST, Resources._4RTools.Icons.bs_overthrust),
                new Buff("Adrenaline Rush", EffectStatusIDs.ADRENALINE, Resources._4RTools.Icons.bs_adrenaline),
                new Buff("Advanced Adrenaline Rush", EffectStatusIDs.ADRENALINE2, Resources._4RTools.Icons.bs_adrenaline2),
                new Buff("Maximum Power-Thrust", EffectStatusIDs.OVERTHRUSTMAX, Resources._4RTools.Icons.ws_overthrustmax),
                new Buff("Weapon Perfection", EffectStatusIDs.WEAPONPERFECT, Resources._4RTools.Icons.bs_weaponperfect),
                new Buff("Power Maximize", EffectStatusIDs.MAXIMIZE, Resources._4RTools.Icons.bs_maximize),
                new Buff("Cart Boost", EffectStatusIDs.CARTBOOST, Resources._4RTools.Icons.ws_cartboost),
                new Buff("Meltdown", EffectStatusIDs.MELTDOWN, Resources._4RTools.Icons.ws_meltdown),
                new Buff("Acceleration", EffectStatusIDs.ACCELERATION, Resources._4RTools.Icons.mec_acceleration),
                new Buff("Cart Boost", EffectStatusIDs.GN_CARTBOOST, Resources._4RTools.Icons.cart_boost),
                new Buff("Research Report", EffectStatusIDs.EFST_RESEARCHREPORT, Resources._4RTools.Icons.researchreport),
                new Buff("Create Hell Tree", EffectStatusIDs.EFST_BO_HELL_DUSTY, Resources._4RTools.Icons.create_hell_tree),
            };

            return skills;
        }

        //Thief Skills
        public static List<Buff> GetThiefSkills()
        {
            List<Buff> skills = new List<Buff>
            {
                new Buff("Poison React", EffectStatusIDs.POISONREACT, Resources._4RTools.Icons.as_poisonreact),
                new Buff("Reject Sword", EffectStatusIDs.SWORDREJECT, Resources._4RTools.Icons.st_rejectsword),
                new Buff("Preserve", EffectStatusIDs.PRESERVE, Resources._4RTools.Icons.st_preserve),
                new Buff("Enchant Deadly Poison", EffectStatusIDs.EDP, Resources._4RTools.Icons.asc_edp),
                new Buff("Weapon Blocking", EffectStatusIDs.WEAPONBLOCKING, Resources._4RTools.Icons.weapon_blocking),
                new Buff("Dancing Knife", EffectStatusIDs.EFST_DANCING_KNIFE, Resources._4RTools.Icons.dancing_knife),
                new Buff("Enchanting Shadow", EffectStatusIDs.EFST_SHADOW_WEAPON, Resources._4RTools.Icons.enchanting_shadow),
                new Buff("Potent Venom", EffectStatusIDs.EFST_POTENT_VENOM, Resources._4RTools.Icons.potent_venom),
                new Buff("Shadow Exceed", EffectStatusIDs.EFST_SHADOW_EXCEED, Resources._4RTools.Icons.shadow_exceed),
                new Buff("Abyss Slayer", EffectStatusIDs.EFST_ABYSS_SLAYER, Resources._4RTools.Icons.abyss_slayer),
                new Buff("Abyss Dagger", EffectStatusIDs.EFST_ABYSS_DAGGER, Resources._4RTools.Icons.abyss_dagger),
            };

            return skills;
        }

        //Acolyte Skills
        public static List<Buff> GetAcolyteSkills()
        {
            List<Buff> skills = new List<Buff>
            {
                new Buff("Gloria", EffectStatusIDs.GLORIA, Resources._4RTools.Icons.pr_gloria),
                new Buff("Magnificat", EffectStatusIDs.MAGNIFICAT, Resources._4RTools.Icons.pr_magnificat),
                new Buff("Angelus", EffectStatusIDs.ANGELUS, Resources._4RTools.Icons.al_angelus),
                new Buff("Rising Dragon", EffectStatusIDs.RAISINGDRAGON, Resources._4RTools.Icons.rising_dragon),
                new Buff("Gentle Touch-Revitalize", EffectStatusIDs.GENTLETOUCH_REVITALIZE, Resources._4RTools.Icons.gentle_touch_revitalize),
                new Buff("Gentle Touch-Convert", EffectStatusIDs.GENTLETOUCH_CHANGE, Resources._4RTools.Icons.gentle_touch_convert),
                new Buff("Fury ", EffectStatusIDs.FURY, Resources._4RTools.Icons.fury),
                new Buff("Impositio Manus",  EffectStatusIDs.IMPOSITIO, Resources._4RTools.Icons.impositio_manus),
                new Buff("Competentia", EffectStatusIDs.EFST_COMPETENTIA, Resources._4RTools.Icons.competentia),
                new Buff("Offertorium", EffectStatusIDs.EFST_OFFERTORIUM, Resources._4RTools.Icons.offertorium),
                new Buff("Sincere Faith", EffectStatusIDs.EFST_SINCERE_FAITH, Resources._4RTools.Icons.sincere_faith),
                new Buff("Firm Faith", EffectStatusIDs.FIRM_FAITH, Resources._4RTools.Icons.firm_faith),
                new Buff("Powerful Faith", EffectStatusIDs.POWERFUL_FAITH, Resources._4RTools.Icons.powerful_faith),
            };

            return skills;
        }

        //Ninja Skills
        public static List<Buff> GetNinjaSkills()
        {
            List<Buff> skills = new List<Buff>
            {
                new Buff("Cicada Skin Shed", EffectStatusIDs.PEEL_CHANGE, Resources._4RTools.Icons.nj_utsusemi),
                new Buff("Ninja Aura", EffectStatusIDs.AURA_NINJA, Resources._4RTools.Icons.nj_nen),
                new Buff("Izayoi", EffectStatusIDs.IZAYOI, Resources._4RTools.Icons.izayoi)
            };

            return skills;
        }

        //Taekwon Skills
        public static List<Buff> GetTaekwonSkills()
        {
            List<Buff> skills = new List<Buff>
            {
                new Buff("Mild Wind (Earth)", EffectStatusIDs.PROPERTYGROUND, Resources._4RTools.Icons.tk_mild_earth),
                new Buff("Mild Wind (Fire)", EffectStatusIDs.PROPERTYFIRE, Resources._4RTools.Icons.tk_mild_fire),
                new Buff("Mild Wind (Water)", EffectStatusIDs.PROPERTYWATER, Resources._4RTools.Icons.tk_mild_water),
                new Buff("Mild Wind (Wind)", EffectStatusIDs.PROPERTYWIND, Resources._4RTools.Icons.tk_mild_wind),
                new Buff("Mild Wind (Ghost)", EffectStatusIDs.PROPERTYTELEKINESIS, Resources._4RTools.Icons.tk_mild_ghost),
                new Buff("Mild Wind (Holy)", EffectStatusIDs.ASPERSIO, Resources._4RTools.Icons.tk_mild_holy),
                new Buff("Mild Wind (Shadow)", EffectStatusIDs.PROPERTYDARK, Resources._4RTools.Icons.tk_mild_shadow),
                new Buff("Tumbling", EffectStatusIDs.DODGE_ON, Resources._4RTools.Icons.tumbling),
                new Buff("Enchanting Sky", EffectStatusIDs.EFST_SKY_ENCHANT, Resources._4RTools.Icons.enchanting_sky),
                new Buff("Universal Stance", EffectStatusIDs.EFST_UNIVERSESTANCE, Resources._4RTools.Icons.universal_stance),
            };

            return skills;
        }


        public static List<Buff> GetGunsSkills()
        {
            List<Buff> skills = new List<Buff>();

            skills.Add(new Buff("Gatling Fever", EffectStatusIDs.GATLINGFEVER, Resources._4RTools.Icons.gatling_fever));
            skills.Add(new Buff("Madness Canceller", EffectStatusIDs.MADNESSCANCEL, Resources._4RTools.Icons.madnesscancel));
            skills.Add(new Buff("Adjustment", EffectStatusIDs.ADJUSTMENT, Resources._4RTools.Icons.adjustment));
            skills.Add(new Buff("Increase Accuracy", EffectStatusIDs.ACCURACY, Resources._4RTools.Icons.increase_accuracy));

            return skills;
        }

        // [Summoner](https://irowiki.org/wiki/Summoner)
        public static List<Buff> GeSummonerSkills()
        {
            List<Buff> skills = new List<Buff>
            {
                new Buff("Bunch of Shrimp", EffectStatusIDs.EFST_SHRIMP, Resources._4RTools.Icons.bunch_of_shrimp),
                new Buff("Temporary Communion", EffectStatusIDs.EFST_TEMPORARY_COMMUNION, Resources._4RTools.Icons.temporary_communion),
                new Buff("Marine Festival of Kisul", EffectStatusIDs.EFST_MARINE_FESTIVAL, Resources._4RTools.Icons.marine_festival_of_kisul),
                new Buff("Sandy Festival of Kisul", EffectStatusIDs.EFST_SANDY_FESTIVAL, Resources._4RTools.Icons.sandy_festival_of_kisul),
                new Buff("Colors of Hyunrok Lv 1", EffectStatusIDs.EFST_COLORS_OF_HYUN_ROK_1, Resources._4RTools.Icons.colors_of_hyunrok_1),
                new Buff("Colors of Hyunrok Lv 2", EffectStatusIDs.EFST_COLORS_OF_HYUN_ROK_2, Resources._4RTools.Icons.colors_of_hyunrok_2),
                new Buff("Colors of Hyunrok Lv 3", EffectStatusIDs.EFST_COLORS_OF_HYUN_ROK_3, Resources._4RTools.Icons.colors_of_hyunrok_3),
                new Buff("Colors of Hyunrok Lv 4", EffectStatusIDs.EFST_COLORS_OF_HYUN_ROK_4, Resources._4RTools.Icons.colors_of_hyunrok_4),
                new Buff("Colors of Hyunrok Lv 5", EffectStatusIDs.EFST_COLORS_OF_HYUN_ROK_5, Resources._4RTools.Icons.colors_of_hyunrok_5),
                new Buff("Colors of Hyunrok Lv 6", EffectStatusIDs.EFST_COLORS_OF_HYUN_ROK_6, Resources._4RTools.Icons.colors_of_hyunrok_6),
            };

            return skills;
        }

        // [Cardinal](https://irowiki.org/wiki/Cardinal)
        public static List<Buff> GeCardinalSkills()
        {
            List<Buff> skills = new List<Buff>
            {

            };

            return skills;
        }

        // [Soul Ascetic](https://wiki.historyreborn.org/index.php/Soul_Ascetic)
        public static List<Buff> GetSoulAsceticSkills()
        {
            List<Buff> skills = new List<Buff>
            {
                new Buff("Soul of Heaven and Earth", EffectStatusIDs.EFST_HEAVEN_AND_EARTH, Resources._4RTools.Icons.soul_of_heaven_and_earth),
            };

            return skills;
        }

        // [Night Watch](https://wiki.ragna4th.com/Night_Watch)
        public static List<Buff> GetNightWatchSkills()
        {
            List<Buff> skills = new List<Buff>
            {
                new Buff("Hidden Card", EffectStatusIDs.EFST_HIDDEN_CARD, Resources._4RTools.Icons.hidden_card),
                new Buff("Intensive Aim", EffectStatusIDs.EFST_INTENSIVE_AIM, Resources._4RTools.Icons.intensive_aim),
                new Buff("Auto Firing Launcher", EffectStatusIDs.EFST_AUTO_FIRING_LAUNCHEREFST, Resources._4RTools.Icons.auto_firing_launcher),
                new Buff("Platinum Altar", EffectStatusIDs.EFST_P_ALTER, Resources._4RTools.Icons.platinum_altar),
                new Buff("Hit Barrel", EffectStatusIDs.EFST_HEAT_BARREL, Resources._4RTools.Icons.hit_barrel),
                new Buff("Eternal Chain", EffectStatusIDs.EFST_E_CHAIN, Resources._4RTools.Icons.eternal_chain),
                new Buff("Grenade Fragmenth Lv 1", EffectStatusIDs.EFST_GRENADE_FRAGMENT_1, Resources._4RTools.Icons.grenade_fragment_1),
                new Buff("Grenade Fragmenth Lv 2", EffectStatusIDs.EFST_GRENADE_FRAGMENT_2, Resources._4RTools.Icons.grenade_fragment_2),
                new Buff("Grenade Fragmenth Lv 3", EffectStatusIDs.EFST_GRENADE_FRAGMENT_3, Resources._4RTools.Icons.grenade_fragment_3),
                new Buff("Grenade Fragmenth Lv 4", EffectStatusIDs.EFST_GRENADE_FRAGMENT_4, Resources._4RTools.Icons.grenade_fragment_4),
                new Buff("Grenade Fragmenth Lv 5", EffectStatusIDs.EFST_GRENADE_FRAGMENT_5, Resources._4RTools.Icons.grenade_fragment_5),
                new Buff("Grenade Fragmenth Lv 6", EffectStatusIDs.EFST_GRENADE_FRAGMENT_6, Resources._4RTools.Icons.grenade_fragment_6),
            };

            return skills;
        }

        // [Hyper Novice](https://www.divine-pride.net/tools/skilltree/4307)
        public static List<Buff> GetHyperNoviceSkills()
        {
            List<Buff> skills = new List<Buff>
            {
                new Buff("Rule Break", EffectStatusIDs.EFST_RULEBREAK, Resources._4RTools.Icons.rule_break),
                new Buff("Breaking Limit", EffectStatusIDs.EFST_BREAKINGLIMIT, Resources._4RTools.Icons.breaking_limit),
            };

            return skills;
        }

        //--------------------- STUFFS ------------------------------
        //--------------------- Potions ------------------------------
        public static List<Buff> GetPotionsBuffs()
        {
            List<Buff> skills = new List<Buff>
            {
                new Buff("Concentration Potion", EffectStatusIDs.CONCENTRATION_POTION, Resources._4RTools.Icons.concentration_potiongif),
                new Buff("Awakening Potion", EffectStatusIDs.AWAKENING_POTION, Resources._4RTools.Icons.awakening_potion),
                new Buff("Berserk Potion", EffectStatusIDs.BERSERK_POTION, Resources._4RTools.Icons.berserk_potion),
                new Buff("Regeneration Potion", EffectStatusIDs.REGENERATION_POTION, Resources._4RTools.Icons.regeneration),
                new Buff("HP Increase Potion", EffectStatusIDs.HP_INCREASE_POTION_LARGE, Resources._4RTools.Icons.ghp),
                new Buff("SP Increase Potion", EffectStatusIDs.SP_INCREASE_POTION_LARGE, Resources._4RTools.Icons.gsp),
                new Buff("Red Herb Activator", EffectStatusIDs.RED_HERB_ACTIVATOR, Resources._4RTools.Icons.red_herb_activator),
                new Buff("Blue Herb Activator", EffectStatusIDs.BLUE_HERB_ACTIVATOR, Resources._4RTools.Icons.blue_herb_activator),
                new Buff("Golden X", EffectStatusIDs.REF_T_POTION, Resources._4RTools.Icons.Golden_X),
                new Buff("Energy Drink", EffectStatusIDs.ENERGY_DRINK_RESERCH, Resources._4RTools.Icons.energetic_drink),
                new Buff("Mega Resist Potion", EffectStatusIDs.TARGET_BLOOD, Resources._4RTools.Icons.mega_resist_potion),
                new Buff("Full SwingK Potion", EffectStatusIDs.FULL_SWINGK, Resources._4RTools.Icons.swing_k),
                new Buff("Mana Plus Potion", EffectStatusIDs.MANA_PLUS, Resources._4RTools.Icons.mana_plus),
                new Buff("Blessing Of Tyr", EffectStatusIDs.BASICHIT, Resources._4RTools.Icons.blessing_of_tyr),
                new Buff("True Limit Power Booster", EffectStatusIDs.EFST_LIMIT_POWER_BOOSTER, Resources._4RTools.Icons.true_limit_power_booster),
                new Buff("Infinity Drink", EffectStatusIDs.EFST_INFINITY_DRINK, Resources._4RTools.Icons.infinity_drink),
                new Buff("Red Booster (ATK +30, MATK +30)", EffectStatusIDs.RWC_2011_SCROLL, Resources._4RTools.Icons.red_booster),
                new Buff("Poção Fantástica (Sealed Kiel Card)", EffectStatusIDs.EFST_KIEL_CARD, Resources._4RTools.Icons.pocao_fantastica),
                new Buff("Poção do Furor Físico", EffectStatusIDs.EFST_DF_FULLSWINGK, Resources._4RTools.Icons.full_swingK),
                new Buff("Poção Mágica", EffectStatusIDs.EFST_DRACULA_CARD, Resources._4RTools.Icons.pocao_magica),
                new Buff("True ASPD Intensifying Potion", EffectStatusIDs.EFST_REUSE_LIMIT_ASPD_POTION, Resources._4RTools.Icons.G_ASPD_Potion),
                new Buff("True Medium Life Potion", EffectStatusIDs.EFST_L_LIFEPOTION, Resources._4RTools.Icons.g_med_life_potion),
            };

            return skills;
        }

        public static List<Buff> GetElementalsBuffs()
        {
            List<Buff> skills = new List<Buff>
            {
                new Buff("Elemental Converter (Fire)", EffectStatusIDs.EFST_ATTACK_PROPERTY_FIRE, Resources._4RTools.Icons.PROPERTY_FIRE),
                new Buff("Elemental Converter (Wind)", EffectStatusIDs.EFST_ATTACK_PROPERTY_WIND, Resources._4RTools.Icons.PROPERTY_WIND),
                new Buff("Elemental Converter (Earth)", EffectStatusIDs.EFST_ATTACK_PROPERTY_GROUND, Resources._4RTools.Icons.PROPERTY_GROUND),
                new Buff("Elemental Converter (Water)", EffectStatusIDs.EFST_ATTACK_PROPERTY_WATER, Resources._4RTools.Icons.PROPERTY_WATER),
                new Buff("Cursed Water", EffectStatusIDs.PROPERTYDARK, Resources._4RTools.Icons.cursed_water),
                new Buff("Fire Conversor", EffectStatusIDs.PROPERTYFIRE, Resources._4RTools.Icons.ele_fire_converter),
                new Buff("Wind Conversor", EffectStatusIDs.PROPERTYWIND, Resources._4RTools.Icons.ele_wind_converter),
                new Buff("Earth Conversor", EffectStatusIDs.PROPERTYGROUND, Resources._4RTools.Icons.ele_earth_converter),
                new Buff("Water Conversor", EffectStatusIDs.PROPERTYWATER, Resources._4RTools.Icons.ele_water_converter),
                new Buff("Aspersio Scroll", EffectStatusIDs.ASPERSIO, Resources._4RTools.Icons.ele_holy_converter),
                new Buff("GHOST Conversor", EffectStatusIDs.PROPERTYTELEKINESIS, Resources._4RTools.Icons.ele_ghost_converter),
                new Buff("Fireproof Potion", EffectStatusIDs.RESIST_PROPERTY_FIRE, Resources._4RTools.Icons.fireproof),
                new Buff("Waterproof Potion", EffectStatusIDs.RESIST_PROPERTY_WATER, Resources._4RTools.Icons.coldproof),
                new Buff("Windproof Potion", EffectStatusIDs.RESIST_PROPERTY_WIND, Resources._4RTools.Icons.thunderproof),
                new Buff("Earthproof Potion", EffectStatusIDs.RESIST_PROPERTY_GROUND, Resources._4RTools.Icons.earhproof)
            };

            return skills;
        }

        public static List<Buff> GetFoodBuffs()
        {
            List<Buff> skills = new List<Buff>
            {
                new Buff("STR Food", EffectStatusIDs.FOOD_STR, Resources._4RTools.Icons.strfood),
                new Buff("AGI Food", EffectStatusIDs.FOOD_AGI, Resources._4RTools.Icons.agi_food),
                new Buff("VIT Food", EffectStatusIDs.FOOD_VIT, Resources._4RTools.Icons.vit_food),
                new Buff("INT Food", EffectStatusIDs.FOOD_INT, Resources._4RTools.Icons.int_food),
                new Buff("DEX Food", EffectStatusIDs.FOOD_DEX, Resources._4RTools.Icons.dex_food),
                new Buff("LUK Food", EffectStatusIDs.FOOD_LUK, Resources._4RTools.Icons.luk_food),

                new Buff("3RD STR Food", EffectStatusIDs.STR_3RD_FOOD, Resources._4RTools.Icons.str_3rd_food),
                new Buff("3RD AGI Food", EffectStatusIDs.AGI_3RD_FOOD, Resources._4RTools.Icons.agi_3rd_food),
                new Buff("3RD VIT Food", EffectStatusIDs.VIT_3RD_FOOD, Resources._4RTools.Icons.vit_3rd_food),
                new Buff("3RD INT Food", EffectStatusIDs.INT_3RD_FOOD, Resources._4RTools.Icons.int_3rd_food),
                new Buff("3RD DEX Food", EffectStatusIDs.DEX_3RD_FOOD, Resources._4RTools.Icons.dex_3rd_food),
                new Buff("3RD LUK Food", EffectStatusIDs.LUK_3RD_FOOD, Resources._4RTools.Icons.luk_3rd_food),
                new Buff("Almighty", EffectStatusIDs.RWC_2011_SCROLL, Resources._4RTools.Icons.almighty),
                new Buff("CASH Food", EffectStatusIDs.FOOD_VIT_CASH, Resources._4RTools.Icons.cash_food),
                new Buff("Acarajé", EffectStatusIDs.EFST_ACARAJE, Resources._4RTools.Icons.acaraje),

                new Buff("STR Biscuit Stick", EffectStatusIDs.STR_Biscuit_Stick, Resources._4RTools.Icons.str_biscuit_stick),
                new Buff("AGI Biscuit Stick", EffectStatusIDs.AGI_Biscuit_Stick, Resources._4RTools.Icons.agi_biscuit_stick),
                new Buff("VIT Biscuit Stick", EffectStatusIDs.VIT_Biscuit_Stick, Resources._4RTools.Icons.vit_biscuit_stick),
                new Buff("INT Biscuit Stick", EffectStatusIDs.INT_Biscuit_Stick, Resources._4RTools.Icons.int_biscuit_stick),
                new Buff("DEX Biscuit Stick", EffectStatusIDs.DEX_Biscuit_Stick, Resources._4RTools.Icons.dex_biscuit_stick),
                new Buff("LUK Biscuit Stick", EffectStatusIDs.LUK_Biscuit_Stick, Resources._4RTools.Icons.luk_biscuit_stick),

                new Buff("STR Bubble Gum Orange", EffectStatusIDs.EFST_Bubble_Gum_Green, Resources._4RTools.Icons.str_bubble_gum_green),
                new Buff("AGI Biscuit Stick", EffectStatusIDs.EFST_Bubble_Gum_Red, Resources._4RTools.Icons.agi_bubble_gum_red),
                new Buff("INT Bubble Gum Yellow", EffectStatusIDs.EFST_Bubble_Gum_Yellow, Resources._4RTools.Icons.int_bubble_gum_yellow),
                new Buff("DEX Bubble Gum Orange", EffectStatusIDs.EFST_Bubble_Gum_Orange, Resources._4RTools.Icons.dex_bubble_gum_orange),

                new Buff("Winter Cookie ATK ", EffectStatusIDs.EFST_ATK_POPCORN, Resources._4RTools.Icons.winter_cookie),
                new Buff("Flora Cookie MATK", EffectStatusIDs.EFST_MATK_POPCORN, Resources._4RTools.Icons.flora_cookie),
            };

            return skills;
        }

        public static List<Buff> GetBoxesBuffs()
        {
            List<Buff> skills = new List<Buff>
            {
                new Buff("Drowsiness Box", EffectStatusIDs.DROWSINESS_BOX, Resources._4RTools.Icons.drowsiness),
                new Buff("Resentment Box", EffectStatusIDs.RESENTMENT_BOX, Resources._4RTools.Icons.resentment),
                new Buff("Sunlight Box", EffectStatusIDs.SUNLIGHT_BOX, Resources._4RTools.Icons.sunbox),
                new Buff("Box of Gloom", EffectStatusIDs.CONCENTRATION, Resources._4RTools.Icons.gloom),
                new Buff("Box of Thunder", EffectStatusIDs.BOX_OF_THUNDER, Resources._4RTools.Icons.speed),
                new Buff("Speed Potion / Guyak", EffectStatusIDs.SPEED_POT, Resources._4RTools.Icons.speedpotion),
                new Buff("Anodyne", EffectStatusIDs.ENDURE, Resources._4RTools.Icons.anodyne),
                new Buff("Aloevera", EffectStatusIDs.PROVOKE, Resources._4RTools.Icons.aloevera),
                new Buff("Abrasivo", EffectStatusIDs.CRITICALPERCENT, Resources._4RTools.Icons.abrasive),
                new Buff("Combat Pill", EffectStatusIDs.COMBAT_PILL, Resources._4RTools.Icons.combat_pill),
                new Buff("Advance Combat Pill", EffectStatusIDs.EFST_GM_BATTLE2, Resources._4RTools.Icons.advance_combat_pill),
                new Buff("Celermine Juice", EffectStatusIDs.ENRICH_CELERMINE_JUICE, Resources._4RTools.Icons.celermine),
                new Buff("Guarana Candy", EffectStatusIDs.SPEED_POT, Resources._4RTools.Icons.guarana_candy),
                new Buff("Poison Bottle", EffectStatusIDs.ASPDPOTIONINFINITY, Resources._4RTools.Icons.poison),
            };

            return skills;
        }

        public static List<Buff> GetScrollBuffs()
        {
            List<Buff> skills = new List<Buff>
            {
                new Buff("Éden Scroll", EffectStatusIDs.EFST_EDEN, Resources._4RTools.Icons.eden_scroll),
                new Buff("Increase Agility Scroll", EffectStatusIDs.INC_AGI, Resources._4RTools.Icons.al_incagi1),
                new Buff("Bless Scroll", EffectStatusIDs.BLESSING, Resources._4RTools.Icons.al_blessing1),
                new Buff("Full Chemical Protection (Scroll)", EffectStatusIDs.PROTECTARMOR, Resources._4RTools.Icons.cr_fullprotection),
                new Buff("Burn Incense",  EffectStatusIDs.EFST_BURNT_INCENSE, Resources._4RTools.Icons.burnt_incense),
                new Buff("Link Scroll", EffectStatusIDs.SOULLINK, Resources._4RTools.Icons.sl_soullinker),
                new Buff("Monster Transform",  EffectStatusIDs.MONSTER_TRANSFORM, Resources._4RTools.Icons.mob_transform),
                new Buff("Assumptio",  EffectStatusIDs.ASSUMPTIO, Resources._4RTools.Icons.assumptio),
                new Buff("Holy Armor Scroll",  EffectStatusIDs.EFST_ARMOR_PROPERTY, Resources._4RTools.Icons.holy_armor),
                new Buff("Shadow Armor Scroll",  EffectStatusIDs.EFST_ARMOR_PROPERTY, Resources._4RTools.Icons.shadow_armor_scroll),
                new Buff("Soul Scroll",  EffectStatusIDs.EFST_SOULSCROLL, Resources._4RTools.Icons.soul_scroll),
                new Buff("Undead Element Scroll",  EffectStatusIDs.EFST_RESIST_PROPERTY_UNDEAD, Resources._4RTools.Icons.undead_element_scroll),
            };

            return skills;
        }

        public static List<Buff> GetETCBuffs()
        {
            List<Buff> skills = new List<Buff>
            {
                new Buff("THURISAZ Rune", EffectStatusIDs.THURISAZ, Resources._4RTools.Icons.THURISAZ),
                new Buff("OTHILA Rune", EffectStatusIDs.OTHILA, Resources._4RTools.Icons.OTHILA),
                new Buff("HAGALAZ Rune", EffectStatusIDs.HAGALAZ, Resources._4RTools.Icons.HAGALAZ),
                new Buff("LUX AMINA Rune", EffectStatusIDs.LUX_AMINA, Resources._4RTools.Icons.LUX_AMINA),
                new Buff("Cat Can", EffectStatusIDs.OVERLAPEXPUP, Resources._4RTools.Icons.cat_can),
                new Buff("HE Bubble Gum", EffectStatusIDs.CASH_RECEIVEITEM, Resources._4RTools.Icons.he_bubble_gum2),
                new Buff("Frost Giant Blood (GvG GIANT)", EffectStatusIDs.EFST_GVG_GIANT, Resources._4RTools.Icons.frost_giant_blood),
                new Buff("Battle Manual (GvG GOLEM)", EffectStatusIDs.EFST_GVG_GOLEM, Resources._4RTools.Icons.golem_stone),
                new Buff("Magic Candy", EffectStatusIDs.EFST_MAGIC_CANDY, Resources._4RTools.Icons.magic_candy),
                new Buff("Ghostring", EffectStatusIDs.EFST_GHOSTRING, Resources._4RTools.Icons.perg_ghostring),
                new Buff("Angeling", EffectStatusIDs.EFST_ANGELING, Resources._4RTools.Icons.perg_angeling),
                new Buff("Tao Gunka", EffectStatusIDs.EFST_TAO_GUNKA, Resources._4RTools.Icons.perg_taogunka),
                new Buff("Orc Lord", EffectStatusIDs.EFST_ORC_LORD, Resources._4RTools.Icons.perg_senhororc),
                new Buff("Orc Hero", EffectStatusIDs.EFST_ORC_HERO, Resources._4RTools.Icons.perg_orcheroi),
                new Buff("MISTRESS", EffectStatusIDs.EFST_MISTRESS, Resources._4RTools.Icons.perg_abelha),
            };

            return skills;
        }

        public static List<Buff> GetCandiesBuffs()
        {
            List<Buff> skills = new List<Buff>
            {
                new Buff("Sweets Macaron Cake", EffectStatusIDs.EFST_SWEETSFAIR_ATK, Resources._4RTools.Icons.sweets_macacake),
                new Buff("Sweets Strawberry Parfait", EffectStatusIDs.EFST_SWEETSFAIR_MATK, Resources._4RTools.Icons.sweets_sparfait),
                new Buff("Popcorn Festival Buff", EffectStatusIDs.EFST_FLOWER_LEAF2, Resources._4RTools.Icons.pop_corn_fes_buff),
                new Buff("Doce Hiper Açucarado", EffectStatusIDs.EFST_STEAMPACK, Resources._4RTools.Icons.spark_candy),
                new Buff("Elixir Ultra Milagroso", EffectStatusIDs.EFST_ALMIGHTY, Resources._4RTools.Icons.g_almighty),
                new Buff("Cherry Blossom Rice Cake", EffectStatusIDs.EFST_FLOWER_LEAF4, Resources._4RTools.Icons.cherry_blossom_cake),
            };

            return skills;
        }

        public static List<Buff> GetEXPBuffs()
        {
            List<Buff> skills = new List<Buff>
            {
                new Buff("Goma de Mascar", EffectStatusIDs.CASH_RECEIVEITEM, Resources._4RTools.Icons.he_bubble_gum),
                new Buff("Manual de Combate", EffectStatusIDs.CASH_PLUSEXP, Resources._4RTools.Icons.combat_manual_base),
                new Buff("Manual de Combate de classe", EffectStatusIDs.CASH_PLUSECLASSXP, Resources._4RTools.Icons.combat_manual_class),
            };

            return skills;
        }

        public static List<Buff> GetHomunculusBuffs()
        {
            List<Buff> skills = new List<Buff>
            {
                new Buff("Pyroclastic", EffectStatusIDs.EFST_PYROCLASTIC, Resources._4RTools.Icons.pyroclastic),
                new Buff("HOMUN_LAST", EffectStatusIDs.EFST_TEMPERING, Resources._4RTools.Icons.homun_last),
            };

            return skills;
        }

        //--------------------- DEBUFFS ------------------------------
        public static List<Buff> GetDebuffs()
        {
            List<Buff> skills = new List<Buff>
            {
                new Buff("Critical Wounds", EffectStatusIDs.CRITICALWOUND, Resources._4RTools.Icons.critical_wound),
                new Buff("FREEZING", EffectStatusIDs.EFST_FREEZING, Resources._4RTools.Icons.freezing),
                new Buff("Curse", EffectStatusIDs.CURSE, Resources._4RTools.Icons.curse),
                new Buff("Bleeding", EffectStatusIDs.EFST_BLEEDING, Resources._4RTools.Icons.bleeding),
                new Buff("Silence", EffectStatusIDs.SILENCE, Resources._4RTools.Icons.silence),
                new Buff("Decrease Agi", EffectStatusIDs.EFST_DECREASE_AGI, Resources._4RTools.Icons.decrease_agi),
                new Buff("Confusion / chaos", EffectStatusIDs.CONFUSION, Resources._4RTools.Icons.chaos),
                new Buff("STUN", EffectStatusIDs.EFST_STUN, Resources._4RTools.Icons.stun),
                new Buff("Deep Sleep", EffectStatusIDs.EFST_DEEP_SLEEP, Resources._4RTools.Icons.deep_sleep),
                new Buff("Posion", EffectStatusIDs.POISON, Resources._4RTools.Icons.poison_status),
                new Buff("Lucky Water", EffectStatusIDs.EFST_HANDICAPSTATE_MISFORTUNE, Resources._4RTools.Icons.water_of_lucky),
            };

            return skills;
        }
    }
}