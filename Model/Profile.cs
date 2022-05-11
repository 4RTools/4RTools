using System.Collections.Generic;
using Newtonsoft.Json;
using _4RTools.Utils;
using _4RTools.Forms;
using System.IO;
using System;

namespace _4RTools.Model
{
    public class ProfileSingleton
    {
        private static Profile profile;

        public static void Load(string profileName)
        {
            try
            {
                string jsonFileName = Config.ReadSetting("ProfileFolder") + profileName + ".json";
                string json = File.ReadAllText(jsonFileName);
                dynamic rawObject = JsonConvert.DeserializeObject(json);

                Profile profile = new Profile(profileName);

                if ((rawObject != null))
                {
                    profile.UserPreferences = JsonConvert.DeserializeObject<UserPreferences>(Profile.GetByAction(rawObject, new UserPreferences()));
                    profile.AHK = JsonConvert.DeserializeObject<AHK>(Profile.GetByAction(rawObject, new AHK()));
                    profile.Autopot = JsonConvert.DeserializeObject<Autopot>(Profile.GetByAction(rawObject, new Autopot(Autopot.ACTION_NAME_AUTOPOT)));
                    profile.AutopotYgg = JsonConvert.DeserializeObject<Autopot>(Profile.GetByAction(rawObject, new Autopot(Autopot.ACTION_NAME_AUTOPOT_YGG)));
                    profile.StatusAutoBuff = JsonConvert.DeserializeObject<AutoBuff>(Profile.GetByAction(rawObject, new AutoBuff(AutoBuff.ACTION_NAME_STATUS_AUTOBUFF)));
                    profile.AutoRefreshSpammer = JsonConvert.DeserializeObject<AutoRefreshSpammer>(Profile.GetByAction(rawObject, new AutoRefreshSpammer()));
                    profile.ItemsAutoBuff = JsonConvert.DeserializeObject<AutoBuff>(Profile.GetByAction(rawObject, new AutoBuff(AutoBuff.ACTION_NAME_ITEM_AUTOBUFF)));
                    profile.SkillAutoBuff = JsonConvert.DeserializeObject<AutoBuff>(Profile.GetByAction(rawObject, new AutoBuff(AutoBuff.ACTION_NAME_SKILL_AUTOBUFF)));
                    profile.SongMacro = JsonConvert.DeserializeObject<Macro>(Profile.GetByAction(rawObject, new Macro(Macro.ACTION_NAME_SONG_MACRO, MacroSongForm.TOTAL_MACRO_LANES_FOR_SONGS)));
                    profile.AtkDefMode = JsonConvert.DeserializeObject<ATKDEFMode>(Profile.GetByAction(rawObject, new ATKDEFMode()));
                }
                ProfileSingleton.profile = profile;
            }
            catch (Exception e) {
                throw new Exception("Houve um problema ao carregar o perfil. Delete a pasta Profiles e tente novamente.");   
            }
        }

        public static void SetConfiguration(Action action)
        {
            if(profile != null)
            {
                string jsonFileName = Config.ReadSetting("ProfileFolder") + profile.Name + ".json";
                string json = File.ReadAllText(jsonFileName);
                dynamic jsonObj = JsonConvert.DeserializeObject(json);
                jsonObj[action.GetActionName()] = action.GetConfiguration();
                string output = JsonConvert.SerializeObject(jsonObj, Formatting.Indented);
                File.WriteAllText(jsonFileName, output);
            }
        }

        public static Profile GetCurrent()
        {
            return profile;
        }

    }

    public class Profile
    {
        public string Name { get; set; }
        public UserPreferences UserPreferences { get; set; }
        public AHK AHK { get; set; }
        public Autopot Autopot { get; set; }
        public Autopot AutopotYgg { get; set; }
        public AutoRefreshSpammer AutoRefreshSpammer { get; set; }
        public AutoBuff StatusAutoBuff { get; set; }
        public AutoBuff ItemsAutoBuff { get; set; }
        public AutoBuff SkillAutoBuff { get; set; }
        public Macro SongMacro { get; set;}

        public ATKDEFMode AtkDefMode { get; set; }

        public Profile(string name)
        {
            this.Name = name;

            this.UserPreferences = new UserPreferences();
            this.AHK = new AHK(); 
            this.Autopot = new Autopot(Autopot.ACTION_NAME_AUTOPOT);
            this.AutopotYgg = new Autopot(Autopot.ACTION_NAME_AUTOPOT_YGG);
            this.AutoRefreshSpammer = new AutoRefreshSpammer();
            this.StatusAutoBuff = new AutoBuff(AutoBuff.ACTION_NAME_STATUS_AUTOBUFF);
            this.ItemsAutoBuff = new AutoBuff(AutoBuff.ACTION_NAME_ITEM_AUTOBUFF);
            this.SkillAutoBuff = new AutoBuff(AutoBuff.ACTION_NAME_SKILL_AUTOBUFF);
            this.SongMacro = new Macro(Macro.ACTION_NAME_SONG_MACRO,MacroSongForm.TOTAL_MACRO_LANES_FOR_SONGS);
            this.AtkDefMode = new ATKDEFMode();
        }

        public static object GetByAction(dynamic obj, Action action)
        {
           if(obj != null && obj[action.GetActionName()] != null) {
                return obj[action.GetActionName()].ToString();
           }

            return action.GetConfiguration();
        }

    public static List<string> ListAll()
        {
            List<string> profiles = new List<string>();
            try
            {
                string[] files =  Directory.GetFiles(Config.ReadSetting("ProfileFolder"));
                
                foreach(string fileName in files)
                {
                    string[] len = fileName.Split('\\');
                    string profileName = len[len.Length - 1].Split('.')[0];
                    profiles.Add(profileName);
                }
            }
            catch { }
            return profiles;
        }

        public void Save()
        {
            FileStream fs = File.Create(Config.ReadSetting("ProfileFolder") + "\\" +this.Name+".json");
            fs.Close();

            string output = JsonConvert.SerializeObject(this, Formatting.Indented);
            File.WriteAllText(Config.ReadSetting("ProfileFolder") + "\\" + this.Name+".json", output);

            ProfileSingleton.Load(this.Name);
        }

        public static void RemoveProfile(string profileName)
        {
            try
            {
                File.Delete(Config.ReadSetting("ProfileFolder") + "\\" + profileName + ".json");

                if(!ProfileExists("Default")) {
                    new Profile("Default").Save();
                }
                
            }catch { }
        }

        public static bool ProfileExists(string profileName)
        {
            try
            {
                return File.Exists(Config.ReadSetting("ProfileFolder") + "\\" +profileName+".json");
            }
            catch { return false; }
        }
    }

}
