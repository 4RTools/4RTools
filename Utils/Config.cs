using System;


namespace _4RTools.Utils
{
    internal class Config
    {
        public static string ReadSetting(string key)
        {
            try
            {
                string appSettings = System.Configuration.ConfigurationSettings.AppSettings[key];
                string result = appSettings ?? "Not Found";
                return result;
            }
            catch (Exception ex)
            {
                return " - ";
            }
        }
    }
}
