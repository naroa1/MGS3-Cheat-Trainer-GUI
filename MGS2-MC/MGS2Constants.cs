using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MGS2_MC
{
    internal class MGS2Constants
    {
        public const string PROCESS_NAME = "METAL GEAR SOLID2";
        //these commented offsets are old possible anchors i found that weren't consistent/usable
        //public static byte[] PlayerOffsetBytes = new byte[6] { 104, 01, 100, 00, 100, 00 }; // the CURRENT player offset will be the second to last one in memory.
        //public static IntPtr PlayerOffsetPtr = (IntPtr)0x680164006400;
        //public static byte[] PlayerOffsetBytes = new byte[] { 82, 82, 74, 41, 37, 148, 82, 74, 41, 145, 66, 170, 148, 82, 74, 41, 1, 132, 18, 80, 74, 165, 144, 145, 145, 145, 82, 162, 164, 148, 145, 82, 74, 41, 165, 148, 82, 74, 41, 73, 72, 33 };
        //public static IntPtr PlayerOffsetPtr = (IntPtr)0x52524A292594524A299142AA94524A29018412504AA59092929252A2A49492524A29A594524A29494821;
        public static byte[] PlayerOffsetBytes = new byte[] { 00, 00, 00, 00, 01, 00, 46, 00 };

        //These values are PRESENTLY unknown
        //internal const int HealthPointerOffset = 0x00AE49D8; 
        //internal const int CurrentHealthOffset = 0x684;
        //internal const int MaxHealthOffset = 0x686;
        //internal const int StaminaOffset = 0xA4A;
        //internal static IntPtr HudOffset = (IntPtr)0xADB40F;
        //internal static IntPtr CamOffset = (IntPtr)0xAE3B37;
        //internal static IntPtr AlertStatusOffset = (IntPtr)0x1D9C3D8;
    }
}
