using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Threading;
using System.Windows.Input;
using System.Drawing;
using _4RTools.Utils;
using Newtonsoft.Json;
using System.Runtime.InteropServices;

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
        // Import the mouse_event function from the Windows API
        [DllImport("user32.dll")]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint dwData, int dwExtraInfo);

        public Dictionary<string,KeyConfig> ahkEntries { get; set; } = new Dictionary<string, KeyConfig>();
        private string ACTION_NAME = "AHK20";
        public int ahkDelay { get; set; } = 10;

        private _4RThread thread;


        public AHK()
        {
        }

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
                if (!Keyboard.IsKeyDown(Key.LeftAlt) && !Keyboard.IsKeyDown(Key.RightAlt))
                {
                    if (config.clickActive && Keyboard.IsKeyDown(config.key))
                    {
                        while (Keyboard.IsKeyDown(config.key))
                        {
                            Point cursorPos = System.Windows.Forms.Cursor.Position;
                            Interop.PostMessage(roClient.process.MainWindowHandle, Constants.WM_KEYDOWN_MSG_ID, thisk, 0);
                            mouse_event(Constants.MOUSEEVENTF_LEFTDOWN, (uint)cursorPos.X, (uint)cursorPos.Y, 0, 0);
                            Thread.Sleep(1);
                            mouse_event(Constants.MOUSEEVENTF_LEFTUP, (uint)cursorPos.X, (uint)cursorPos.Y, 0, 0);
                            Thread.Sleep(this.ahkDelay);
                        }
                    }
                    else
                    {
                        while (Keyboard.IsKeyDown(config.key))
                        {
                            Interop.PostMessage(roClient.process.MainWindowHandle, Constants.WM_KEYDOWN_MSG_ID, thisk, 0);
                            Thread.Sleep(this.ahkDelay);
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
