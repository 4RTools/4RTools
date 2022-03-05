using System;
using System.Configuration;
using System.Xml;

namespace _4RTools.Localization
{
    public sealed class ChangeLanguage
    {
        private static readonly string LANGUAGE = "language";

        private static ChangeLanguage _instance;

        private ChangeLanguage() { }

        public static ChangeLanguage GetInstance()
        {
            if (_instance == null)
            {
                _instance = new ChangeLanguage();
            }
            return _instance;
        }

        public static void UpdateLanguage(string value)
        {
            var xmlDoc = new XmlDocument();
            xmlDoc.Load(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);

            foreach (XmlElement xmlElement in xmlDoc.DocumentElement)
            {
                if (xmlElement.Name.Equals("appSettings"))
                {
                    foreach (XmlNode xNode in xmlElement.ChildNodes)
                    {

                        if (xNode.Attributes[0].Value.Equals(LANGUAGE))
                        {
                            xNode.Attributes[1].Value = value;
                        }
                    }
                }
            }

            ConfigurationManager.RefreshSection("appSettings");
            xmlDoc.Save(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
        }
    }
}
