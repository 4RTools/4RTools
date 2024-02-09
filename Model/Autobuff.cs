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
        public static string ACTION_NAME_AUTOBUFF = "Autobuff";

        private _4RThread thread;
        public int delay { get; set; } = 1;
        public Dictionary<EffectStatusIDs, Key> buffMapping = new Dictionary<EffectStatusIDs, Key>();

        public void Start()
        {
            Stop();
            Client roClient = ClientSingleton.GetClient();
            if (roClient != null)
            {
                 this.thread = AutoBuffThread(roClient);
                _4RThread.Start(this.thread);
            }
        }

        public _4RThread AutoBuffThread(Client c)
        {
            _4RThread autobuffItemThread = new _4RThread(_ =>
            {
                bool foundQuag = false;
                bool foundDecreaseAgi = false;
                List<uint> buffs = new List<uint>();
                Dictionary<EffectStatusIDs, Key> bmClone = new Dictionary<EffectStatusIDs, Key>(this.buffMapping);
                for (int i = 1; i < Constants.MAX_BUFF_LIST_INDEX_SIZE; i++)
                {
                    uint currentStatus = c.CurrentBuffStatusCode(i);

                    if(currentStatus == 4294967295)
                    {
                        continue;
                    }

                    buffs.Add(currentStatus);
                    EffectStatusIDs status = (EffectStatusIDs)currentStatus;

                    if (status == EffectStatusIDs.OVERTHRUSTMAX)
                    {
                        if (buffMapping.ContainsKey(EffectStatusIDs.OVERTHRUST))
                        {
                            bmClone.Remove(EffectStatusIDs.OVERTHRUST);
                        }
                    }
                    if (bmClone.ContainsKey(EffectStatusIDs.EDEN))
                    {
                        bmClone.Remove(EffectStatusIDs.EDEN);
                    }



                    if (buffMapping.ContainsKey(status)) //CHECK IF STATUS EXISTS IN STATUS LIST AND DO ACTION
                    {
                        bmClone.Remove(status);
                    }

                    if (status == EffectStatusIDs.QUAGMIRE) foundQuag = true;
                    if (status == EffectStatusIDs.DECREASE_AGI) foundDecreaseAgi = true;
              }
                buffs.Clear();
                foreach (var item in bmClone)
                {
                    if (foundQuag && (item.Key == EffectStatusIDs.CONCENTRATION || item.Key == EffectStatusIDs.INC_AGI || item.Key == EffectStatusIDs.TRUESIGHT || item.Key == EffectStatusIDs.ADRENALINE || item.Key == EffectStatusIDs.SPEARQUICKEN))
                    {
                        break;
                    }
                    else if (foundDecreaseAgi && (item.Key == EffectStatusIDs.TWOHANDQUICKEN || item.Key == EffectStatusIDs.ADRENALINE || item.Key == EffectStatusIDs.ADRENALINE2 || item.Key == EffectStatusIDs.ONEHANDQUICKEN || item.Key == EffectStatusIDs.SPEARQUICKEN))
                    {
                      break;
                    }
                    else if (c.ReadCurrentHp() >= Constants.MINIMUM_HP_TO_RECOVER)
                    {
                        this.useAutobuff(item.Value);
                        Thread.Sleep(10);
                    }
                }
                Thread.Sleep(300);
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

            if (FormUtils.IsValidKey(key))
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
            return ACTION_NAME_AUTOBUFF;
        }

        private void useAutobuff(Key key)
        {
            if((key != Key.None) && !Keyboard.IsKeyDown(Key.LeftAlt) && !Keyboard.IsKeyDown(Key.RightAlt))
                Interop.PostMessage(ClientSingleton.GetClient().process.MainWindowHandle, Constants.WM_KEYDOWN_MSG_ID, (Keys)Enum.Parse(typeof(Keys), key.ToString()), 0);
        }
    }
}
