using System;
using System.ComponentModel;
using _4RTools.Utils;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Input;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace _4RTools.Model
{

    public class Autopot : Action
    {

        public static string ACTION_NAME_AUTOPOT = "Autopot";
        public static string ACTION_NAME_AUTOPOT_YGG = "AutopotYgg";
        public const string FIRSTHP = "firstHP";
        public const string FIRSTSP = "firstSP";
        public Key hpKey { get; set; }
        public int hpPercent { get; set; }
        public Key spKey { get; set; }
        public int spPercent { get; set; }
        public int delay { get; set; } = 15;
        public int delayYgg { get; set; } = 50;
        public bool stopWitchFC { get; set; } = false;
        public string firstHeal { get; set; } = FIRSTHP;

        public string actionName { get; set; }
        private _4RThread thread;

        public Autopot() { }
        public Autopot(string actionName)
        {
            this.actionName = actionName;
        }

        public Autopot(Key hpKey, int hpPercent, int delay, Key spKey, int spPercent, Key tiKey)
        {
            this.delay = delay;

            // HP
            this.hpKey = hpKey;
            this.hpPercent = hpPercent;

            // SP
            this.spKey = spKey;
            this.spPercent = spPercent;

        }

        public void Start()
        {
            Client roClient = ClientSingleton.GetClient();
            if (roClient != null)
            {
                if (this.thread != null)
                {
                    _4RThread.Stop(this.thread);
                }
                int hpPotCount = 0;
                this.thread = new _4RThread(_ => AutopotThreadExecution(roClient, hpPotCount));
                _4RThread.Start(this.thread);
            }
        }

        private int AutopotThreadExecution(Client roClient, int hpPotCount)
        {
            bool hasCriticalWound = HasCriticalWound(roClient);
            if (firstHeal.Equals(FIRSTHP))
            {
                healHPFirst(roClient, hpPotCount, hasCriticalWound);
            }
            else
            {
                healSPFirst(roClient, hpPotCount, hasCriticalWound);
            }

            Thread.Sleep(this.delay);
            return 0;
        }

        private void healSPFirst(Client roClient, int hpPotCount, bool hasCriticalWound)
        {
            if (roClient.IsSpBelow(spPercent))
            {
                pot(this.spKey);
                hpPotCount++;

                if (hpPotCount == 3 && roClient.IsHpBelow(hpPercent))
                {
                    hpPotCount = 0;
                    if (this.actionName == ACTION_NAME_AUTOPOT_YGG)
                    {
                        pot(this.hpKey);
                    }
                    else if (this.actionName == ACTION_NAME_AUTOPOT && ((!this.stopWitchFC && hasCriticalWound) || !hasCriticalWound))
                    {
                        pot(this.hpKey);
                    }

                }
            }
            // check hp
            if (roClient.IsHpBelow(hpPercent))
            {
                pot(this.hpKey);
            }
        }

        private void healHPFirst(Client roClient, int hpPotCount, bool hasCriticalWound)
        {
            if (roClient.IsHpBelow(hpPercent))
            {
                if (this.actionName == ACTION_NAME_AUTOPOT_YGG)
                {
                    pot(this.hpKey);
                    hpPotCount++;
                }
                else if (this.actionName == ACTION_NAME_AUTOPOT && ((!this.stopWitchFC && hasCriticalWound) || !hasCriticalWound))
                {
                    pot(this.hpKey);
                    hpPotCount++;
                }
                if (hpPotCount == 3 && roClient.IsSpBelow(spPercent))
                {
                    hpPotCount = 0;
                    pot(this.spKey);

                }
            }
            // check sp
            if (roClient.IsSpBelow(spPercent))
            {
                pot(this.spKey);
            }
        }

        private void pot(Key key)
        {
            Keys k = (Keys)Enum.Parse(typeof(Keys), key.ToString());
            if ((k != Keys.None) && !Keyboard.IsKeyDown(Key.LeftAlt) && !Keyboard.IsKeyDown(Key.RightAlt))
            {
                Interop.PostMessage(ClientSingleton.GetClient().process.MainWindowHandle, Constants.WM_KEYDOWN_MSG_ID, k, 0); // keydown
                Interop.PostMessage(ClientSingleton.GetClient().process.MainWindowHandle, Constants.WM_KEYUP_MSG_ID, k, 0); // keyup
            }
        }

        public void Stop()
        {
            _4RThread.Stop(this.thread);
        }

        public string GetConfiguration()
        {
            return JsonConvert.SerializeObject(this);
        }

        public string GetActionName()
        {
            return this.actionName != null ? this.actionName : ACTION_NAME_AUTOPOT;
        }

        public bool HasCriticalWound(Client c)
        {
            for (int i = 1; i < Constants.MAX_BUFF_LIST_INDEX_SIZE; i++)
            {
                uint currentStatus = c.CurrentBuffStatusCode(i);

                if (currentStatus == uint.MaxValue) { continue; }

                EffectStatusIDs status = (EffectStatusIDs)currentStatus;

                if (status == EffectStatusIDs.CRITICALWOUND)
                {
                    return true;
                }
            }
            
            return false;
        }
    }
}
