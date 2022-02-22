using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Threading;
using System.Windows.Input;
using _4RTools.Utils;


namespace _4RTools.Model
{

    internal class AHK : Action
    {
        private List<Key> ahkEntries = new List<Key>();
        public int ahkDelay { get; set; }
        private Thread ahkThread;

        public void Start()
        {
            Stop();
            Client roClient = ClientSingleton.GetClient();
            if(roClient != null)
            {
                Thread ahkThread = new Thread(() => {
                    while (true)
                    {
                        try
                        {
                            foreach (Key key in ahkEntries)
                            {
                                if (Keyboard.IsKeyDown(key))
                                {
                                    while (Keyboard.IsKeyDown(key))
                                    {
                                        Keys thisk = (Keys)Enum.Parse(typeof(Keys), key.ToString());
                                        Interop.PostMessage(roClient.process.MainWindowHandle, Constants.WM_KEYDOWN_MSG_ID, thisk, 0);
                                        Interop.PostMessage(roClient.process.MainWindowHandle, Constants.WM_LBUTTONDOWN, 0, 0);
                                        Thread.Sleep(10);
                                        Interop.PostMessage(roClient.process.MainWindowHandle, Constants.WM_LBUTTONUP, 0, 0);
                                        Thread.Sleep(ahkDelay);
                                    }
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

        public void AddAHKEntry(Key key)
        {
            this.ahkEntries.Add(key);
        }

        public void RemoveAHKEntry(Key key)
        {
            this.ahkEntries.Remove(key);
        }

        public void Stop()
        {
            if(this.ahkThread != null && this.ahkThread.IsAlive)
            {
                this.ahkThread.Abort();
            }
            
        }
    }
}
