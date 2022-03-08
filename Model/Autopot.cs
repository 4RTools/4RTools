using System;
using System.ComponentModel;
using _4RTools.Utils;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Input;
using Newtonsoft.Json;

namespace _4RTools.Model
{

    public class Autopot : Action
    {

        public Key hpKey { get; set; }
        public int hpPercent { get; set; }
        public Key spKey { get; set; }
        public int spPercent { get; set; }
        public int delay { get; set; } = 15;

        private const string ACTION_NAME = "Autopot";
        private Thread autopotThread;

        public Autopot()
        {

        }

        public Autopot(Key hpKey, int hpPercent, int delay, Key spKey, int spPercent)
        {
            this.delay = delay;

            // HP
            this.hpKey = hpKey;
            this.hpPercent = hpPercent;

            // SP
            this.spKey = spKey;
            this.spPercent = spPercent;
        }

        public void Start()
        {
            Stop();
            Client roClient = ClientSingleton.GetClient();
            if(roClient != null)
            {
                Thread apThread = new Thread(() =>
                {
                    uint hp_pot_count = 0;
                    while (true)
                    {
                        // check hp first
                        if(roClient.ReadCurrentHp() >= Constants.MINIMUM_HP_TO_RECOVER)
                        {
                            if (roClient.IsHpBelow(hpPercent))
                            {
                                pot(this.hpKey);
                                hp_pot_count++;

                                if (hp_pot_count == 3)
                                {
                                    hp_pot_count = 0;
                                    if (roClient.IsSpBelow(spPercent))
                                    {
                                        pot(this.spKey);
                                    }
                                }
                            }

                            // check sp
                            if (roClient.IsSpBelow(spPercent))
                            {
                                pot(this.spKey);
                            }
                        }
                        Thread.Sleep(this.delay);
                    }
                });

                this.autopotThread = apThread;
                apThread.SetApartmentState(ApartmentState.STA);
                apThread.Start();
            }
        }

        private void pot(Key key)
        {
            Keys k = (Keys)Enum.Parse(typeof(Keys), key.ToString());
            if (k != Keys.None)
            {
                Interop.PostMessage(ClientSingleton.GetClient().process.MainWindowHandle, Constants.WM_KEYDOWN_MSG_ID, k, 0); // keydown
                Interop.PostMessage(ClientSingleton.GetClient().process.MainWindowHandle, Constants.WM_KEYUP_MSG_ID, k, 0); // keyup
            }
        }

        public void Stop()
        {
            if (this.autopotThread != null)
            {
                this.autopotThread.Abort();
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
