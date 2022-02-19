using System;
using System.Diagnostics;
using System.Runtime.InteropServices;


namespace _4RTools.Utils
{
    internal class ProcessMemoryReader
    {
        private class MemoryApi
        {
            [Flags]
            public enum AllocType
            {
                Commit = 0x1000,
                Reserve = 0x2000,
                Decommit = 0x4000
            }

            [Flags]
            public enum Protect
            {
                Execute = 0x10,
                ExecuteRead = 0x20,
                ExecuteReadWrite = 0x40,
            }
            [Flags]
            public enum FreeType
            {
                Decommit = 0x4000,
                Release = 0x8000,
            }

            [Flags]
            public enum ProcessAccessType
            {
                PROCESS_TERMINATE = 1,
                PROCESS_CREATE_THREAD = 2,
                PROCESS_SET_SESSIONID = 4,
                PROCESS_VM_OPERATION = 8,
                PROCESS_VM_READ = 16,
                PROCESS_VM_WRITE = 32,
                PROCESS_DUP_HANDLE = 64,
                PROCESS_CREATE_PROCESS = 128,
                PROCESS_SET_QUOTA = 256,
                PROCESS_SET_INFORMATION = 512,
                PROCESS_QUERY_INFORMATION = 1024
            }

            [DllImport("kernel32.dll")]
            public static extern IntPtr OpenProcess(uint dwDesiredAccess, int bInheritHandle, uint dwProcessId);
            [DllImport("kernel32.dll")]
            public static extern int CloseHandle(IntPtr hObject);
            [DllImport("kernel32.dll")]
            public static extern int ReadProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, [In][Out] byte[] buffer, uint size, out IntPtr lpNumberOfBytesRead);
            [DllImport("kernel32.dll")]
            public static extern int WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, [In][Out] byte[] buffer, uint size, out IntPtr lpNumberOfBytesWritten);

            [DllImport("kernel32.dll")]
            public static extern Int32 VirtualAllocEx(IntPtr hProcess, IntPtr lpAddress, int dwSize, AllocType flAllocationType, Protect flProtect);
            [DllImport("kernel32.dll")]
            public static extern bool VirtualFreeEx(IntPtr hProcess, IntPtr lpAddress, int dwSize, FreeType dwFreeType);
        }

        private Process m_ReadProcess = null;
        private IntPtr m_hProcess = IntPtr.Zero;
        public Process ReadProcess
        {
            get
            {
                return this.m_ReadProcess;
            }
            set
            {
                this.m_ReadProcess = value;
            }
        }
        public void OpenProcess()
        {
            MemoryApi.ProcessAccessType dwDesiredAccess = MemoryApi.ProcessAccessType.PROCESS_VM_OPERATION | MemoryApi.ProcessAccessType.PROCESS_VM_READ | MemoryApi.ProcessAccessType.PROCESS_VM_WRITE;
            this.m_hProcess = MemoryApi.OpenProcess((uint)dwDesiredAccess, 1, (uint)this.m_ReadProcess.Id);
        }
        public void CloseHandle()
        {
            int num = MemoryApi.CloseHandle(this.m_hProcess);
            if (num == 0)
            {
                throw new Exception("CloseHandle failed");
            }
        }
        public byte[] ReadProcessMemory(IntPtr MemoryAddress, uint bytesToRead, out int bytesRead)
        {
            byte[] array = new byte[bytesToRead];
            IntPtr intPtr;
            MemoryApi.ReadProcessMemory(this.m_hProcess, MemoryAddress, array, bytesToRead, out intPtr);
            bytesRead = intPtr.ToInt32();
            return array;
        }
        public void WriteProcessMemory(IntPtr MemoryAddress, byte[] bytesToWrite, out int bytesWritten)
        {
            IntPtr intPtr;
            ProcessMemoryReader.MemoryApi.WriteProcessMemory(this.m_hProcess, MemoryAddress, bytesToWrite, (uint)bytesToWrite.Length, out intPtr);
            bytesWritten = intPtr.ToInt32();
        }


        public void Alloc(out int Addr, int Size)
        {
            Addr = MemoryApi.VirtualAllocEx(m_hProcess, IntPtr.Zero, Size, MemoryApi.AllocType.Commit, MemoryApi.Protect.ExecuteReadWrite);
        }
        public bool Dealloc(int Addr)
        {
            return MemoryApi.VirtualFreeEx(m_hProcess, (IntPtr)Addr, 0, MemoryApi.FreeType.Release);
        }
    }
}
