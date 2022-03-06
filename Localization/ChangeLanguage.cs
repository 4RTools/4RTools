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

        /// <summary>
        /// Method to update language
        /// </summary>
        /// <param name="value">New language to be set</param>
        /// <returns>If value was updated. If current value is equal to new value, the response will be false.</returns>
        public static bool UpdateLanguage(string value)
        {
            var valueUpdated = false;
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
                            var currentValue = xNode.Attributes[1].Value;
                            if(currentValue != value)
                            {
                                xNode.Attributes[1].Value = value;
                                valueUpdated = true;
                            }
                            
                        }
                    }
                }
            }

            if(valueUpdated)
            {
                ConfigurationManager.RefreshSection("appSettings");
                xmlDoc.Save(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
            }

            return valueUpdated;
        }
    }
}
