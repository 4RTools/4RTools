using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Threading;
using System.Windows.Input;
using _4RTools.Utils;
using Newtonsoft.Json;


namespace _4RTools.Model
{

    public class KeyConfig {

        public Key key { get; set; }
        public bool clickActive { get; set; }

        public KeyConfig(Key key, bool clickAtive) {
            this.key = key;
            this.clickActive = clickAtive;
        }

    }

    public class AHK : Action
    {
        public Dictionary<string,KeyConfig> ahkEntries { get; set; } = new Dictionary<string, KeyConfig>();
        private string ACTION_NAME = "AHK20";
        public int ahkDelay { get; set; } = 10;
        public bool mouseFlick { get; set; } = false;
        private _4RThread thread;

        public AHK() { }

        public void Start()
        {
            Client roClient = ClientSingleton.GetClient();
            if(roClient != null)
            {
                if (this.ahkDelay <= 0) this.ahkDelay = 1; //TODO -> This is really necessary? NumberInput already do this for us.
                this.thread = new _4RThread(_ => AHKThreadExecution(roClient));
                _4RThread.Start(this.thread);
            }
        }

        private int AHKThreadExecution(Client roClient)
        {
            foreach (KeyConfig config in ahkEntries.Values)
            {
                Keys thisk = (Keys)Enum.Parse(typeof(Keys), config.key.ToString());
                while (Keyboard.IsKeyDown(config.key))
                {
                    if (!Keyboard.IsKeyDown(Key.LeftAlt) && !Keyboard.IsKeyDown(Key.RightAlt))
                    {
                        if (config.clickActive)
                        {
                            if (mouseFlick) System.Windows.Forms.Cursor.Position = new System.Drawing.Point(System.Windows.Forms.Cursor.Position.X - 1, System.Windows.Forms.Cursor.Position.Y - 1);
                            Interop.PostMessage(roClient.process.MainWindowHandle, Constants.WM_KEYDOWN_MSG_ID, thisk, 0);
                            Interop.PostMessage(roClient.process.MainWindowHandle, Constants.WM_LBUTTONDOWN, 0, 0);
                            Thread.Sleep(1);
                            Interop.PostMessage(roClient.process.MainWindowHandle, Constants.WM_LBUTTONUP, 0, 0);
                            if (mouseFlick) System.Windows.Forms.Cursor.Position = new System.Drawing.Point(System.Windows.Forms.Cursor.Position.X + 1, System.Windows.Forms.Cursor.Position.Y + 1);
                        }
                        else
                        {
                            Interop.PostMessage(roClient.process.MainWindowHandle, Constants.WM_KEYDOWN_MSG_ID, thisk, 0);
                        }
                    }

                    Thread.Sleep(this.ahkDelay);
                }
            }
            return 0;
        }
        

        public void AddAHKEntry(string chkboxName,KeyConfig value)
        {
            if (this.ahkEntries.ContainsKey(chkboxName)) {
                RemoveAHKEntry(chkboxName);
            }

            this.ahkEntries.Add(chkboxName, value);
               
        }

        public void RemoveAHKEntry(string chkboxName)
        {
            this.ahkEntries.Remove(chkboxName);
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
            return this.ACTION_NAME;
        }

    }
}
