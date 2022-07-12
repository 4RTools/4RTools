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

        private static int MAX_POSSIBLE_HP = 1000000;
        private string execName { get; set; }
        private Utils.ProcessMemoryReader PMR { get; set; }
        private int currentNameAddress { get; set; }
        private int currentHPBaseAddress { get; set; }
        private int statusBufferAddress { get; set; }
        private int _num = 0;

        private Client(string execName, int currentHPBaseAddress, int currentNameAddress)
        {
            this.currentNameAddress = currentNameAddress;
            this.currentHPBaseAddress = currentHPBaseAddress;
            this.execName = execName;
            this.statusBufferAddress = currentHPBaseAddress + 0x474;
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

        public Client GetClientByProcess(string processName)
        {
       
            foreach(Client c in GetAll())
            {
                if (c.execName == processName)
                {
                    uint hpBaseValue = ReadMemory(c.currentHPBaseAddress);
                    if (hpBaseValue > 0 && hpBaseValue < MAX_POSSIBLE_HP) return c;
                }
            }
            return null;
        }


        private static List<Client> GetAll()
        {
            List<Client> clients = new List<Client>();

            clients.Add(new Client("rtales.bin", 0x00E8E434, 0x00E90C00));
            clients.Add(new Client("Jogar", 0x00E8E434, 0x00E90C00));
            clients.Add(new Client("RagnaRotico",0x00E4CAF4, 0x00E4D768));
            clients.Add(new Client("BattleOfSEARO",0x00E4CAF4, 0x00E4D768));
            clients.Add(new Client("EasyRO",0x010DCE10, 0x010DF5D8));
            clients.Add(new Client("Jogar",0x0101A700, 0x0101CEB0)); //Portal Kafra
            clients.Add(new Client("ragna4th",0x011D1A04, 0x011D43E8));
            clients.Add(new Client("ROZero",0x00F4942C, 0x00F4BD70));
            clients.Add(new Client("MiracleRO", 0x00E4CAF4, 0x00E4D768));
            clients.Add(new Client("PrimeRO",0x011D0A14, 0x011D33F8));
            clients.Add(new Client("NR_RO_4TH",0x011D0A14, 0x011C9684));
            clients.Add(new Client("Ragnarok", 0x011D0A14, 0x011D33F8)); //RagnaHistory
            clients.Add(new Client("BlueRO",0x011D1A04, 0x011D43E8));
            clients.Add(new Client("StreetRO 2.0",0x010DCE10, 0x010D5DA8));
            clients.Add(new Client("Gladius", 0x010DCE10, 0x010DF5D8));
            clients.Add(new Client("AllureWar", 0x01144144, 0x01146A18));
            clients.Add(new Client("AngelingRO", 0x010DCE10, 0x010DF5D8));
            clients.Add(new Client("Runa Ro", 0x00E73D3C, 0x00E749D8));

            return clients;
        }

    }
}
