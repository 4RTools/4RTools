using System;
using Newtonsoft.Json;
using _4RTools.Utils;
using System.Threading;
using System.Drawing;
using System.Windows.Input;
using System.Collections.Generic;
using System.Windows.Forms;

namespace _4RTools.Model
{
    public enum  ATKDEFEnum
    {
        ATK = 0,
        DEF = 1,
    }
    public class ATKDEFMode : Action
    {
        public static string ACTION_NAME_ATKDEF = "ATKDEFMode";
        private _4RThread thread;
        public int ahkDelay { get; set; } = 10;
        public int switchDelay { get; set; } = 50;
        public Key keySpammer { get; set; }
        public bool keySpammerWithClick { get; set; } = true;
        public Dictionary<string,Key> defKeys { get; set; } = new Dictionary<string,Key>();
        public Dictionary<string,Key> atkKeys { get; set; } = new Dictionary<string, Key>();
        private int PX_MOV = Constants.MOUSE_DIAGONAL_MOVIMENTATION_PIXELS_AHK;

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
                this.thread = new _4RThread(_ => AHKThreadExecution(roClient));
                _4RThread.Start(this.thread);
            }
        }

        private int AHKThreadExecution(Client roClient)
        {
            Keys thisk = toKeys(keySpammer);
            if (this.keySpammer != Key.None && Keyboard.IsKeyDown(this.keySpammer))
            {
                foreach (Key key in atkKeys.Values)
                {
                    Interop.PostMessage(roClient.process.MainWindowHandle, Constants.WM_KEYDOWN_MSG_ID, toKeys(key), 0); //Equip ATK Items
                    Thread.Sleep(this.switchDelay);
                }

                if (this.keySpammerWithClick)
                {
                    while (Keyboard.IsKeyDown(keySpammer))
                    {

                        Interop.PostMessage(roClient.process.MainWindowHandle, Constants.WM_KEYDOWN_MSG_ID, thisk, 0);
                        Interop.PostMessage(roClient.process.MainWindowHandle, Constants.WM_LBUTTONDOWN, 0, 0);
                        Thread.Sleep(1);
                        Interop.PostMessage(roClient.process.MainWindowHandle, Constants.WM_LBUTTONUP, 0, 0);
                        Thread.Sleep(this.ahkDelay);
                    }
                }
                else
                {
                    while (Keyboard.IsKeyDown(keySpammer))
                    {
                        Interop.PostMessage(roClient.process.MainWindowHandle, Constants.WM_KEYDOWN_MSG_ID, thisk, 0);
                        Thread.Sleep(this.ahkDelay);
                    }
                }

                foreach (Key key in defKeys.Values)
                {
                    Interop.PostMessage(roClient.process.MainWindowHandle, Constants.WM_KEYDOWN_MSG_ID, toKeys(key), 0); //Equip DEF Items
                    Thread.Sleep(this.switchDelay);
                }
            }
            return 0;
        }

        public void AddSwitchItem(string dictKey,Key k, ATKDEFEnum type)
        {
            Dictionary<string, Key> copy = type == ATKDEFEnum.DEF ? this.defKeys : this.atkKeys;

            if (copy.ContainsKey(dictKey))
            {
                RemoveSwitchEntry(dictKey, type);
            }

            if(k != Key.None)
            {
                copy.Add(dictKey, k);
            }
            
        }

        public void RemoveSwitchEntry(string dictKey, ATKDEFEnum type)
        {
            Dictionary<string, Key> copy = type == ATKDEFEnum.DEF ? this.defKeys : this.atkKeys;
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
