using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using _4RTools.Utils;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Net.Http;
using Aspose.Zip.Rar;
using System.Net;

namespace _4RTools.Forms
{
    public partial class AutoPatcher : Form
    {
        private HttpClient client = new HttpClient();
        public AutoPatcher()
        {
            InitializeComponent();
            /**
             * Autopatch Process
             * 1. Fetch the latest tag in url
             * 2. Compare with current version code in AppConfig.cs
             * 3. If different, should download the .rar in github
             * 3.1  Rename current 4RTools.exe to 4RTools_old.exe
             * 3.2  Rename 4RTools to 4RTools_old
             * 3.3  Extract .rar file in folder
             * 3.3  Delete .rar in file folder.
             * 3.4  Delete 4RTools_old in file folder.
             * 4. If equals, version are updated.
             */
            StartAutopatcher();
        }

        private async void StartAutopatcher()
        {

            //Get Latest Version
            //List[0] = Tag
            //List[1] = Url
            try
            {
                String oldFileName = "4RTools_old.exe";
                String sourceFileName = "4RTools.exe";
                File.Delete(oldFileName); //Delete old 4RTools
                //Fetch Github latest Tag
                client.Timeout = TimeSpan.FromSeconds(5);
                client.DefaultRequestHeaders.Add("User-Agent", "request");
                string latestVersion = await client.GetStringAsync(AppConfig._4RLatestVersionURL);
                JObject obj = JsonConvert.DeserializeObject<JObject>(latestVersion);

                string tag = obj["name"].ToString(); //Tag Name

                if (tag != AppConfig.Version)
                {
                    string downloadUrl = obj["assets"][0]["browser_download_url"].ToString(); //Latest download url
                    string fileName = obj["assets"][0]["name"].ToString(); //Latest file name
                    //If different, 4R is outdated.
                    //Need to download and update
                    await Download(downloadUrl, fileName); //Download the .rar file
                    RarArchive arch = new RarArchive(fileName);
                    File.Move(sourceFileName, oldFileName);
                    arch.ExtractToDirectory(".");
                    arch.Dispose();
                    File.Delete(fileName); //Delete .rar file downloaded
                    Environment.Exit(0);
                }

            }
            finally
            {
                new ClientUpdaterForm().Show();
                Hide();
            }
        }

        private async Task<bool> Download(string url, string filename)
        {
            WebClient client = new WebClient();
            client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(_4RTools_DownloadProgressChanged);
            await client.DownloadFileTaskAsync(url, @filename);
            return true;
        }

        void _4RTools_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate {
                double bytesIn = double.Parse(e.BytesReceived.ToString());
                double totalBytes = double.Parse(e.TotalBytesToReceive.ToString());
                double percentage = bytesIn / totalBytes * 100;
                pbPatcher.Value = int.Parse(Math.Truncate(percentage).ToString());
            });
        }


    }
}
