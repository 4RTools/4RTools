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
        private int currentNameAddress { get; set; }
        private int currentHPBaseAddress { get; set; }
        private int statusBufferAddress { get; set; }
        private int _num = 0;

        private Client(int currentHPBaseAddress, int currentNameAddress)
        {
            this.currentNameAddress = currentNameAddress;
            this.currentHPBaseAddress = currentHPBaseAddress;
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

                        this.currentHPBaseAddress = c.currentHPBaseAddress;
                        this.currentNameAddress = c.currentNameAddress;
                        this.statusBufferAddress = c.statusBufferAddress;
                    }catch (Exception ex)
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
            try
            {
                return GetAll()[processName];
            }
            catch
            {
                throw new KeyNotFoundException("Selected process isn't supportable ("+processName+").");
            }
        }


        private static Dictionary<string, Client> GetAll()
        {
            Dictionary<string,Client> result = new Dictionary<string, Client>();

            result.Add("rtales.bin", new Client(0x00E8E434, 0x00E90C00));
            result.Add("RagnaRotico",new Client(0x00E4CAF4, 0x00E4D768));
            result.Add("EasyRO", new Client(0x010DCE10, 0x010DF5D8));
            result.Add("Jogar",new Client(0x0101A700, 0x0101CEB0)); //Portal Kafra
            result.Add("ragna4th", new Client(0x011D1A04, 0x011D43E8));
            result.Add("ROZero",new Client(0x00F4942C, 0x00F4BD70));
            result.Add("MiracleRO",new Client(0x01107BEC, 0x0110A5B0));
            result.Add("PrimeRO", new Client(0x011D0A14, 0x011D33F8));
            result.Add("NR_RO_4TH+", new Client(0x011D0A14, 0x011C9684));

            return result;
        }

    }
}
