using System;
using System.Collections.Generic;
using System.Windows.Input;
using Newtonsoft.Json;
using System.Threading;
using _4RTools.Utils;
using System.Windows.Forms;

namespace _4RTools.Model
{

    public class MacroConfig
    {
        public int id;
        public Key trigger { get; set; }
        public int delay { get; set; } = 50;
        public Dictionary<string,Key> macroEntries { get; set; } = new Dictionary<string, Key>();

        public MacroConfig() { }

        public MacroConfig(MacroConfig macro)
        {
            this.id = macro.id;
            this.delay = macro.delay;
            this.trigger = macro.trigger;
            this.macroEntries = new Dictionary<string, Key>(macro.macroEntries);
        }
        public MacroConfig(int id, Key trigger)
        {
            this.id = id;
            this.trigger = trigger;
        }
    }

    public class Macro : Action
    {
        public string actionName { get; set; }
        private Thread macroThread;
        public List<MacroConfig> configs { get; set; } = new List<MacroConfig>();


        public Macro(string macroname, int macroLanes)
        {
            this.actionName = macroname;
            for(int i = 1; i <= macroLanes; i++)
            {
                configs.Add(new MacroConfig(i, Key.None));

            }
        }

        public string GetActionName()
        {
            return this.actionName;
        }

        public string GetConfiguration()
        {
            return JsonConvert.SerializeObject(this);
        }

        public void Start()
        {
            Stop();
            Client roClient = ClientSingleton.GetClient();
            if (roClient != null)
            {
                Thread macroThread = new Thread(() => {
                    while (true)
                    {
                        try
                        {
                            foreach(MacroConfig mc in this.configs)
                            {
                                if (mc.trigger != Key.None && Keyboard.IsKeyDown(mc.trigger))
                                {
                                    Dictionary<string,Key> macro = mc.macroEntries;
                                    for (int i = 1; i <= macro.Count;i++)//Ensure to execute keys in Order
                                    {
                                        Key macroKey = macro["in" + i + "mac" + mc.id];
                                        Keys thisk = (Keys)Enum.Parse(typeof(Keys), macroKey.ToString());
                                        Thread.Sleep(mc.delay);
                                        Interop.PostMessage(roClient.process.MainWindowHandle, Constants.WM_KEYDOWN_MSG_ID, thisk, 0);
                                    }
                                }
                            }
                        }
                        catch (Exception e) { }
                        Thread.Sleep(100);
                    }
                });

                this.macroThread = macroThread;
                macroThread.SetApartmentState(ApartmentState.STA);
                macroThread.Start();
            }
        }

        public void Stop()
        {
            if (this.macroThread != null && this.macroThread.IsAlive)
            {
                this.macroThread.Abort();
            }
        }
    }
}
