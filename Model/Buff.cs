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
                new Buff("Frigg's Song", EffectStatusIDs.FRIGG_SONG, Resources._4RTools.Icons.friggs_song)
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
                new Buff("Vanguard Force", EffectStatusIDs.FORCEOFVANGUARD, Resources._4RTools.Icons.vanguard_force)
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
                new Buff("Recognized Spell", EffectStatusIDs.RECOGNIZEDSPELL, Resources._4RTools.Icons.recognized_spell)
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
                new Buff("Research Report", EffectStatusIDs.RESEARCHREPORT, Resources._4RTools.Icons.researchreport)
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
                new Buff("Weapon Blocking", EffectStatusIDs.WEAPONBLOCKING, Resources._4RTools.Icons.weapon_blocking)
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
                new Buff("Firm Faith", EffectStatusIDs.FIRM_FAITH, Resources._4RTools.Icons.firm_faith),
                new Buff("Powerful Faith", EffectStatusIDs.POWERFUL_FAITH, Resources._4RTools.Icons.powerful_faith),
                new Buff("Gentle Touch-Revitalize", EffectStatusIDs.GENTLETOUCH_REVITALIZE, Resources._4RTools.Icons.gentle_touch_revitalize),
                new Buff("Gentle Touch-Convert", EffectStatusIDs.GENTLETOUCH_CHANGE, Resources._4RTools.Icons.gentle_touch_convert),
                new Buff("Fury ", EffectStatusIDs.FURY, Resources._4RTools.Icons.fury)
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
                new Buff("Tumbling", EffectStatusIDs.DODGE_ON, Resources._4RTools.Icons.tumbling)
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
                new Buff("Blessing Of Tyr", EffectStatusIDs.BASICHIT, Resources._4RTools.Icons.blessing_of_tyr)
            };

            return skills;
        }

        public static List<Buff> GetElementalsBuffs()
        {
            List<Buff> skills = new List<Buff>
            {
                new Buff("Fire Conversor", EffectStatusIDs.PROPERTYFIRE, Resources._4RTools.Icons.ele_fire_converter),
                new Buff("Wind Conversor", EffectStatusIDs.PROPERTYWIND, Resources._4RTools.Icons.ele_wind_converter),
                new Buff("Earth Conversor", EffectStatusIDs.PROPERTYGROUND, Resources._4RTools.Icons.ele_earth_converter),
                new Buff("Water Conversor", EffectStatusIDs.PROPERTYWATER, Resources._4RTools.Icons.ele_water_converter),
                new Buff("Cursed Water", EffectStatusIDs.PROPERTYDARK, Resources._4RTools.Icons.cursed_water),
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
                new Buff("Celermine Juice", EffectStatusIDs.ENRICH_CELERMINE_JUICE, Resources._4RTools.Icons.celermine)
            };

            return skills;
        }

        public static List<Buff> GetScrollBuffs()
        {
            List<Buff> skills = new List<Buff>
            {

                new Buff("Increase Agility Scroll", EffectStatusIDs.INC_AGI, Resources._4RTools.Icons.al_incagi1),
                new Buff("Bless Scroll", EffectStatusIDs.BLESSING, Resources._4RTools.Icons.al_blessing1),
                new Buff("Full Chemical Protection (Scroll)", EffectStatusIDs.PROTECTARMOR, Resources._4RTools.Icons.cr_fullprotection),
                new Buff("Link Scroll", EffectStatusIDs.SOULLINK, Resources._4RTools.Icons.sl_soullinker),
                new Buff("Monster Transform",  EffectStatusIDs.MONSTER_TRANSFORM, Resources._4RTools.Icons.mob_transform),
                new Buff("Assumptio",  EffectStatusIDs.ASSUMPTIO, Resources._4RTools.Icons.assumptio)

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
                new Buff("Bubble Gum", EffectStatusIDs.CASH_RECEIVEITEM, Resources._4RTools.Icons.he_bubble_gum),
                new Buff("Battle Manual", EffectStatusIDs.CASH_PLUSEXP, Resources._4RTools.Icons.combat_manual),
		new Buff("Shield Protection", EffectStatusIDs.PROTECTSHIELD, Resources._4RTools.Icons.PROTECTSHIELD),
		new Buff("Weapon Protection", EffectStatusIDs.PROTECTWEAPON, Resources._4RTools.Icons.PROTECTWEAPON),
		new Buff("Amor Protection", EffectStatusIDs.PROTECTARMOR, Resources._4RTools.Icons.PROTECTARMOR),
		new Buff("Helm Protection", EffectStatusIDs.PROTECTHELM, Resources._4RTools.Icons.PROTECTHELM)
            };

            return skills;
        }

    }
}
