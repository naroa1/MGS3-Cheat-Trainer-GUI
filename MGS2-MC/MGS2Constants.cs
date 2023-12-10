using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MGS2_MC
{
    internal class MGS2Constants
    {
        /*useful information from @ANTIBigBoss irt GoG port CT:
         * 
         * MaxLife = 2 bytes
         * AmmoInClip = 4 bytes(original offset of 618B2C == 6392620)
         * FPV State = array bytes(original offset of 9C18C == 639372)
         * FPV = byte(original offset of 618B03 == 6392579)
         * CurrentLevel = 7 char string
         * CurrentWeapon = 2 bytes
         * LifeText = 15 char string
         * End if found = 1 byte
         * Walk through walls = 1 byte
         * Walk through walls(soft) = 1 byte
         * 
         */

        public const string PROCESS_NAME = "METAL GEAR SOLID2";
        //these commented offsets are old possible anchors i found that weren't consistent/usable
        //public static byte[] PlayerOffsetBytes = new byte[6] { 104, 01, 100, 00, 100, 00 }; // the CURRENT player offset will be the second to last one in memory.
        //public static IntPtr PlayerOffsetPtr = (IntPtr)0x680164006400;
        //public static byte[] PlayerOffsetBytes = new byte[] { 82, 82, 74, 41, 37, 148, 82, 74, 41, 145, 66, 170, 148, 82, 74, 41, 1, 132, 18, 80, 74, 165, 144, 145, 145, 145, 82, 162, 164, 148, 145, 82, 74, 41, 165, 148, 82, 74, 41, 73, 72, 33 };
        //public static IntPtr PlayerOffsetPtr = (IntPtr)0x52524A292594524A299142AA94524A29018412504AA59092929252A2A49492524A29A594524A29494821;
        public static byte[] PlayerOffsetBytes = new byte[] { 00, 00, 00, 00, 01, 00, 46, 00 };

        public const int BASE_WEAPON_OFFSET = -66; //whenever a "new" "anchor" is chosen, only need to update this value and all others will update.
        public const int BASE_ITEM_OFFSET = BASE_WEAPON_OFFSET + 144;

        //These values are PRESENTLY unknown
        //internal const int HealthPointerOffset = 0x00AE49D8; 
        //internal const int CurrentHealthOffset = 0x684;
        //internal const int MaxHealthOffset = 0x686;
        //internal const int StaminaOffset = 0xA4A;
        //internal static IntPtr HudOffset = (IntPtr)0xADB40F;
        //internal static IntPtr CamOffset = (IntPtr)0xAE3B37;
        //internal static IntPtr AlertStatusOffset = (IntPtr)0x1D9C3D8;

        #region Item Table
        public const int RationOffset = 0;
        public const int SnakeBinocularsOffset = 2;
        public const int ColdMedicineOffset = 4;
        public const int BandageOffset = 6;
        public const int PentazeminOffset = 8;
        public const int BDUOffset = 10;
        public const int BodyArmorOffset = 12;
        public const int StealthOffset = 14;
        public const int MineDetectorOffset = 16;
        public const int SensorAOffset = 18;
        public const int SensorBOffset = 20;
        public const int NightVisionGogglesOffset = 22;
        public const int ThermalGogglesOffset = 24;
        public const int RaidenBinocularsOffset = 26;
        public const int DigitalCameraOffset = 28;
        public const int Box1Offset = 30;
        public const int CigarettesOffset = 32;
        public const int CardOffset = 34;
        public const int ShaverOffset = 36;
        public const int PhoneOffset = 38;
        public const int Camera1Offset = 40;
        public const int Box2Offset = 42;
        public const int Box3Offset = 44;
        public const int WetBoxOffset = 46;
        public const int APSensorOffset = 48;
        public const int Box4Offset = 50;
        public const int Box5Offset = 52;
        public const int UnknownItemOffset = 54;
        public const int SocomSuppressorOffset = 56;
        public const int AKSuppressorOffset = 58;
        public const int Camera2Offset = 60;
        public const int BandanaOffset = 62;
        public const int DogTagsOffset = 64;
        public const int MODiscOffset = 66;
        public const int USPSuppressorOffset = 68;
        public const int InfinityWigOffset = 70;
        public const int BlueWigOffset = 72;
        public const int OrangeWigOffset = 74;
        public const int ColorWigOffset = 76;
        public const int ColorWig2Offset = 78;
        #endregion

        #region Weapon Table
        public const int M9Offset = 0;
        public const int USPOffset = 2;
        public const int SOCOMOffset = 4;
        public const int PSG1Offset = 6;
        public const int RGB6Offset = 8;
        public const int NikitaOffset = 10;
        public const int StingerOffset = 12;
        public const int ClaymoreOffset = 14;
        public const int C4Offset = 16;
        public const int ChaffGrenadeOffset = 18;
        public const int StunGrenadeOffset = 20;
        public const int DMicOffset = 22;
        public const int HighFrequencyBladeOffset = 24;
        public const int CoolantOffset = 26;
        public const int AKS74uOffset = 28;
        public const int MagazineOffset = 30;
        public const int GrenadeOffset = 32;
        public const int M4Offset = 34;
        public const int PSG1TOffset = 36;
        public const int DMic2Offset = 38;
        public const int BookOffset = 40;
        #endregion
    }
}
