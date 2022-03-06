using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace _4RTools.Utils
{
    public sealed class ProcessFilter
    {
        private static readonly string[] ProcessToExclude = new string [] {
            "System Idle Process",
            "System",
            "Secure System",
            "Registry",
            "smss",
            "csrss",
            "wininit",
            "services",
            "LsaIso",
            "lsass",
            "winlogon",
            "svchost",
            "fontdrvhost",
            "dwm",
            "vmms",
            "dasHost",
            "NVDisplay.Container",
            "AsusCertService",
            "atiesrxx",
            "atieclxx",
            "Memory Compression",
            "atkexComSvc",
            "WmiPrvSE",
            "vmcompute",
            "spoolsv",
            "wlanext",
            "conhost",
            "com.docker.service",
            "LogiRegistryService",
            "openvpnserv",
            "sqlwriter",
            "GameManagerService",
            "PanGPS",
            "RazerCentralService",
            "nvcontainer",
            "RtkAudUService64",
            "OfficeClickToRun",
            "LMS",
            "jenkins",
            "jhi_service",
            "sqlservr",
            "sqlceip",
            "MBAMService",
            "rundll32",
            "java",
            "Razer Synapse Service",
            "dllhost",
            "mbamtray",
            "Razer Synapse Service Process",
            "sihost",
            "taskhostw",
            "ctfmon",
            "explorer",
            "StartMenuExperienceHost",
            "RuntimeBroker",
            "SearchApp",
            "SearchIndexer",
            "ShellExperienceHost",
            "YourPhone",
            "NVIDIA Web Helper",
            "GoogleCrashHandler",
            "GoogleCrashHandler64",
            "YourPhoneServer",
            "ApplicationFrameHost",
            "Calculator",
            "SystemSettings",
            "UserOOBEBroker",
            "PaintStudio.View",
            "SgrmBroker",
            "TextInputHost",
            "SecurityHealthService",
            "CompPkgSrv",
            "SettingSyncHost",
            "TGitCache",
            "PanGPA",
            "audiodg",
            "Discord",
            "firefox",
            "RiotClientServices",
            "RiotClientCrashHandler",
            "LeagueClient",
            "LeagueCrashHandler",
            "SnippingTool",
            "Microsoft.Photos",
            "GRF Editor",
            "Video.UI",
            "wscript",
            "LeagueClientUx",
            "LeagueClientUxRender",
            "GameBarPresenceWriter",
            "MoUsoCoreWorker",
            "devenv",
            "PerfWatson2",
            "Microsoft.ServiceHub.Controller",
            "ServiceHub.VSDetouredHost",
            "ServiceHub.IdentityHost",
            "ServiceHub.RoslynCodeAnalysisService",
            "ServiceHub.Host.CLR.x86",
            "ServiceHub.TestWindowStoreHost",
            "ServiceHub.SettingsHost",
            "ServiceHub.Host.CLR.x64",
            "MSBuild",
            "VBCSCompiler",
            "ServiceHub.DataWarehouseHost",
            "StandardCollector.Service",
            "smartscreen",
            "Taskmgr",
            "SearchProtocolHost",
            "SearchFilterHost",
            "ScriptedSandbox64",
            "pwsh",
            "TrustedInstaller",
            "TiWorker",
            "WMIC",
            "notepad",
            "notepad++"
        };
        private ProcessFilter() { }

        public static List<Process> GetProcesses()
        {
            List<Process> processes = new List<Process>();
            foreach(Process p in Process.GetProcesses())
            {
                if(p.MainWindowTitle != "" && !ProcessToExclude.Contains(p.ProcessName))
                {
                    processes.Add(p);
                }
            }

            return processes;
        }
    }
}
