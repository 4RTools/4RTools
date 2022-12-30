using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Threading;
using System.Windows.Input;
using System.Drawing;
using _4RTools.Utils;
using Newtonsoft.Json;


namespace _4RTools.Model
{
    public class KeyConfig {
        public Key Key { get; set; }
        public bool ClickActive { get; set; }

        public KeyConfig(Key key, bool clickAtive) {
            this.Key = key;
            this.ClickActive = clickAtive;
        }
    }

    public class AHK : Action
    {
        private const string ACTION_NAME = "AHK20";
        private const string COMPATIBILITY = "ahk_compatibility";
        private const string COMPATIBILITY_WITHOUT_FLICK = "ahk_compatibility_without_flick";
        private const string SPEED_BOOST = "ahk_speedboost";
        public Dictionary<string, KeyConfig> AhkEntries { get; set; } = new Dictionary<string, KeyConfig>();
        public int AhkDelay { get; set; } = 10;
        public string AhkMode { get; set; } = COMPATIBILITY;
        private _4RThread thread;

        public AHK()
        {
        }

        public void Start()
        {
            Client roClient = ClientSingleton.GetClient();
            if (roClient != null)
            {
                if (thread != null) { _4RThread.Stop(this.thread); }

                switch (this.AhkMode)
                {
                    case COMPATIBILITY:
                        Console.WriteLine("===> COMPATIBILITY", this.AhkMode);
                        this.thread = new _4RThread(_ => AHKCompatibility(roClient));
                        break;

                    case COMPATIBILITY_WITHOUT_FLICK:
                        Console.WriteLine("===> COMPATIBILITY_WITHOUT_FLICK", this.AhkMode);
                        this.thread = new _4RThread(_ => AHKCompatibility(roClient));
                        break;

                    case SPEED_BOOST:
                        Console.WriteLine("===> SPEED_BOOST", this.AhkMode);
                        this.thread = new _4RThread(_ => AHKCompatibility(roClient));
                        break;
                }

                Console.WriteLine($"===> [AHK] _4RThread {thread.ToString()}");
                _4RThread.Start(this.thread);
            }
        }

        private int AHKCompatibility(Client roClient)
        {
            foreach (KeyConfig config in AhkEntries.Values)
            {
                Keys thisk = (Keys)Enum.Parse(typeof(Keys), config.Key.ToString());
                if (!Keyboard.IsKeyDown(Key.LeftAlt) && !Keyboard.IsKeyDown(Key.RightAlt))
                {
                    if (config.ClickActive && Keyboard.IsKeyDown(config.Key))
                    {
                        while (Keyboard.IsKeyDown(config.Key))
                        {
                            Interop.PostMessage(roClient.process.MainWindowHandle, Constants.WM_KEYDOWN_MSG_ID, thisk, 0);
                            Interop.PostMessage(roClient.process.MainWindowHandle, Constants.WM_LBUTTONDOWN, 0, 0);
                            System.Windows.Forms.Cursor.Position = new Point(System.Windows.Forms.Cursor.Position.X - Constants.MOUSE_DIAGONAL_MOVIMENTATION_PIXELS_AHK, System.Windows.Forms.Cursor.Position.Y - Constants.MOUSE_DIAGONAL_MOVIMENTATION_PIXELS_AHK);
                            Thread.Sleep(1);
                            System.Windows.Forms.Cursor.Position = new Point(System.Windows.Forms.Cursor.Position.X + Constants.MOUSE_DIAGONAL_MOVIMENTATION_PIXELS_AHK, System.Windows.Forms.Cursor.Position.Y + Constants.MOUSE_DIAGONAL_MOVIMENTATION_PIXELS_AHK);
                            Interop.PostMessage(roClient.process.MainWindowHandle, Constants.WM_LBUTTONUP, 0, 0);
                            Thread.Sleep(this.AhkDelay);
                        }
                    }
                    else
                    {
                        while (Keyboard.IsKeyDown(config.Key))
                        {
                            Interop.PostMessage(roClient.process.MainWindowHandle, Constants.WM_KEYDOWN_MSG_ID, thisk, 0);
                            Thread.Sleep(this.AhkDelay);
                        }
                    }

                    Thread.Sleep(this.AhkDelay);
                }
            }
            return 0;
        }

        private int AHKCompatibilityWithoutFlick(Client roClient)
        {
            foreach (KeyConfig config in AhkEntries.Values)
            {
                Keys thisk = (Keys)Enum.Parse(typeof(Keys), config.Key.ToString());
                if (!Keyboard.IsKeyDown(Key.LeftAlt) && !Keyboard.IsKeyDown(Key.RightAlt))
                {
                    if (config.ClickActive && Keyboard.IsKeyDown(config.Key))
                    {
                        while (Keyboard.IsKeyDown(config.Key))
                        {
                            Interop.PostMessage(roClient.process.MainWindowHandle, Constants.WM_KEYDOWN_MSG_ID, thisk, 0);
                            Interop.PostMessage(roClient.process.MainWindowHandle, Constants.WM_LBUTTONDOWN, 0, 0);
                            System.Windows.Forms.Cursor.Position = new Point(System.Windows.Forms.Cursor.Position.X - Constants.MOUSE_DIAGONAL_MOVIMENTATION_PIXELS_AHK, System.Windows.Forms.Cursor.Position.Y - Constants.MOUSE_DIAGONAL_MOVIMENTATION_PIXELS_AHK);
                            Thread.Sleep(1);
                            System.Windows.Forms.Cursor.Position = new Point(System.Windows.Forms.Cursor.Position.X + Constants.MOUSE_DIAGONAL_MOVIMENTATION_PIXELS_AHK, System.Windows.Forms.Cursor.Position.Y + Constants.MOUSE_DIAGONAL_MOVIMENTATION_PIXELS_AHK);
                            Interop.PostMessage(roClient.process.MainWindowHandle, Constants.WM_LBUTTONUP, 0, 0);
                            Thread.Sleep(this.AhkDelay);
                        }
                    }
                    else
                    {
                        while (Keyboard.IsKeyDown(config.Key))
                        {
                            Interop.PostMessage(roClient.process.MainWindowHandle, Constants.WM_KEYDOWN_MSG_ID, thisk, 0);
                            Thread.Sleep(this.AhkDelay);
                        }
                    }

                    Thread.Sleep(this.AhkDelay);
                }
            }
            return 0;
        }

        private int AHKSpeedBoost(Client roClient)
        {
            foreach (KeyConfig config in AhkEntries.Values)
            {
                Keys thisk = (Keys)Enum.Parse(typeof(Keys), config.Key.ToString());
                if (!Keyboard.IsKeyDown(Key.LeftAlt) && !Keyboard.IsKeyDown(Key.RightAlt))
                {
                    if (config.ClickActive && Keyboard.IsKeyDown(config.Key))
                    {
                        while (Keyboard.IsKeyDown(config.Key))
                        {
                            Interop.PostMessage(roClient.process.MainWindowHandle, Constants.WM_KEYDOWN_MSG_ID, thisk, 0);
                            Interop.PostMessage(roClient.process.MainWindowHandle, Constants.WM_LBUTTONDOWN, 0, 0);
                            System.Windows.Forms.Cursor.Position = new Point(System.Windows.Forms.Cursor.Position.X - Constants.MOUSE_DIAGONAL_MOVIMENTATION_PIXELS_AHK, System.Windows.Forms.Cursor.Position.Y - Constants.MOUSE_DIAGONAL_MOVIMENTATION_PIXELS_AHK);
                            Thread.Sleep(1);
                            System.Windows.Forms.Cursor.Position = new Point(System.Windows.Forms.Cursor.Position.X + Constants.MOUSE_DIAGONAL_MOVIMENTATION_PIXELS_AHK, System.Windows.Forms.Cursor.Position.Y + Constants.MOUSE_DIAGONAL_MOVIMENTATION_PIXELS_AHK);
                            Interop.PostMessage(roClient.process.MainWindowHandle, Constants.WM_LBUTTONUP, 0, 0);
                            Thread.Sleep(this.AhkDelay);
                        }
                    }
                    else
                    {
                        while (Keyboard.IsKeyDown(config.Key))
                        {
                            Interop.PostMessage(roClient.process.MainWindowHandle, Constants.WM_KEYDOWN_MSG_ID, thisk, 0);
                            Thread.Sleep(this.AhkDelay);
                        }
                    }

                    Thread.Sleep(this.AhkDelay);
                }
            }
            return 0;
        }

        public void AddAHKEntry(string chkboxName,KeyConfig value)
        {
            if (this.AhkEntries.ContainsKey(chkboxName)) {
                RemoveAHKEntry(chkboxName);
            }

            this.AhkEntries.Add(chkboxName, value);
               
        }

        public void RemoveAHKEntry(string chkboxName)
        {
            this.AhkEntries.Remove(chkboxName);
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
