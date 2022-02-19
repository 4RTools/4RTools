using System;
using System.Windows.Forms;
using System.Threading;
using System.Runtime.InteropServices;

namespace _4RTools.Model
{

    internal class Autopot : Action
    {
        // PINVOKES
        [DllImport("user32.dll", SetLastError = true)]
        private static extern bool PostMessage(IntPtr hWnd, int Msg, Keys wParam, int lParam);

        private Client roClient = ClientSingleton.GetClient();

        private Keys hpKey;
        private int hpPercent;
        private int hpDelay;


        private Keys spKey;
        private int spPercent;
        private int spDelay;

        private Thread autopotThread;


        public Autopot(Keys hpKey, int hpPercent, int hpDelay, Keys spKey, int spPercent, int spDelay)
        {
            this.hpKey = hpKey;
            this.hpPercent = hpPercent;
            this.hpDelay = hpDelay;

            this.spKey = spKey;
            this.spPercent = spPercent;
            this.spDelay = spDelay;


            Start();
        }

        public void Start()
        {
            //TODO - DO NOT CREATE A NEW THREAD WHEN PROCESS CHANGE.
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
                        Thread.Sleep(this.hpDelay);
                    }

                    // check sp
                    if (roClient.IsSpBelow(spPercent))
                    {
                        potSp();
                        Thread.Sleep(this.spDelay);
                    }
                    
                }
            });

            this.autopotThread = apThread;
            apThread.SetApartmentState(ApartmentState.STA); //NÃO FAÇO IDEIA, TEM Q VER Q DIABO É ISSO
            apThread.Start();
        }

        private void potSp()
        {
            PostMessage(roClient.process.MainWindowHandle, 0x100, this.spKey, 0); // keydown
            PostMessage(roClient.process.MainWindowHandle, 0x101, this.spKey, 0); // keyup
        }

        private void potHp()
        {
            PostMessage(roClient.process.MainWindowHandle, 0x100, this.hpKey, 0); // keydown
            PostMessage(roClient.process.MainWindowHandle, 0x101, this.hpKey, 0); // keyup
        }

        public void Stop()
        {
            autopotThread.Abort();
        }
    }
}
