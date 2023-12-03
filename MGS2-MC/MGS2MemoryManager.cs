using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MGS2_MC
{
    internal class MGS2MemoryManager
    {
        // PInvoke declarations
        public static class NativeMethods
        {
            // Declare OpenProcess
            [DllImport("kernel32.dll", SetLastError = true)]
            public static extern IntPtr OpenProcess(int dwDesiredAccess, bool bInheritHandle, int dwProcessId);

            // Declare WriteProcessMemory with short
            [DllImport("kernel32.dll", SetLastError = true)]
            public static extern bool WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, ref short lpBuffer, uint nSize, out int lpNumberOfBytesWritten);
            // and with bytes
            [DllImport("kernel32.dll", SetLastError = true)]
            public static extern bool WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, uint nSize, out int lpNumberOfBytesWritten);

            // Declare ReadProcessMemory
            [DllImport("kernel32.dll", SetLastError = true)]
            public static extern bool ReadProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, out short lpBuffer, uint size, out int lpNumberOfBytesRead);
            // and with bytes
            [DllImport("kernel32.dll")]
            public static extern bool ReadProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, uint nSize, out int lpNumberOfBytesRead);

            // Declare CloseHandle
            [DllImport("kernel32.dll", SetLastError = true)]
            public static extern bool CloseHandle(IntPtr hObject);
        }

        static IntPtr PROCESS_BASE_ADDRESS = IntPtr.Zero;

        private static Process GetMGS2Process()
        {
            Process process = Process.GetProcessesByName(MGS2Constants.PROCESS_NAME).FirstOrDefault(); //looks like NET framework doesn't support the ? operator here
            if (process == null)
            {
                throw new NullReferenceException();
            }
            return process;
        }

        private static int GetCurrentPlayerOffset(Process mgs2Process, IntPtr processHandle)
        {
            byte[] buffer = new byte[mgs2Process.PrivateMemorySize64];
            NativeMethods.ReadProcessMemory(processHandle, PROCESS_BASE_ADDRESS, buffer, (uint)buffer.Length, out int numBytesRead);
            // we now, theoretically, have the ENTIRETY of MGS2 loaded into this buffer. At this point, we now
            // need to scan through this buffer until we find the second to last grouping of MGS2Constants.PlayerOffsetBytes
            int byteCount = 0;
            List<int> playerPositions = new List<int>();
            while(byteCount + 8 < buffer.Length)
            {
                if (buffer[byteCount] == MGS2Constants.PlayerOffsetBytes[0] &&
                    buffer[byteCount + 1] == MGS2Constants.PlayerOffsetBytes[1] &&
                    buffer[byteCount + 2] == MGS2Constants.PlayerOffsetBytes[2] &&
                    buffer[byteCount + 3] == MGS2Constants.PlayerOffsetBytes[3] &&
                    buffer[byteCount + 4] == MGS2Constants.PlayerOffsetBytes[4] &&
                    buffer[byteCount + 5] == MGS2Constants.PlayerOffsetBytes[5] &&
                    buffer[byteCount + 6] == MGS2Constants.PlayerOffsetBytes[6] &&
                    buffer[byteCount + 7] == MGS2Constants.PlayerOffsetBytes[7])
                {
                    playerPositions.Add(byteCount);
                }
                byteCount += 8;
            }

            return playerPositions[0]; //need to verify this works for everything
        }

        private static byte[] ReadValueFromMemory(IntPtr processHandle, IntPtr objectAddress, byte[] bytesToRead = null)
        {
            if(bytesToRead == null)
            {
                bytesToRead = new byte[2];
            }

            bool success = NativeMethods.ReadProcessMemory(processHandle, objectAddress, bytesToRead, (uint) bytesToRead.Length, out int bytesRead);
            if (!success || bytesRead != bytesToRead.Length)
            {
                throw new FileLoadException($"Failed to read value at offset {processHandle}+{objectAddress}.");
            }

            return bytesToRead;
        }

        private static void ReadWriteBooleanValue(IntPtr processHandle, int objectOffset)
        {
            IntPtr booleanAddress = IntPtr.Add(PROCESS_BASE_ADDRESS, objectOffset);
            byte[] currentValue = ReadValueFromMemory(processHandle, booleanAddress);

            byte[] valueToWrite = currentValue == BitConverter.GetBytes((short)0) ? BitConverter.GetBytes((short)0) : BitConverter.GetBytes((short)1);

            try
            {
                ModifyByteValueObject(objectOffset, valueToWrite);
            }
            catch(Exception ex)
            {
                throw new AggregateException($"Failed to write boolean value at offset {processHandle}+{objectOffset}", ex);
            }
        }

        private static void ModifyByteValueObject(int objectOffset, byte[] value)
        {
            Process process;

            try
            {
                process = GetMGS2Process();
            }
            catch
            {
                throw new FileLoadException($"Cannot find process: {MGS2Constants.PROCESS_NAME}");
            }

            PROCESS_BASE_ADDRESS = process.MainModule.BaseAddress;
            IntPtr processHandle = NativeMethods.OpenProcess(0x1F0FFF, false, process.Id);
            int playerOffset = GetCurrentPlayerOffset(process, processHandle);
            int bytesWritten;

            byte[] buffer = value; // Value to write
            IntPtr targetAddress = IntPtr.Add(PROCESS_BASE_ADDRESS, (playerOffset + objectOffset)); // Adjusted to add base address

            bool success = NativeMethods.WriteProcessMemory(processHandle, targetAddress, buffer, (uint)buffer.Length, out bytesWritten);

            if (!success || bytesWritten != buffer.Length)
            {
                NativeMethods.CloseHandle(processHandle);
                throw new FileLoadException($"Failed to write memory with value {value}.");
            }

            if(objectOffset == -2 && success)
            {
                //the m9 max ammo is part of the player offset i chose, which is terrible, but i don't see a better option presently. should definitely find a different anchor going forward though
                MGS2Constants.PlayerOffsetBytes[6] = value[0];
                MGS2Constants.PlayerOffsetBytes[7] = value[1];
            }
            NativeMethods.CloseHandle(processHandle);
        }

        internal static void UpdateCurrentCount(MGS2Object mgs2Object, short count)
        {
            switch (mgs2Object)
            {
                case StackableItem stackableItem:
                    ModifyByteValueObject(stackableItem.InventoryOffset, BitConverter.GetBytes(count));
                    break;
                case AmmoWeapon ammoWeapon:
                    ModifyByteValueObject(ammoWeapon.InventoryOffset, BitConverter.GetBytes(count));
                    break;
            }
        }

        internal static void ToggleObject(int objectOffset)
        {
            Process process;

            try
            {
                process = GetMGS2Process();
            }
            catch
            {
                MessageBox.Show($"Cannot find process: {MGS2Constants.PROCESS_NAME}");
                return;
            }

            PROCESS_BASE_ADDRESS = process.MainModule.BaseAddress;
            IntPtr processHandle = NativeMethods.OpenProcess(0x1F0FFF, false, process.Id);
            int playerOffset = GetCurrentPlayerOffset(process, processHandle);

            try
            {
                ReadWriteBooleanValue(processHandle, playerOffset + objectOffset);
            }
            catch(Exception e)
            {
                throw new AggregateException("Failed to toggle object.", e);
            }
            finally
            {
                NativeMethods.CloseHandle(processHandle);
            }
        }
    }
}
