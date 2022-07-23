using _4RTools.Utils;
using _4RTools.Model;
using System.Windows.Forms;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

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
                string result = await client.GetStringAsync(AppConfig._4RClientsURL);
                List<ClientDTO> clients = JsonConvert.DeserializeObject<List<ClientDTO>>(result);
                foreach(ClientDTO clientDTO in clients)
                {
                    int hpAddress = Convert.ToInt32(clientDTO.hpAddress, 16);
                    int nameAddress = Convert.ToInt32(clientDTO.nameAddress, 16);
                    ClientListSingleton.AddClient(new Client(clientDTO.processName, hpAddress, nameAddress));
                    pbSupportedServer.Increment(1);
                }
                new Container().Show();
                Hide();
            }catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
            
        }
    }
}
