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
        private _4RThread thread;
        public int delay { get; set; } = 1;
        private int maxBuffListIndexSize { get; set; } = 100;
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
                        this.thread = RestoreStatusThread(roClient);
                        break;
                    case "ItemsAutoBuff":
                    case "SkillAutoBuff":
                        this.thread = AutoBuffThread(roClient);
                        break;
                         
                }
                _4RThread.Start(this.thread);
            }
        }

        public _4RThread RestoreStatusThread(Client c)
        {
            Client roClient = ClientSingleton.GetClient();
            _4RThread statusEffectsThread = new _4RThread(_ =>
            {
                for (int i = 1; i <= this.maxBuffListIndexSize -1; i++)
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
                return 0;
            });

            return statusEffectsThread;
        }

        public _4RThread AutoBuffThread(Client c)
        {
            _4RThread autobuffItemThread = new _4RThread(_ =>
            {
                bool foundQuag = false;
                Dictionary<EffectStatusIDs, Key> bmClone = new Dictionary<EffectStatusIDs, Key>(this.buffMapping);
                for (int i = 1; i < this.maxBuffListIndexSize - 1; i++)
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
                    if (foundQuag && (item.Key == EffectStatusIDs.CONCENTRATION || item.Key == EffectStatusIDs.INC_AGI || item.Key == EffectStatusIDs.TRUESIGHT ))
                    {
                        //NOT use Concentration, INC_AGI Scroll or TRUESIGHT when Quagmire is Found
                        // In Hercules, Quagmire removes TRUESIGHT
                    }
                    else 
                    {
                        if (c.ReadCurrentHp() >= Constants.MINIMUM_HP_TO_RECOVER)
                        {
                            this.useStatusRecovery(item.Value);
                            Thread.Sleep(10);
                        }
                    }
                }
                Thread.Sleep(100);
                return 0;
            });

            return autobuffItemThread;
        }

        public void AddKeyToBuff(EffectStatusIDs status, Key key)
        {
            if (buffMapping.ContainsKey(status))
            {
                buffMapping.Remove(status);
            }

            if (this.IsValidKey(key))
            {
                buffMapping.Add(status, key);
            }
        }
        public void ClearKeyMapping()
        {
            buffMapping.Clear();
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
            return this.actionName;
        }

        private void useStatusRecovery(Key key)
        {
            if((key != Key.None) && !Keyboard.IsKeyDown(Key.LeftAlt) && !Keyboard.IsKeyDown(Key.RightAlt))
                Interop.PostMessage(ClientSingleton.GetClient().process.MainWindowHandle, Constants.WM_KEYDOWN_MSG_ID, (Keys)Enum.Parse(typeof(Keys), key.ToString()), 0);
        }

        private bool IsValidKey(Key key)
        {
            return (key != Key.Back && key != Key.Escape && key != Key.None);
        }
    }
}
