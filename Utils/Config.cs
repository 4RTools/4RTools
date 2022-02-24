using System;
using System.Collections.Generic;

namespace _4RTools.Utils
{
    internal class Config
    {
        private static Dictionary<string, string> configs = new Dictionary<string, string>();

        public static void Load()
        {
            configs.Add("Name", "4RTools");
            configs.Add("ProfileFolder", "Profile\\");
            configs.Add("GithubLink", "https://github.com/4RTools/4Rtools");
            configs.Add("DiscordLink", "https://discord.gg/AtZ2fJVtBz");
            configs.Add("Version", "1.0.0");
        }

        public static string ReadSetting(string key)
        {
            try
            {
                string appSettings = configs[key];
                string result = appSettings ?? "Not Found";
                return result;
            }
            catch (Exception)
            {
                return " - ";
            }
        }
    }
}
