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
        public MacroConfig(int id)
        {
            this.id = id;
            this.macroEntries = new Dictionary<string, Key>();
        }

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

        public static string ACTION_NAME_SONG_MACRO = "SongMacro";

        public string actionName { get; set; }
        private _4RThread thread;
        public List<MacroConfig> configs { get; set; } = new List<MacroConfig>();

        public Macro(string macroname, int macroLanes)
        {
            this.actionName = macroname;
            for(int i = 1; i <= macroLanes; i++)
            {
                configs.Add(new MacroConfig(i, Key.None));

            }
        }

        public void ResetMacro(int macroId)
        {
            try
            {
                configs[macroId - 1] = new MacroConfig(macroId);
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
            foreach (MacroConfig mc in this.configs)
            {
                if (mc.trigger != Key.None && Keyboard.IsKeyDown(mc.trigger))
                {
                    Dictionary<string, Key> macro = mc.macroEntries;
                    for (int i = 1; i <= macro.Count; i++)//Ensure to execute keys in Order
                    {
                        Key macroKey = macro["in" + i + "mac" + mc.id];
                        if (macroKey != Key.None)
                        {
                            Keys thisk = (Keys)Enum.Parse(typeof(Keys), macroKey.ToString());
                            Thread.Sleep(mc.delay);
                            Interop.PostMessage(roClient.process.MainWindowHandle, Constants.WM_KEYDOWN_MSG_ID, thisk, 0);
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
