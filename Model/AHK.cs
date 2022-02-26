using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Threading;
using System.Windows.Input;
using _4RTools.Utils;
using Newtonsoft.Json;


namespace _4RTools.Model
{

    public class AHK : Action
    {
        public Dictionary<string,Key> ahkEntries { get; set; } = new Dictionary<string, Key>();
        private string ACTION_NAME = "AHK";
        public int ahkDelay { get; set; }
        private Thread ahkThread;

        public void Start()
        {
            Stop();
            Client roClient = ClientSingleton.GetClient();
            if(roClient != null)
            {
                Thread ahkThread = new Thread(() => {
                    if (this.ahkDelay <= 0) this.ahkDelay = 1;

                    while (true)
                    {
                        try
                        {
                            foreach (Key key in ahkEntries.Values)
                            {
                                while (Keyboard.IsKeyDown(key))
                                {
                                    Keys thisk = (Keys)Enum.Parse(typeof(Keys), key.ToString());
                                    Interop.PostMessage(roClient.process.MainWindowHandle, Constants.WM_KEYDOWN_MSG_ID, thisk, 0);
                                    Interop.PostMessage(roClient.process.MainWindowHandle, Constants.WM_LBUTTONDOWN, 0, 0);
                                    Thread.Sleep(1);
                                    Interop.PostMessage(roClient.process.MainWindowHandle, Constants.WM_LBUTTONUP, 0, 0);
                                    Thread.Sleep(ahkDelay);
                                }
                            }
                        }
                        catch { }
                        Thread.Sleep(ahkDelay);
                    }
                });

                this.ahkThread = ahkThread;
                ahkThread.SetApartmentState(ApartmentState.STA);
                ahkThread.Start();
            }
        }
        
        public void AddAHKEntry(string chkboxName,Key value)
        {
            if (!this.ahkEntries.ContainsKey(chkboxName)) {
                this.ahkEntries.Add(chkboxName, value);
            }
               
        }

        public void RemoveAHKEntry(string chkboxName)
        {
            this.ahkEntries.Remove(chkboxName);
        }

        public void Stop()
        {
            if(this.ahkThread != null && this.ahkThread.IsAlive)
            {
                this.ahkThread.Abort();
            }
        }

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
