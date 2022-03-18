using Newtonsoft.Json;
using System.Windows.Forms;

namespace _4RTools.Model
{
    public class UserPreferences : Action
    {
        private string ACTION_NAME = "UserPreferences";
        public string toggleStateKey { get; set; } = Keys.End.ToString();

        public UserPreferences()
        {
        }

        public void Start() { }

        public void Stop() { }

        public string GetConfiguration()
        {
            return JsonConvert.SerializeObject(this);
        }

        public string GetActionName()
        {
            return ACTION_NAME;
        }
    }
}
