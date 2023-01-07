using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Net;

namespace _4RTools.Model
{

    public class ClientDTO
    {
        public int index { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string hpAddress { get; set; }
        public string nameAddress { get; set; }

        public int hpAddressPointer { get; set; }
        public int nameAddressPointer { get; set; }

        public ClientDTO() { }

        public ClientDTO(string name, string description, string hpAddress, string nameAddress)
        {
            this.name= name;
            this.description = description;
            this.hpAddress = hpAddress;
            this.nameAddress = nameAddress;

            this.hpAddressPointer = Convert.ToInt32(hpAddress, 16);
            this.nameAddressPointer = Convert.ToInt32(nameAddress, 16);
        }

    }


    public sealed class ClientListSingleton
    {
        private static List<Client> clients = new List<Client>();
        
        public static void AddClient(Client c)
        {
            clients.Add(c);
        }

        public static void RemoveClient(Client c)
        {
            clients.Remove(c);
        }

        public static List<Client> GetAll()
        {
            return clients;
        }

        public static bool ExistsByProcessName(string processName)
        {
            return clients.Exists(client => client.processName == processName);
        }
    }

    public sealed class ClientSingleton
    {
        private static Client client;
        private ClientSingleton(Client client)
        {
            ClientSingleton.client = client;
        }

        public static ClientSingleton Instance(Client client)
        {
            return new ClientSingleton(client);
        }

        public static Client GetClient()
        {
            return client;
        }
    }

    public class Client
    {
        public Process process { get; }

        public string processName { get; private set; }
        private Utils.ProcessMemoryReader PMR { get; set; }
        public int currentNameAddress { get; set; }
        public int currentHPBaseAddress { get; set; }
        private int statusBufferAddress { get; set; }
        private int _num = 0;

        public Client(string processName, int currentHPBaseAddress, int currentNameAddress)
        {
            this.currentNameAddress = currentNameAddress;
            this.currentHPBaseAddress = currentHPBaseAddress;
            this.processName = processName;
            this.statusBufferAddress = currentHPBaseAddress + 0x474;
        }

        public Client(ClientDTO dto)
        {
            this.processName = dto.name;
            this.currentHPBaseAddress = Convert.ToInt32(dto.hpAddress, 16);
            this.currentNameAddress = Convert.ToInt32(dto.nameAddress, 16);
            this.statusBufferAddress = this.currentHPBaseAddress + 0x474;
        }

        public Client(string processName)
        {
            PMR = new Utils.ProcessMemoryReader();
            string rawProcessName = processName.Split(new string[] { ".exe - " }, StringSplitOptions.None)[0];
            int choosenPID = int.Parse(processName.Split(new string[] { ".exe - " }, StringSplitOptions.None)[1]);

            foreach (Process process in Process.GetProcessesByName(rawProcessName))
            {
                if (choosenPID == process.Id)
                {
                    this.process = process;
                    PMR.ReadProcess = process;
                    PMR.OpenProcess();

                    try
                    {
                        Client c = GetClientByProcess(rawProcessName);

                        if (c == null) throw new Exception();

                        this.currentHPBaseAddress = c.currentHPBaseAddress;
                        this.currentNameAddress = c.currentNameAddress;
                        this.statusBufferAddress = c.statusBufferAddress;
                    }catch
                    {
                        MessageBox.Show("This client is not supported. Only Spammers and macro will works.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        this.currentHPBaseAddress = 0;
                        this.currentNameAddress = 0;
                        this.statusBufferAddress = 0;
                    }
                   
                    //Do not block spammer for non supported Versions
                       
                }
            }
        }

        private string ReadMemoryAsString(int address)
        {
            byte[] bytes = PMR.ReadProcessMemory((IntPtr)address, 40u, out _num);
            List<byte> buffer = new List<byte>(); //Need a list with dynamic size 
            for (int i =0;i < bytes.Length;i++)
            {
                if (bytes[i] == 0) break; //Check Nullability based ON ASCII Table

                buffer.Add(bytes[i]); //Add only bytes needed
            }

           return Encoding.Default.GetString(buffer.ToArray());

        }

        private uint ReadMemory(int address)
        {
            return BitConverter.ToUInt32(PMR.ReadProcessMemory((IntPtr)address, 4u, out _num), 0);
        }
        public void WriteMemory(int address, uint intToWrite)
        {
            PMR.WriteProcessMemory((IntPtr)address, BitConverter.GetBytes(intToWrite), out _num);
        }

        public void WriteMemory(int address, byte[] bytesToWrite)
        {
            PMR.WriteProcessMemory((IntPtr)address, bytesToWrite, out _num);
        }

        public bool IsHpBelow(int percent)
        {
            return ReadCurrentHp() * 100 < percent * ReadMaxHp();
        }

        public bool IsSpBelow(int percent)
        {
            return ReadCurrentSp() * 100 < percent * ReadMaxSp();
        }

        public uint ReadCurrentHp()
        {
            return ReadMemory(this.currentHPBaseAddress);
        }

        public uint ReadCurrentSp()
        {
            return ReadMemory(this.currentHPBaseAddress + 8);
        }

        public uint ReadMaxHp()
        {
            return ReadMemory(this.currentHPBaseAddress + 4);
        }

        public string ReadCharacterName()
        {
            return ReadMemoryAsString(this.currentNameAddress);
        }

        public uint ReadMaxSp()
        {
            return ReadMemory(this.currentHPBaseAddress + 12);
        }

        public uint CurrentBuffStatusCode(int effectStatusIndex)
        {
            return ReadMemory(this.statusBufferAddress + effectStatusIndex * 4);
        }

        public Client GetClientByProcess(string processName)
        {
       
            foreach(Client c in ClientListSingleton.GetAll())
            {
                if (c.processName == processName)
                {
                    uint hpBaseValue = ReadMemory(c.currentHPBaseAddress);
                    if (hpBaseValue > 0) return c;
                }
            }
            return null;
        }
    
        public static Client FromDTO(ClientDTO dto)
        {
            return ClientListSingleton.GetAll()
                .Where(c => c.processName == dto.name)
                .Where(c => c.currentHPBaseAddress == dto.hpAddressPointer)
                .Where(c => c.currentNameAddress == dto.nameAddressPointer).FirstOrDefault();
        }
    }
}
