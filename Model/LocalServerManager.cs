using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4RTools.Model
{
    internal class LocalServerManager
    {

        private static readonly string localServerName = "supported_servers.json";

        public static void AddServer(string hpAddress, string nameAddress, string processName)
        {
            if (!isValid(hpAddress))
            {
                throw new ArgumentException("HP Address is Invalid. Please type a valid Hex value.");
            }

            if(!isValid(nameAddress))
            {
                throw new ArgumentException("Name Address is Invalid. Please type a valid Hex value.");
            }

            string finalHpAddress = "0x" + hpAddress;
            string finalNameAddress = "0x" + nameAddress;
            ClientListSingleton.AddClient(new Client(processName, Convert.ToInt32(finalHpAddress, 16), Convert.ToInt32(finalNameAddress, 16)));


            List<ClientDTO> clients = GetLocalClients();
            clients.Add(new ClientDTO(processName, null, finalHpAddress, finalNameAddress));
            OverwriteLocalFile(clients);

            /**
             * Cenários
             * 1. Arquivo Local não existe
             *  Solução: Criar um novo arquivo vazio
             * 2. Arquivo Local existe mas com sintaxe inválida
             *  Solução: Deletar o arquivo inválido e criar um novo arquivo vazio
             * 3. Arquivo Local existe e é válido
             */
        }

        public static void UpdateClient(ClientDTO client)
        {
            List<ClientDTO> clients = GetLocalClients();
            clients[client.index] = client;
            OverwriteLocalFile(clients);
        }

        private static void OverwriteLocalFile(List<ClientDTO> clients)
        {
            string output = JsonConvert.SerializeObject(clients, Formatting.Indented);
            File.WriteAllText(localServerName, string.Empty);
            File.WriteAllText(localServerName, output);
        }


        public static string LoadLocalServerFile()
        {
            if (!File.Exists(localServerName))
            {
                string startJson = "[]";
                FileStream f = File.Create(localServerName);
                f.Close();
                File.WriteAllText(localServerName, startJson);
                return startJson;
            }
            string json = File.ReadAllText(localServerName);
            return json;
        }

        public static List<ClientDTO> GetLocalClients() {
            string localServers = LoadLocalServerFile();

            if (string.IsNullOrEmpty(localServers)) return new List<ClientDTO>();

            try
            {
                return JsonConvert.DeserializeObject<List<ClientDTO>>(localServers);
            }catch
            {
                return new List<ClientDTO>();
            }
        }

        private static bool isValid(IEnumerable<char> chars)
        {
            return IsHex(chars) && chars.Count() == 8;
        }

        public static bool IsHex(IEnumerable<char> chars)
        {
            bool isHex;
            foreach (var c in chars)
            {
                isHex = ((c >= '0' && c <= '9') ||
                         (c >= 'a' && c <= 'f') ||
                         (c >= 'A' && c <= 'F'));

                if (!isHex)
                    return false;
            }
            return true;
        }
    }
}
