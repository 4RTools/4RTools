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
        private _4RThread thread2;
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
                if (chainConfig.infinityLoop) {
                    if (chainConfig.trigger != Key.None && chainConfig.infinityLoopOn)
                    {
                        Dictionary<string, MacroKey> macro = chainConfig.macroEntries;
                        for (int i = 1; i <= macro.Count; i++)//Ensure to execute keys in Order
                        {
                            MacroKey macroKey = macro["in" + i + "mac" + chainConfig.id];
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
                } else
                {
                    if (chainConfig.trigger != Key.None && Keyboard.IsKeyDown(chainConfig.trigger))
                    {
                        Dictionary<string, MacroKey> macro = chainConfig.macroEntries;
                        for (int i = 1; i <= macro.Count; i++)//Ensure to execute keys in Order
                        {
                            MacroKey macroKey = macro["in" + i + "mac" + chainConfig.id];
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
            }
            Thread.Sleep(50);
            return 0;
        }

        private int MacroExecutionThread2(Client roClient)
        {
            foreach (ChainConfig chainConfig in this.ChainConfigs)
            {
                if (chainConfig.infinityLoop && chainConfig.trigger != Key.None)
                {
                    if (Keyboard.IsKeyDown(chainConfig.trigger))
                    {
                        chainConfig.infinityLoopOn = !chainConfig.infinityLoopOn;
                    }
                }
            }
            Thread.Sleep(50);
            return 0;
        }

        public void Start()
        {
            Stop();
            Client roClient = ClientSingleton.GetClient();
            if (roClient != null)
            {
                this.thread = new _4RThread((_) => MacroExecutionThread2(roClient));
                this.thread2 = new _4RThread((_) => MacroExecutionThread(roClient));
                _4RThread.Start(this.thread);
                _4RThread.Start(this.thread2);
            }
        }

        public void Stop()
        {
            _4RThread.Stop(this.thread);
            _4RThread.Stop(this.thread2);
        }
    }
}
