using _4RTools.Utils;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace _4RTools.Model
{
    public class Custom : Action
    {
        public static string ACTION_NAME_CUSTOM = "Custom";

        public string actionName { get; set; }

        private _4RThread thread;

        [DllImport("user32.dll")]
        public static extern void keybd_event(byte bVk, byte bScan, int dwFlags, int dwExtraInfo);

        public Key tiMode { get; set; } = 0;

        public string GetActionName()
        {
            return ACTION_NAME_CUSTOM;
        }

        public string GetConfiguration()
        {
            return JsonConvert.SerializeObject(this);
        }

        private int CustomExecutionThread(Client roClient)
        {

            var TiMode = ProfileSingleton.GetCurrent().Custom.tiMode;
            if (!TiMode.Equals(Key.None) && Keyboard.IsKeyDown(TiMode))
            {
                _AHKTransferBoost(roClient, new KeyConfig(TiMode, true), (Keys)Enum.Parse(typeof(Keys), TiMode.ToString()));
                return 0;
            }
            
            Thread.Sleep(100);
            return 0;
        }

        private void _AHKTransferBoost(Client roClient, KeyConfig config, Keys thisk)
        {
            Func<int, int> send_click;

            //Send Event Directly to Window via PostMessage
            send_click = (evt) =>
            {
                Interop.PostMessage(roClient.process.MainWindowHandle, Constants.WM_RBUTTONDOWN, 0, 0);
                Thread.Sleep(1);
                Interop.PostMessage(roClient.process.MainWindowHandle, Constants.WM_RBUTTONUP, 0, 0);
                return 0;
            };

            keybd_event(Constants.VK_LMENU, 0xA4, Constants.KEYEVENTF_EXTENDEDKEY, 0);

            while (Keyboard.IsKeyDown(config.key))
            {
                send_click(0);
                Thread.Sleep(10);
            }
            keybd_event(Constants.VK_LMENU, 0xA4, Constants.KEYEVENTF_EXTENDEDKEY | Constants.KEYEVENTF_KEYUP, 0);
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
                this.thread = new _4RThread((_) => CustomExecutionThread(roClient));
                _4RThread.Start(this.thread);
            }
        }

        public void Stop()
        {
            _4RThread.Stop(this.thread);
        }
    }
}
