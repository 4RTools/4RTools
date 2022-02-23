using System;
using System.ComponentModel;
using _4RTools.Utils;
using System.Threading;
using System.Windows.Forms;

namespace _4RTools.Model
{

    internal class Autopot : Action
    {

        [DefaultValue(Keys.None)]
        public Keys hpKey { get; set; }
        public int hpPercent { get; set; }
        [DefaultValue(Keys.None)]
        public Keys spKey { get; set; }
        public int spPercent { get; set; }
        public int delay { get; set; } = 15;

        private Thread autopotThread;

        public Autopot()
        {

        }

        public Autopot(Keys hpKey, int hpPercent, int delay, Keys spKey, int spPercent)
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
            Console.WriteLine("Autopot: Start");
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
                        if (roClient.IsHpBelow(hpPercent))
                        {
                            potHp();
                            hp_pot_count++;

                            if (hp_pot_count == 3)
                            {
                                hp_pot_count = 0;
                                if (roClient.IsSpBelow(spPercent))
                                {
                                    potSp();
                                }
                            }
                        }

                        // check sp
                        if (roClient.IsSpBelow(spPercent))
                        {
                            potSp();
                        }

                        Thread.Sleep(this.delay);
                    }
                });

                this.autopotThread = apThread;
                apThread.SetApartmentState(ApartmentState.STA);
                apThread.Start();
            }
        }

        private void potSp()
        {
            Interop.PostMessage(ClientSingleton.GetClient().process.MainWindowHandle, Utils.Constants.WM_KEYDOWN_MSG_ID, this.spKey, 0); // keydown
            Interop.PostMessage(ClientSingleton.GetClient().process.MainWindowHandle, Utils.Constants.WM_KEYUP_MSG_ID, this.spKey, 0); // keyup
        }

        private void potHp()
        {
            Interop.PostMessage(ClientSingleton.GetClient().process.MainWindowHandle, Utils.Constants.WM_KEYDOWN_MSG_ID, this.hpKey, 0); // keydown
            Interop.PostMessage(ClientSingleton.GetClient().process.MainWindowHandle, Utils.Constants.WM_KEYUP_MSG_ID, this.hpKey, 0); // keyup
        }

        public void Stop()
        {
            Console.WriteLine("Autopot: Stop");
            if (this.autopotThread != null)
            {
                this.autopotThread.Abort();
            }
        }
    }
}
