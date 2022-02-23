using System;
using System.Collections.Generic;
using System.Diagnostics;
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
        private int currentHPBaseAddress { get; set; }
        private int _num = 0;

        private Client(int clientVersion, int currentHPBaseAddress)
        {
            this.clientVersion = clientVersion;
            this.currentHPBaseAddress = currentHPBaseAddress;
        }

        public Client(string processName)
        {
            PMR = new Utils.ProcessMemoryReader();
            string rawProcessName = processName.Split(new string[] { ".exe - " }, StringSplitOptions.None)[0];
            int choosenPID = int.Parse(processName.Split(new string[] { ".exe - " }, StringSplitOptions.None)[1]);
            List<Client> clients = GetAll();
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
                            if (hpBaseValue > 0 && hpBaseValue < 50000)
                            {
                                this.clientVersion = client.clientVersion;
                                this.currentHPBaseAddress = client.currentHPBaseAddress;
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

        public uint ReadMaxSp()
        {
            return ReadMemory(this.currentHPBaseAddress + 12);
        }

        private static List<Client> GetAll()
        {
            List<Client> result = new List<Client>();
            result.Add(new Client(2019, 0x00E8E434)); //Clients2019 (Tales, etc..)
            result.Add(new Client(2018, 0x0101A700)); //Clients2018 (Portal Kafra, etc...)
            result.Add(new Client(21012014, 0x00AAEAD));
            result.Add(new Client(21012014, 0x00AAEAD));
            result.Add(new Client(21012014, 0x00AAEAD));
            result.Add(new Client(21012014, 0x00AAEAD));

            return result;
        }

    }
}
