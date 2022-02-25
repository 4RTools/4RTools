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
        public int refreshDelay { get; set; } = 10;
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
                Thread autoRefreshThread = new Thread(() =>
                {
                    while (true)
                    {
                        if (this.refreshKey != Key.None && this.refreshDelay > 0)
                        {
                            Interop.PostMessage(roClient.process.MainWindowHandle, Constants.WM_KEYDOWN_MSG_ID, (Keys)Enum.Parse(typeof(Keys), this.refreshKey.ToString()), 0);
                            Thread.Sleep(this.refreshDelay);
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
