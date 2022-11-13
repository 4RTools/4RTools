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
            List<Buff> skills = new List<Buff>();

            skills.Add(new Buff("Concentration", EffectStatusIDs.CONCENTRATION, Resources._4RTools.Icons.ac_concentration));
            skills.Add(new Buff("Wind Walk", EffectStatusIDs.WINDWALK, Resources._4RTools.Icons.sn_windwalk));
            skills.Add(new Buff("True Sight", EffectStatusIDs.TRUESIGHT, Resources._4RTools.Icons.sn_sight));

            return skills;
        }

        //Swordsman Skills
        public static List<Buff> GetSwordmanSkill()
        {
            List<Buff> skills = new List<Buff>();

            skills.Add(new Buff("Endure", EffectStatusIDs.ENDURE, Resources._4RTools.Icons.sm_endure));
            skills.Add(new Buff("Auto Beserk", EffectStatusIDs.AUTOBERSERK, Resources._4RTools.Icons.sm_autoberserk));
            skills.Add(new Buff("Guard", EffectStatusIDs.AUTOGUARD, Resources._4RTools.Icons.cr_autoguard));
            skills.Add(new Buff("Shield Reflection", EffectStatusIDs.REFLECTSHIELD, Resources._4RTools.Icons.cr_reflectshield));
            skills.Add(new Buff("Defending Aura", EffectStatusIDs.DEFENDER, Resources._4RTools.Icons.cr_defender));
            skills.Add(new Buff("Dedication", EffectStatusIDs.LKCONCENTRATION, Resources._4RTools.Icons.lk_concentration));
            skills.Add(new Buff("Frenzy", EffectStatusIDs.BERSERK, Resources._4RTools.Icons.lk_berserk));
            skills.Add(new Buff("Twohand Quicken", EffectStatusIDs.TWOHANDQUICKEN, Resources._4RTools.Icons.mer_quicken));
            skills.Add(new Buff("Parry", EffectStatusIDs.PARRYING, Resources._4RTools.Icons.ms_parrying));
            skills.Add(new Buff("Aura Blade", EffectStatusIDs.AURABLADE, Resources._4RTools.Icons.lk_aurablade));
            skills.Add(new Buff("Enchant Blade", EffectStatusIDs.AURABLADE, Resources._4RTools.Icons.enchant_blade));
            skills.Add(new Buff("Shrink", EffectStatusIDs.CR_SHRINK, Resources._4RTools.Icons.cr_shrink));


            return skills;
        }

        //Mage Skills
        public static List<Buff> GetMageSkills()
        {
            List<Buff> skills = new List<Buff>();

            skills.Add(new Buff("Energy Coat", EffectStatusIDs.ENERGYCOAT, Resources._4RTools.Icons.mg_energycoat));
            skills.Add(new Buff("Explosão Protetora", EffectStatusIDs.SIGHTBLASTER, Resources._4RTools.Icons.wz_sightblaster));
            skills.Add(new Buff("Desejo Arcano", EffectStatusIDs.AUTOSPELL, Resources._4RTools.Icons.sa_autospell));
            skills.Add(new Buff("Lanças Duplas", EffectStatusIDs.DOUBLECASTING, Resources._4RTools.Icons.pf_doublecasting));
            skills.Add(new Buff("Presciência", EffectStatusIDs.MEMORIZE, Resources._4RTools.Icons.pf_memorize));


            return skills;
        }

        //Swordsman Skills
        public static List<Buff> GetMerchantSkills()
        {
            List<Buff> skills = new List<Buff>();

            skills.Add(new Buff("Crazy Uproar", EffectStatusIDs.CRAZY_UPROAR, Resources._4RTools.Icons.mc_loud));
            skills.Add(new Buff("Power-Thrust", EffectStatusIDs.OVERTHRUST, Resources._4RTools.Icons.bs_overthrust));
            skills.Add(new Buff("Adrenaline Rush", EffectStatusIDs.ADRENALINE, Resources._4RTools.Icons.bs_adrenaline));
            skills.Add(new Buff("Advanced Adrenaline Rush", EffectStatusIDs.ADRENALINE2, Resources._4RTools.Icons.bs_adrenaline2));
            skills.Add(new Buff("Maximum Power-Thrust", EffectStatusIDs.OVERTHRUSTMAX, Resources._4RTools.Icons.ws_overthrustmax));
            skills.Add(new Buff("Weapon Perfection", EffectStatusIDs.WEAPONPERFECT, Resources._4RTools.Icons.bs_weaponperfect));
            skills.Add(new Buff("Power Maximize", EffectStatusIDs.MAXIMIZE, Resources._4RTools.Icons.bs_maximize));
            skills.Add(new Buff("Cart Boost", EffectStatusIDs.CARTBOOST, Resources._4RTools.Icons.ws_cartboost));
            skills.Add(new Buff("Meltdown", EffectStatusIDs.MELTDOWN, Resources._4RTools.Icons.ws_meltdown));
            skills.Add(new Buff("Acceleration", EffectStatusIDs.ACCELERATION, Resources._4RTools.Icons.mec_acceleration));


            return skills;
        }

        //Thief Skills
        public static List<Buff> GetThiefSkills()
        {
            List<Buff> skills = new List<Buff>();

            skills.Add(new Buff("Poison React", EffectStatusIDs.POISONREACT, Resources._4RTools.Icons.as_poisonreact));
            skills.Add(new Buff("Reject Sword", EffectStatusIDs.SWORDREJECT, Resources._4RTools.Icons.st_rejectsword));
            skills.Add(new Buff("Preserve", EffectStatusIDs.PRESERVE, Resources._4RTools.Icons.st_preserve));
            skills.Add(new Buff("Enchant Deadly Poison", EffectStatusIDs.EDP, Resources._4RTools.Icons.asc_edp));

            return skills;
        }

        //Acolyte Skills
        public static List<Buff> GetAcolyteSkills()
        {
            List<Buff> skills = new List<Buff>();

            skills.Add(new Buff("Gloria", EffectStatusIDs.GLORIA, Resources._4RTools.Icons.pr_gloria));
            skills.Add(new Buff("Magnificat", EffectStatusIDs.MAGNIFICAT, Resources._4RTools.Icons.pr_magnificat));
            skills.Add(new Buff("Angelus", EffectStatusIDs.ANGELUS, Resources._4RTools.Icons.al_angelus));

            return skills;
        }

        //Ninja Skills
        public static List<Buff> GetNinjaSkills()
        {
            List<Buff> skills = new List<Buff>();

            skills.Add(new Buff("Cicada Skin Shed", EffectStatusIDs.PEEL_CHANGE, Resources._4RTools.Icons.nj_utsusemi));
            skills.Add(new Buff("Ninja Aura", EffectStatusIDs.AURA_NINJA, Resources._4RTools.Icons.nj_nen));
            
            return skills;
        }

        //Taekwon Skills
        public static List<Buff> GetTaekwonSkills()
        {
            List<Buff> skills = new List<Buff>();

            skills.Add(new Buff("Mild Wind (Earth)", EffectStatusIDs.PROPERTYGROUND, Resources._4RTools.Icons.tk_mild_earth));
            skills.Add(new Buff("Mild Wind (Fire)", EffectStatusIDs.PROPERTYFIRE, Resources._4RTools.Icons.tk_mild_fire));
            skills.Add(new Buff("Mild Wind (Water)", EffectStatusIDs.PROPERTYWATER, Resources._4RTools.Icons.tk_mild_water));
            skills.Add(new Buff("Mild Wind (Wind)", EffectStatusIDs.PROPERTYWIND, Resources._4RTools.Icons.tk_mild_wind));
            skills.Add(new Buff("Mild Wind (Ghost)", EffectStatusIDs.PROPERTYTELEKINESIS, Resources._4RTools.Icons.tk_mild_ghost));
            skills.Add(new Buff("Mild Wind (Holy)", EffectStatusIDs.ASPERSIO, Resources._4RTools.Icons.tk_mild_holy));
            skills.Add(new Buff("Mild Wind (Shadow)", EffectStatusIDs.PROPERTYDARK, Resources._4RTools.Icons.tk_mild_shadow));

            return skills;
        }


        public static List<Buff> GetGunsSkills()
        {
            List<Buff> skills = new List<Buff>();

            skills.Add(new Buff("Gatling Fever", EffectStatusIDs.GATLINGFEVER, Resources._4RTools.Icons.gatling_fever));

            return skills;
        }


        //--------------------- STUFFS ------------------------------
        public static List<Buff> GetPotionsBuffs()
        {
            List<Buff> skills = new List<Buff>();

            skills.Add(new Buff("Concentration Potion", EffectStatusIDs.CONCENTRATION_POTION, Resources._4RTools.Icons.concentration_potiongif));
            skills.Add(new Buff("Awakening Potion", EffectStatusIDs.AWAKENING_POTION, Resources._4RTools.Icons.awakening_potion));
            skills.Add(new Buff("Berserk Potion", EffectStatusIDs.BERSERK_POTION, Resources._4RTools.Icons.berserk_potion));
            skills.Add(new Buff("Regeneration Potion", EffectStatusIDs.REGENERATION_POTION, Resources._4RTools.Icons.regeneration));
            skills.Add(new Buff("HP Increase Potion", EffectStatusIDs.HP_INCREASE_POTION_LARGE, Resources._4RTools.Icons.ghp));
            skills.Add(new Buff("SP Increase Potion", EffectStatusIDs.SP_INCREASE_POTION_LARGE, Resources._4RTools.Icons.gsp));
            skills.Add(new Buff("Red Herb Activator", EffectStatusIDs.RED_HERB_ACTIVATOR, Resources._4RTools.Icons.red_herb_activator));
            skills.Add(new Buff("Blue Herb Activator", EffectStatusIDs.BLUE_HERB_ACTIVATOR, Resources._4RTools.Icons.blue_herb_activator));
            skills.Add(new Buff("Golden X", EffectStatusIDs.REF_T_POTION, Resources._4RTools.Icons.Golden_X));

            return skills;
        }

        public static List<Buff> GetElementalsBuffs()
        {
            List<Buff> skills = new List<Buff>();

            skills.Add(new Buff("Fire Conversor", EffectStatusIDs.PROPERTYFIRE, Resources._4RTools.Icons.ele_fire_converter));
            skills.Add(new Buff("Wind Conversor", EffectStatusIDs.PROPERTYWIND, Resources._4RTools.Icons.ele_wind_converter));
            skills.Add(new Buff("Earth Conversor", EffectStatusIDs.PROPERTYGROUND, Resources._4RTools.Icons.ele_earth_converter));
            skills.Add(new Buff("Water Conversor", EffectStatusIDs.PROPERTYWATER, Resources._4RTools.Icons.ele_water_converter));
            skills.Add(new Buff("Cursed Water", EffectStatusIDs.PROPERTYDARK, Resources._4RTools.Icons.cursed_water));
            skills.Add(new Buff("Fireproof Potion", EffectStatusIDs.RESIST_PROPERTY_FIRE, Resources._4RTools.Icons.fireproof));
            skills.Add(new Buff("Waterproof Potion", EffectStatusIDs.RESIST_PROPERTY_WATER, Resources._4RTools.Icons.coldproof));
            skills.Add(new Buff("Windproof Potion", EffectStatusIDs.RESIST_PROPERTY_WIND, Resources._4RTools.Icons.thunderproof));
            skills.Add(new Buff("Earthproof Potion", EffectStatusIDs.RESIST_PROPERTY_GROUND, Resources._4RTools.Icons.earhproof));

            return skills;
        }

        public static List<Buff> GetFoodBuffs()
        {
            List<Buff> skills = new List<Buff>();

            skills.Add(new Buff("STR Food", EffectStatusIDs.FOOD_STR, Resources._4RTools.Icons.strfood));
            skills.Add(new Buff("AGI Food", EffectStatusIDs.FOOD_AGI, Resources._4RTools.Icons.agi_food));
            skills.Add(new Buff("VIT Food", EffectStatusIDs.FOOD_VIT, Resources._4RTools.Icons.vit_food));
            skills.Add(new Buff("INT Food", EffectStatusIDs.FOOD_INT, Resources._4RTools.Icons.int_food));
            skills.Add(new Buff("DEX Food", EffectStatusIDs.FOOD_DEX, Resources._4RTools.Icons.dex_food));
            skills.Add(new Buff("LUK Food", EffectStatusIDs.FOOD_LUK, Resources._4RTools.Icons.luk_food));

            skills.Add(new Buff("3RD STR Food", EffectStatusIDs.STR_3RD_FOOD, Resources._4RTools.Icons.str_3rd_food));
            skills.Add(new Buff("3RD AGI Food", EffectStatusIDs.AGI_3RD_FOOD, Resources._4RTools.Icons.agi_3rd_food));
            skills.Add(new Buff("3RD VIT Food", EffectStatusIDs.VIT_3RD_FOOD, Resources._4RTools.Icons.vit_3rd_food));
            skills.Add(new Buff("3RD INT Food", EffectStatusIDs.INT_3RD_FOOD, Resources._4RTools.Icons.int_3rd_food));
            skills.Add(new Buff("3RD DEX Food", EffectStatusIDs.DEX_3RD_FOOD, Resources._4RTools.Icons.dex_3rd_food));
            skills.Add(new Buff("3RD LUK Food", EffectStatusIDs.LUK_3RD_FOOD, Resources._4RTools.Icons.luk_3rd_food));


            return skills;
        }

        public static List<Buff> GetBoxesBuffs()
        {
            List<Buff> skills = new List<Buff>();

            skills.Add(new Buff("Drowsiness Box", EffectStatusIDs.DROWSINESS_BOX, Resources._4RTools.Icons.drowsiness));
            skills.Add(new Buff("Resentment Box", EffectStatusIDs.RESENTMENT_BOX, Resources._4RTools.Icons.resentment));
            skills.Add(new Buff("Sunlight Box", EffectStatusIDs.SUNLIGHT_BOX, Resources._4RTools.Icons.sunbox));
            skills.Add(new Buff("Box of Gloom", EffectStatusIDs.CONCENTRATION, Resources._4RTools.Icons.gloom));
            skills.Add(new Buff("Box of Thunder", EffectStatusIDs.BOX_OF_THUNDER, Resources._4RTools.Icons.speed));
            skills.Add(new Buff("Speed Potion / Guyak", EffectStatusIDs.SPEED_POT, Resources._4RTools.Icons.speedpotion));
            skills.Add(new Buff("Anodyne", EffectStatusIDs.ENDURE, Resources._4RTools.Icons.anodyne));
            skills.Add(new Buff("Aloevera", EffectStatusIDs.PROVOKE, Resources._4RTools.Icons.aloevera));
            skills.Add(new Buff("Abrasivo", EffectStatusIDs.CRITICALPERCENT, Resources._4RTools.Icons.abrasive));
            skills.Add(new Buff("Combat Pill", EffectStatusIDs.COMBAT_PILL, Resources._4RTools.Icons.combat_pill));
            skills.Add(new Buff("Celermine Juice", EffectStatusIDs.ENRICH_CELERMINE_JUICE, Resources._4RTools.Icons.celermine));

            return skills;
        }

        public static List<Buff> GetScrollBuffs()
        {
            List<Buff> skills = new List<Buff>();

            skills.Add(new Buff("Increase Agility Scroll", EffectStatusIDs.INC_AGI, Resources._4RTools.Icons.al_incagi1));
            skills.Add(new Buff("Bless Scroll", EffectStatusIDs.BLESSING, Resources._4RTools.Icons.al_blessing1));
            skills.Add(new Buff("Full Chemical Protection (Scroll)", EffectStatusIDs.PROTECTARMOR, Resources._4RTools.Icons.cr_fullprotection));

            return skills;
        }

        public static List<Buff> GetETCBuffs()
        {
            List<Buff> skills = new List<Buff>();

            skills.Add(new Buff("THURISAZ Rune", EffectStatusIDs.THURISAZ, Resources._4RTools.Icons.THURISAZ));
            skills.Add(new Buff("OTHILA Rune", EffectStatusIDs.OTHILA, Resources._4RTools.Icons.OTHILA));
            skills.Add(new Buff("HAGALAZ Rune", EffectStatusIDs.HAGALAZ, Resources._4RTools.Icons.HAGALAZ));
            skills.Add(new Buff("LUX AMINA Rune", EffectStatusIDs.LUX_AMINA, Resources._4RTools.Icons.LUX_AMINA));
            skills.Add(new Buff("Cat Can", EffectStatusIDs.OVERLAPEXPUP, Resources._4RTools.Icons.cat_can));
            skills.Add(new Buff("Almighty", EffectStatusIDs.ALMIGHTY, Resources._4RTools.Icons.almighty));
            skills.Add(new Buff("Bubble Gum", EffectStatusIDs.CASH_RECEIVEITEM, Resources._4RTools.Icons.he_bubble_gum));
            skills.Add(new Buff("Battle Manual", EffectStatusIDs.CASH_PLUSEXP, Resources._4RTools.Icons.combat_manual));

            return skills;
        }

    }
}
