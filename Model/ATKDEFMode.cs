using System;
using Newtonsoft.Json;
using _4RTools.Utils;
using System.Threading;
using System.Drawing;
using System.Windows.Input;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;

namespace _4RTools.Model
{
    public enum ATKDEFEnum
    {
        ATK,
        DEF,
    }

    public class EquipConfig
    {
        public int id;
        public int ahkDelay { get; set; } = 10;
        public int switchDelay { get; set; } = 50;
        public Key keySpammer { get; set; }
        public bool keySpammerWithClick { get; set; } = true;
        public Dictionary<string, Key> defKeys { get; set; } = new Dictionary<string, Key>();
        public Dictionary<string, Key> atkKeys { get; set; } = new Dictionary<string, Key>();
        public EquipConfig() { }
            public EquipConfig(int id)
        {
            this.id = id;
            this.defKeys = new Dictionary<string, Key>();
            this.atkKeys = new Dictionary<string, Key>();
        }

        public EquipConfig(EquipConfig macro)
        {
            this.id = macro.id;
            this.ahkDelay = macro.ahkDelay;
            this.switchDelay = macro.switchDelay;
            this.keySpammer = macro.keySpammer;
            this.keySpammerWithClick = macro.keySpammerWithClick;
            this.defKeys = new Dictionary<string, Key>(macro.defKeys);
            this.atkKeys = new Dictionary<string, Key>(macro.atkKeys);

        }
        public EquipConfig(int id, Key trigger)
        {
            this.id = id;
            this.keySpammer = trigger;
            this.defKeys = new Dictionary<string, Key>();
            this.atkKeys = new Dictionary<string, Key>();
        }
    }

    public class ATKDEFMode : Action
    {
        public static string ACTION_NAME_ATKDEF = "ATKDEFMode";
        private _4RThread thread;
        public List<EquipConfig> equipConfigs { get; set; } = new List<EquipConfig>();

        public ATKDEFMode(int macroLanes)
        {
            for (int i = 1; i <= macroLanes; i++)
            {
                equipConfigs.Add(new EquipConfig(i, Key.None));

            }
        }

        public string GetActionName()
        {
            return ACTION_NAME_ATKDEF;
        }

        public string GetConfiguration()
        {
            return JsonConvert.SerializeObject(this);
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
                this.thread = new _4RThread(_ => AHKThreadExecution(roClient));
                _4RThread.Start(this.thread);
            }
        }

        private int AHKThreadExecution(Client roClient)
        {

            foreach (EquipConfig equipConfig in this.equipConfigs)
            {
                if (equipConfig.keySpammer != Key.None && Keyboard.IsKeyDown(equipConfig.keySpammer))
                {
                    Keys thisk = toKeys(equipConfig.keySpammer);
                    bool equipAtkItems = false;
                    while (Keyboard.IsKeyDown(equipConfig.keySpammer))
                    {
                        if (!equipAtkItems)
                        {
                            foreach (Key key in equipConfig.atkKeys.Values)
                            {
                                Interop.PostMessage(roClient.process.MainWindowHandle, Constants.WM_KEYDOWN_MSG_ID, toKeys(key), 0); //Equip ATK Items
                                Thread.Sleep(equipConfig.switchDelay);
                            }
                        }

                        if (equipConfig.keySpammerWithClick)
                        {
                            Interop.PostMessage(roClient.process.MainWindowHandle, Constants.WM_KEYDOWN_MSG_ID, thisk, 0);
                            Interop.PostMessage(roClient.process.MainWindowHandle, Constants.WM_LBUTTONDOWN, 0, 0);
                            Thread.Sleep(1);
                            Interop.PostMessage(roClient.process.MainWindowHandle, Constants.WM_LBUTTONUP, 0, 0);
                            Thread.Sleep(equipConfig.ahkDelay);
                        }
                        else
                        {
                            Interop.PostMessage(roClient.process.MainWindowHandle, Constants.WM_KEYDOWN_MSG_ID, thisk, 0);
                            Thread.Sleep(equipConfig.ahkDelay);
                        }
                    }
                    foreach (Key key in equipConfig.defKeys.Values)
                    {
                        Interop.PostMessage(roClient.process.MainWindowHandle, Constants.WM_KEYDOWN_MSG_ID, toKeys(key), 0); //Equip DEF Items
                        Thread.Sleep(equipConfig.switchDelay);
                    }
                }
            }
            return 0;
        }

        public void AddSwitchItem(int id, string dictKey, Key k, string type)
        {
            var equips = equipConfigs.FirstOrDefault(x => x.id == id);

            Dictionary<string, Key> copy = type == "DEF" ? equips.defKeys : equips.atkKeys;

            if (copy.ContainsKey(dictKey))
            {
                RemoveSwitchEntry(id, dictKey, type);
            }

            if (k != Key.None)
            {
                copy.Add(dictKey, k);
            }

        }

        public void RemoveSwitchEntry(int id, string dictKey, string type)
        {
            var equips = equipConfigs.FirstOrDefault(x => x.id == id);
            Dictionary<string, Key> copy = type == "DEF" ? equips.defKeys : equips.atkKeys;
            copy.Remove(dictKey);
        }

        private Keys toKeys(Key k)
        {
            return (Keys)Enum.Parse(typeof(Keys), k.ToString());
        }

        public void Stop()
        {
            _4RThread.Stop(this.thread);
        }
    }
}
