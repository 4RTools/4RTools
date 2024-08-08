using System;
using System.Collections.Generic;
using System.Windows.Input;
using Newtonsoft.Json;
using System.Threading;
using _4RTools.Utils;
using System.Windows.Forms;

namespace _4RTools.Model
{
    public class Stalker : Action
    {
        public static string ACTION_NAME = "StalkerSwitch";

        public string actionName { get; set; }
        private _4RThread thread;
        public List<ChainConfig> ChainConfigs { get; set; } = new List<ChainConfig>();

        public Stalker(string macroname, int macroLanes)
        {
            this.actionName = macroname;
            for (int i = 1; i <= macroLanes; i++)
            {
                ChainConfigs.Add(new ChainConfig(i, Key.None));

            }
        }

        public void ResetMacro(int macroId)
        {
            try
            {
                ChainConfigs[macroId - 1] = new ChainConfig(macroId);
            }
            catch (Exception) { }

        }

        public string GetActionName()
        {
            return this.actionName;
        }

        public string GetConfiguration()
        {
            return JsonConvert.SerializeObject(this);
        }

        private int MacroExecutionThread(Client roClient)
        {
            foreach (ChainConfig chainConfig in this.ChainConfigs)
            {
                if (chainConfig.trigger != Key.None && (Keyboard.IsKeyDown(chainConfig.trigger) || chainConfig.infinityLoopOn))
                {
                    if (chainConfig.infinityLoop) { chainConfig.infinityLoopOn = !chainConfig.infinityLoopOn; }

                    Dictionary<string, MacroKey> macro = chainConfig.macroEntries;
                    for (int i = 1; i <= macro.Count; i++)//Ensure to execute keys in Order
                    {
                        MacroKey macroKey = macro["in" + i + "mac" + chainConfig.id];
                        Console.WriteLine("Infinity loop mode: ", chainConfig.infinityLoop);
                        Console.WriteLine("Infinity loop ON: ", chainConfig.infinityLoopOn);

                        if (macroKey.key != Key.None)
                        {
                            Keys thisk = (Keys)Enum.Parse(typeof(Keys), macroKey.key.ToString());
                            Interop.PostMessage(roClient.process.MainWindowHandle, Constants.WM_KEYDOWN_MSG_ID, thisk, 0);

                            if (macroKey.hasClick)
                            {
                                Interop.PostMessage(roClient.process.MainWindowHandle, Constants.WM_LBUTTONDOWN, 0, 0);
                                Thread.Sleep(1);
                                Interop.PostMessage(roClient.process.MainWindowHandle, Constants.WM_LBUTTONUP, 0, 0);
                            }

                            Thread.Sleep(macroKey.delay);
                        }
                    }
                }
            }
            Thread.Sleep(100);
            return 0;
        }

        public void Start()
        {
            Stop();
            Client roClient = ClientSingleton.GetClient();
            if (roClient != null)
            {
                this.thread = new _4RThread((_) => MacroExecutionThread(roClient));
                _4RThread.Start(this.thread);
            }
        }

        public void Stop()
        {
            _4RThread.Stop(this.thread);
        }
    }
}
