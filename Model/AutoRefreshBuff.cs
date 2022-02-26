using System;
using System.Threading;
using System.Windows.Input;
using System.Windows.Forms;
using Newtonsoft.Json;
using _4RTools.Utils;

namespace _4RTools.Model
{
    public class AutoRefreshBuff : Action
    {
        private string ACTION_NAME = "AUTO_REFRESH_BUFF";
        private Thread thread;
        public int refreshDelay { get; set; } = 5;
        public Key refreshKey { get; set; }

        public AutoRefreshBuff()
        {

        }

        public void Start()
        {
            Stop();
            Client roClient = ClientSingleton.GetClient();
            if (roClient != null)
            {
                int delay = this.refreshDelay * 1000;
                Thread autoRefreshThread = new Thread(() =>
                {
                    while (true)
                    {
                        if (this.refreshKey != Key.None && delay > 1000)
                        {
                            Interop.PostMessage(roClient.process.MainWindowHandle, Constants.WM_KEYDOWN_MSG_ID, (Keys)Enum.Parse(typeof(Keys), this.refreshKey.ToString()), 0);
                            Thread.Sleep(delay);
                        }
                    }
                });

                this.thread = autoRefreshThread;
                autoRefreshThread.SetApartmentState(ApartmentState.STA);
                autoRefreshThread.Start();
            }
        }

        public void Stop()
        {
            if (this.thread != null && this.thread.IsAlive)
            {
                this.thread.Abort();
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
