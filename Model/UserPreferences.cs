using _4RTools.Utils;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Windows.Forms;

namespace _4RTools.Model
{
    public class UserPreferences : Action
    {
        private string ACTION_NAME = "UserPreferences";
        public string toggleStateKey { get; set; } = Keys.End.ToString();
        public string toggleStateHealKey { get; set; } = Keys.End.ToString();

        public List<EffectStatusIDs> autoBuffOrder { get; set; } = new List<EffectStatusIDs>();

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
        public void SetAutoBuffOrder(List<EffectStatusIDs> buffs)
        {
            this.autoBuffOrder = buffs;
        }
    }
}
