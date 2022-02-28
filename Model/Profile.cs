using System.Collections.Generic;
using Newtonsoft.Json;
using _4RTools.Utils;
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

                if ((rawObject != null)) {
                    profile.AHK = JsonConvert.DeserializeObject<AHK>(Profile.GetByProperty(rawObject, "AHK", new AHK().GetConfiguration()));
                    profile.Autopot = JsonConvert.DeserializeObject<Autopot>(Profile.GetByProperty(rawObject, "Autopot", new Autopot().GetConfiguration()));
                    profile.StatusAutoBuff = JsonConvert.DeserializeObject<AutoBuff>(Profile.GetByProperty(rawObject, "StatusAutoBuff", new AutoBuff("StatusAutoBuff").GetConfiguration()));
                    profile.AutoRefreshSpammer = JsonConvert.DeserializeObject<AutoRefreshSpammer>(Profile.GetByProperty(rawObject, "AutoRefreshSpammer", new AutoRefreshSpammer().GetConfiguration()));
                    profile.ItemsAutoBuff = JsonConvert.DeserializeObject<AutoBuff>(Profile.GetByProperty(rawObject, "ItemsAutoBuff", new AutoBuff("ItemsAutoBuff").GetConfiguration()));
                }


                ProfileSingleton.profile = profile;
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error while loading profile "+ ex.Message);
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
        public AHK AHK { get; set; }
        public Autopot Autopot { get; set; }
        public AutoRefreshSpammer AutoRefreshSpammer { get; set; }
        public AutoBuff StatusAutoBuff { get; set; }
        public AutoBuff ItemsAutoBuff { get; set; }

        public Profile(string name)
        {
            this.Name = name;

            this.AHK = new AHK(); 
            this.Autopot = new Autopot();
            this.AutoRefreshSpammer = new AutoRefreshSpammer();
            this.StatusAutoBuff = new AutoBuff("StatusAutoBuff");
            this.ItemsAutoBuff = new AutoBuff("ItemsAutoBuff");
        }

        public static object GetByProperty(dynamic obj, string property, object fallback)
        {
           if(obj != null && obj[property] != null) {
                return obj[property].ToString();
           }

            return fallback;
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
