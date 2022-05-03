using System;
using System.Threading;
using System.Windows.Input;
using System.Windows.Forms;
using Newtonsoft.Json;
using _4RTools.Utils;

namespace _4RTools.Model
{
    public class AutoRefreshSpammer : Action
    {
        private string ACTION_NAME = "AutoRefreshSpammer";
        private _4RThread thread;
        public int refreshDelay { get; set; } = 5;
        public Key refreshKey { get; set; }

        public AutoRefreshSpammer()
        {

        }

        public void Start()
        {
            Client roClient = ClientSingleton.GetClient();
            if (roClient != null)
            {
                const int defaultDelayInSeconds = 1000;
                int delayInSeconds = this.refreshDelay * 1000;
                int delay = delayInSeconds == 0 ? defaultDelayInSeconds : delayInSeconds;
                this.thread = new _4RThread(_ => AutorefreshThreadExecution(roClient, delay));
                _4RThread.Start(this.thread);
            }
        }

        private int AutorefreshThreadExecution(Client roClient, int delay)
        {
            if (this.refreshKey != Key.None)
            {
                Interop.PostMessage(roClient.process.MainWindowHandle, Constants.WM_KEYDOWN_MSG_ID, (Keys)Enum.Parse(typeof(Keys), this.refreshKey.ToString()), 0);
            }
            Thread.Sleep(delay);
            return 0;
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
