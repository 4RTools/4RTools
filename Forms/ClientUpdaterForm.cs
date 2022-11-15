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
            client.DefaultRequestHeaders.UserAgent.TryParseAdd("request"); //Set the User Agent to "request"
            InitializeComponent();
            StartUpdate();
        }

        private async void StartUpdate()
        {
            List<ClientDTO> clients = new List<ClientDTO>();

            /**
             * Try to load local supported_server.json file and append all data in clients list.
             */
            try
            {
                string localServers = LoadLocalServerFile();
                if (localServers != null)
                {
                    clients.AddRange(JsonConvert.DeserializeObject<List<ClientDTO>>(localServers));
                }
            }catch
            {
                MessageBox.Show("Could not parse local supported_server.json. Invalid json format", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


            /**
             * Try to load remote supported_server.json file and append all data in clients list.
             */
            try
            {
                
                //If fetch successfully update and load local file.
                client.Timeout = TimeSpan.FromSeconds(5);
                string remoteServersRaw = await client.GetStringAsync(AppConfig._4RClientsURL);
                clients.AddRange(JsonConvert.DeserializeObject<List<ClientDTO>>(remoteServersRaw));

            }
            catch(Exception ex)
            {
                //If catch some exception while Fetch, load resource file.
                MessageBox.Show("Cannot load supported_servers file. Loading resource instead....");
                clients.AddRange(JsonConvert.DeserializeObject<List<ClientDTO>>(LoadResourceServerFile()));
            }
            finally
            {
                LoadServers(clients);
                new Container().Show();
                Hide();
            }
        }

        private string LoadResourceServerFile()
        {
            return Resources._4RTools.ETCResource.supported_servers;
        }

        private string LoadLocalServerFile()
        {
            string jsonFileName = "supported_servers.json";
            if (!File.Exists(jsonFileName))
            {
                return null;
            }
            string json = File.ReadAllText(jsonFileName);
            return json;
        }

        private void LoadServers(List<ClientDTO> clients)
        {
            foreach (ClientDTO clientDTO in clients)
            {
                try
                {
                    int hpAddress = Convert.ToInt32(clientDTO.hpAddress, 16);
                    int nameAddress = Convert.ToInt32(clientDTO.nameAddress, 16);
                    ClientListSingleton.AddClient(new Client(clientDTO.name, hpAddress, nameAddress));
                    pbSupportedServer.Increment(1);
                }
                catch { }
                
            }
        }
    }
}
