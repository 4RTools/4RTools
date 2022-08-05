using _4RTools.Utils;
using _4RTools.Model;
using System.Windows.Forms;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace _4RTools.Forms
{
    public partial class ClientUpdaterForm : Form
    {
        private System.Net.Http.HttpClient client = new System.Net.Http.HttpClient();

        public ClientUpdaterForm()
        {
            var requestAccepts = client.DefaultRequestHeaders.Accept;
            requestAccepts.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.UserAgent.TryParseAdd("request");//Set the User Agent to "request"
            InitializeComponent();
            StartUpdate();
        }

        private async void StartUpdate()
        {
            try
            {
                //If fetch successfully update and load local file.
                client.Timeout = TimeSpan.FromSeconds(5);
                string result = await client.GetStringAsync(AppConfig._4RClientsURL);
                LoadServers(result);
            }catch(Exception)
            {
                //If catch some exception while Fetch, load local file.
                label1.Text = "Error while fetch server file. Trying local file...";
                try
                {
                    LoadServers(LoadLocalServerFile());
                }
                catch(Exception)
                {
                    LoadServers(LoadResourceServerFile());
                }
            }
            finally
            {
                new Container().Show();
                Hide();
            }
        }

        private string LoadResourceServerFile()
        {
            return Properties.Resources.supported_servers;
        }

        private string LoadLocalServerFile()
        {
            string jsonFileName = "supported_servers.json";
            if (!File.Exists(jsonFileName))
            {
                throw new Exception("You need a `supported_servers.json` file. Please download it in our website https://www.4rtools.com.br");
            }

            string json = File.ReadAllText(jsonFileName);
            return json;
        }

        private void LoadServers(string serversJson)
        {
            List<ClientDTO> clients = JsonConvert.DeserializeObject<List<ClientDTO>>(serversJson);
            foreach (ClientDTO clientDTO in clients)
            {
                int hpAddress = Convert.ToInt32(clientDTO.hpAddress, 16);
                int nameAddress = Convert.ToInt32(clientDTO.nameAddress, 16);
                ClientListSingleton.AddClient(new Client(clientDTO.name, hpAddress, nameAddress));
                pbSupportedServer.Increment(1);
            }
        }
    }
}
