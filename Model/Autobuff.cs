using System;
using System.Threading;
using System.Windows.Input;
using System.Windows.Forms;
using System.Collections.Generic;
using Newtonsoft.Json;
using _4RTools.Utils;

namespace _4RTools.Model
{

    public class AutoBuff : Action
    {
        public string actionName { get; set; }
        private Thread autobuffThread;
        public int delay { get; set; } = 1;
        private int maxBuffListIndexSize { get; set; } = 40;
        public Dictionary<EffectStatusIDs, Key> buffMapping = new Dictionary<EffectStatusIDs, Key>();

        public AutoBuff(string actionName)
        {
            this.actionName = actionName;
        }

        public void Start()
        {
            Stop();
            Client roClient = ClientSingleton.GetClient();
            if (roClient != null)
            {
                switch (this.actionName)
                {
                    case "StatusAutoBuff":
                        this.autobuffThread = RestoreStatusThread(roClient);
                        break;
                    case "ItemsAutoBuff":
                        this.autobuffThread = AutoBuffThread(roClient);
                        break;
                         
                }
                
                autobuffThread.SetApartmentState(ApartmentState.STA);
                autobuffThread.Start();
            }
        }

        public Thread RestoreStatusThread(Client c)
        {
            Client roClient = ClientSingleton.GetClient();
            Thread statusEffectsThread = new Thread(() =>
            {
                while (true)
                {
                    for (int i = 0; i <= this.maxBuffListIndexSize; i++)
                    {
                        uint currentStatus = c.CurrentBuffStatusCode(i);
                        EffectStatusIDs status = (EffectStatusIDs)currentStatus;
                        if (buffMapping.ContainsKey((EffectStatusIDs)currentStatus)) //IF FOR REMOVE STATUS - CHECK IF STATUS EXISTS IN STATUS LIST AND DO ACTION
                        {
                            //IF CONTAINS CURRENT STATUS ON DICT
                            Key key = buffMapping[(EffectStatusIDs)currentStatus];
                            if (Enum.IsDefined(typeof(EffectStatusIDs), currentStatus))
                            {
                                this.useStatusRecovery(key);
                            }
                        }
                    }
                    Thread.Sleep(this.delay);
                }
            });
            return statusEffectsThread;
        }

        public Thread AutoBuffThread(Client c)
        {
            Thread autobuffItemThread = new Thread(() =>
            {
                while (true)
                {
                    bool foundQuag = false;
                    Dictionary<EffectStatusIDs, Key> bmClone = new Dictionary<EffectStatusIDs, Key>(this.buffMapping);
                    for (int i = 0; i <= this.maxBuffListIndexSize; i++)
                    {
                        uint currentStatus = c.CurrentBuffStatusCode(i);
                        EffectStatusIDs status = (EffectStatusIDs)currentStatus;
                        if (buffMapping.ContainsKey(status)) //CHECK IF STATUS EXISTS IN STATUS LIST AND DO ACTION
                        {
                            bmClone.Remove(status);
                        }

                        if(status == EffectStatusIDs.QUAGMIRE) foundQuag = true;

                    }
                    foreach (var item in bmClone)
                    {
                        if (foundQuag && (item.Key == EffectStatusIDs.CONCENTRATION || item.Key == EffectStatusIDs.INC_AGI))
                        {
                            //NOT use Concentration neither INC_AGI Scroll when Quagmire is Found
                        }
                        else
                        {
                            this.useStatusRecovery(item.Value);
                        }
                    }

                    Thread.Sleep(this.delay);
                }
            });
            return autobuffItemThread;
        }

        public void AddKeyToBuff(EffectStatusIDs status, Key key)
        {
            if (buffMapping.ContainsKey(status))
            {
               this.RemoveKey(status);
            }
            buffMapping.Add(status, key);
        }

        public void RemoveKey(EffectStatusIDs status)
        {
            buffMapping.Remove(status);
        }

        public void ClearKeyMapping()
        {
            buffMapping.Clear();
        }

        public void Stop()
        {
            if (this.autobuffThread != null && this.autobuffThread.IsAlive)
            {
                this.autobuffThread.Abort();
            }
        }

        public string GetConfiguration()
        {
            return JsonConvert.SerializeObject(this);
        }

        public string GetActionName()
        {
            return this.actionName;
        }

        private void useStatusRecovery(Key key)
        {
            if(key != Key.None)
                Interop.PostMessage(ClientSingleton.GetClient().process.MainWindowHandle, Constants.WM_KEYDOWN_MSG_ID, (Keys)Enum.Parse(typeof(Keys), key.ToString()), 0);
        }
    }
}
