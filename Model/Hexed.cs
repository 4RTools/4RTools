using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;

namespace _4RTools.Model
{
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
        private Utils.ProcessMemoryReader PMR { get; set; }
        private int clientVersion { get; set; }
        private int currentNameAddress { get; set; }
        private int currentHPBaseAddress { get; set; }
        private int statusBufferAddress { get; set; }
        private int _num = 0;

        private Client(int clientVersion, int currentHPBaseAddress, int currentNameAddress)
        {
            this.clientVersion = clientVersion;
            this.currentNameAddress = currentNameAddress;
            this.currentHPBaseAddress = currentHPBaseAddress;
            this.statusBufferAddress = currentHPBaseAddress + 0x474;
        }

        public Client(string processName)
        {
            PMR = new Utils.ProcessMemoryReader();
            string rawProcessName = processName.Split(new string[] { ".exe - " }, StringSplitOptions.None)[0];
            int choosenPID = int.Parse(processName.Split(new string[] { ".exe - " }, StringSplitOptions.None)[1]);
            List<Client> clients = GetAll();
            int maxPossibleHP = 999999;

            try
            {
                foreach (Process process in Process.GetProcessesByName(rawProcessName))
                {
                    if (choosenPID == process.Id)
                    {
                        this.process = process;
                        PMR.ReadProcess = process;
                        PMR.OpenProcess();

                        foreach (Client client in clients)
                        {
                            uint hpBaseValue = ReadMemory(client.currentHPBaseAddress); ;
                            if (hpBaseValue > 0 && hpBaseValue < maxPossibleHP)
                            {
                                this.clientVersion = client.clientVersion;
                                this.currentHPBaseAddress = client.currentHPBaseAddress;
                                this.currentNameAddress = client.currentNameAddress;
                                this.statusBufferAddress = client.statusBufferAddress;
                                break;
                            };
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Error while open process ! - {0}", ex.Message));
                Environment.Exit(0);
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

        public string HpLabel()
        {
            return string.Format("{0} / {1}", ReadCurrentHp(), ReadMaxHp());
        }

        public string SpLabel()
        {
            return string.Format("{0} / {1}", ReadCurrentSp(), ReadMaxSp());
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

        private static List<Client> GetAll()
        {
            List<Client> result = new List<Client>();
            result.Add(new Client(2019, 0x00E8E434, 0x00E90C00)); //Clients2019 (Tales, etc..)
            result.Add(new Client(2018, 0x0101A700, 0x0101CEB0)); //Clients2018 (Portal Kafra, etc...)
            result.Add(new Client(2017, 0x00D1CA6C, 0x00D1D288)); //Clients2017 (PowkRO, etc...)
            result.Add(new Client(2017, 0x00BC67E8, 0x00E4D768)); //Clients2017 (Maniacos, etc...)
            result.Add(new Client(2016, 0x0083E1B4, 0x00E90C00)); //Clients2016 (Remember RO, etc...)
            return result;
        }

    }
}
