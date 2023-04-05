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

        [DllImport("user32.dll")]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint dwData, int dwExtraInfo);

        [DllImport("user32.dll")]
        public static extern void keybd_event(byte bVk, byte bScan, int dwFlags, int dwExtraInfo);

        private const string ACTION_NAME = "AHK20";
        private const string COMPATIBILITY = "ahkCompatibility";
        private const string SPEED_BOOST = "ahkSpeedBoost";

        public Dictionary<string, KeyConfig> ahkEntries { get; set; } = new Dictionary<string, KeyConfig>();
        public int ahkDelay { get; set; } = 10;
        public bool mouseFlick { get; set; } = false;
        public bool noShift { get; set; } = false;
        public string ahkMode { get; set; } = COMPATIBILITY;
        private _4RThread thread;

        public AHK()
        {
        }

        public void Start()
        {
            Client roClient = ClientSingleton.GetClient();
            if (roClient != null)
            {
                if (thread != null) {
                    _4RThread.Stop(this.thread);
                }

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
                        if(noShift) keybd_event(Constants.VK_SHIFT, 0x45, Constants.KEYEVENTF_EXTENDEDKEY, 0);
                        //Call Algorithm
                        switch (ahkMode)
                        {
                            case SPEED_BOOST:
                                this.AHKSpeedBoost(roClient, config);
                                break;
                            case COMPATIBILITY:
                                this.AHKCompatibility(roClient, config);
                                break;
                        }
                        if (noShift) keybd_event(Constants.VK_SHIFT, 0x45, Constants.KEYEVENTF_EXTENDEDKEY | Constants.KEYEVENTF_KEYUP, 0);

                    }
                    else
                    {
                        //Non Click Spammer - Algorithm
                        while (Keyboard.IsKeyDown(config.key))
                        {
                            Interop.PostMessage(roClient.process.MainWindowHandle, Constants.WM_KEYDOWN_MSG_ID, thisk, 0);
                            Thread.Sleep(this.ahkDelay);
                        }
                    }
                }
            }
            return 0;
        }

        private int AHKCompatibility(Client roClient, KeyConfig config)
        {
            Keys thisk = (Keys)Enum.Parse(typeof(Keys), config.key.ToString());
            if (this.mouseFlick)
            {
                while (Keyboard.IsKeyDown(config.key))
                {
                    Interop.PostMessage(roClient.process.MainWindowHandle, Constants.WM_KEYDOWN_MSG_ID, thisk, 0);
                    Interop.PostMessage(roClient.process.MainWindowHandle, Constants.WM_LBUTTONDOWN, 0, 0);
                    System.Windows.Forms.Cursor.Position = new Point(System.Windows.Forms.Cursor.Position.X - Constants.MOUSE_DIAGONAL_MOVIMENTATION_PIXELS_AHK, System.Windows.Forms.Cursor.Position.Y - Constants.MOUSE_DIAGONAL_MOVIMENTATION_PIXELS_AHK);
                    Thread.Sleep(1);
                    System.Windows.Forms.Cursor.Position = new Point(System.Windows.Forms.Cursor.Position.X + Constants.MOUSE_DIAGONAL_MOVIMENTATION_PIXELS_AHK, System.Windows.Forms.Cursor.Position.Y + Constants.MOUSE_DIAGONAL_MOVIMENTATION_PIXELS_AHK);
                    Interop.PostMessage(roClient.process.MainWindowHandle, Constants.WM_LBUTTONUP, 0, 0);
                    Thread.Sleep(this.ahkDelay);
                }
            }
            else
            {
                while (Keyboard.IsKeyDown(config.key))
                {
                    Interop.PostMessage(roClient.process.MainWindowHandle, Constants.WM_KEYDOWN_MSG_ID, thisk, 0);
                    Interop.PostMessage(roClient.process.MainWindowHandle, Constants.WM_LBUTTONDOWN, 0, 0);
                    Thread.Sleep(1);
                    Interop.PostMessage(roClient.process.MainWindowHandle, Constants.WM_LBUTTONUP, 0, 0);
                    Thread.Sleep(this.ahkDelay);
                }
            }
            return 0;
        }
        
        private int AHKSpeedBoost(Client roClient, KeyConfig config)
        {
            Keys thisk = (Keys)Enum.Parse(typeof(Keys), config.key.ToString());

            if (this.mouseFlick)
            {
                //Do Mouse Flick
                Point cursorPos = System.Windows.Forms.Cursor.Position;
                Interop.PostMessage(roClient.process.MainWindowHandle, Constants.WM_KEYDOWN_MSG_ID, thisk, 0);
                System.Windows.Forms.Cursor.Position = new Point(System.Windows.Forms.Cursor.Position.X - Constants.MOUSE_DIAGONAL_MOVIMENTATION_PIXELS_AHK, System.Windows.Forms.Cursor.Position.Y - Constants.MOUSE_DIAGONAL_MOVIMENTATION_PIXELS_AHK);
                mouse_event(Constants.MOUSEEVENTF_LEFTDOWN, (uint)cursorPos.X, (uint)cursorPos.Y, 0, 0);
                Thread.Sleep(1);
                System.Windows.Forms.Cursor.Position = new Point(System.Windows.Forms.Cursor.Position.X + Constants.MOUSE_DIAGONAL_MOVIMENTATION_PIXELS_AHK, System.Windows.Forms.Cursor.Position.Y + Constants.MOUSE_DIAGONAL_MOVIMENTATION_PIXELS_AHK);
                mouse_event(Constants.MOUSEEVENTF_LEFTUP, (uint)cursorPos.X, (uint)cursorPos.Y, 0, 0);
                Thread.Sleep(this.ahkDelay);
            }
            else
            {
                while (Keyboard.IsKeyDown(config.key))
                {
                    //Cleaner While
                    Point cursorPos = System.Windows.Forms.Cursor.Position;
                    Interop.PostMessage(roClient.process.MainWindowHandle, Constants.WM_KEYDOWN_MSG_ID, thisk, 0);
                    mouse_event(Constants.MOUSEEVENTF_LEFTDOWN, (uint)cursorPos.X, (uint)cursorPos.Y, 0, 0);
                    Thread.Sleep(1);
                    mouse_event(Constants.MOUSEEVENTF_LEFTUP, (uint)cursorPos.X, (uint)cursorPos.Y, 0, 0);
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
            return ACTION_NAME;
        }
    }
}
