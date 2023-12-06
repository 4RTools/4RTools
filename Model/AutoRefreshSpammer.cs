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
        private _4RThread thread1;
        public int refreshDelay { get; set; } = 5;
        public Key refreshKey { get; set; }

        public int refreshDelay1 { get; set; } = 5;
        public Key refreshKey1 { get; set; }

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
                int delayInSeconds1 = this.refreshDelay1 * 1000;
                int delay = delayInSeconds == 0 ? defaultDelayInSeconds : delayInSeconds;
                int delay1 = delayInSeconds1 == 0 ? defaultDelayInSeconds : delayInSeconds1;


                this.thread = new _4RThread(_ => AutorefreshThreadExecution(roClient, delay, this.refreshKey));
                _4RThread.Start(this.thread);

                this.thread1 = new _4RThread(_ => AutorefreshThreadExecution(roClient, delay1, this.refreshKey1));
                _4RThread.Start(this.thread1);
            }
        }

        private int AutorefreshThreadExecution(Client roClient, int delay, Key rKey)
        {
            if (rKey != Key.None)
            {
                Interop.PostMessage(roClient.process.MainWindowHandle, Constants.WM_KEYDOWN_MSG_ID, (Keys)Enum.Parse(typeof(Keys), rKey.ToString()), 0);
            }
            Thread.Sleep(delay);
            return 0;
        }

        public void Stop()
        {
            _4RThread.Stop(this.thread);
            _4RThread.Stop(this.thread1);
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
