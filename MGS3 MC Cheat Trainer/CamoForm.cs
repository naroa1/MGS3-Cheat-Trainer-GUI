﻿// No usings needed?

namespace MGS3_MC_Cheat_Trainer
{
    public partial class CamoForm : Form
    {

        const string PROCESS_NAME = "METAL GEAR SOLID3";
        static IntPtr PROCESS_BASE_ADDRESS = IntPtr.Zero;

        // PInvoke declarations
        [System.Runtime.InteropServices.DllImport("kernel32.dll")]
        public static extern IntPtr OpenProcess(int dwDesiredAccess, bool bInheritHandle, int dwProcessId);

        [System.Runtime.InteropServices.DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, ref short lpBuffer, uint nSize, out int lpNumberOfBytesWritten);

        [System.Runtime.InteropServices.DllImport("kernel32.dll")]

        public static extern bool ReadProcessMemory(
        IntPtr hProcess,
        IntPtr lpBaseAddress,
        out short lpBuffer,
        uint size,
        out int lpNumberOfBytesRead);

        [System.Runtime.InteropServices.DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool CloseHandle(IntPtr hObject);

        public CamoForm()
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(Form3_FormClosing);
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void WeaponFormSwap_Click(object sender, EventArgs e)
        {
            WeaponForm form1 = new WeaponForm();
            form1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ItemForm form2 = new ItemForm();
            form2.Show();
            this.Hide();
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e) // Load form4
        {
            MiscForm form4 = new MiscForm();
            form4.Show();
            this.Hide();
        }

        // We should do the same boolean logic for camo only difference is that 1 means camo is obtained and 0 means it is not
        /*private void WriteValueToMemory(int index, short value)
        {
            var process = System.Diagnostics.Process.GetProcessesByName(PROCESS_NAME).FirstOrDefault();
            if (process == null)
            {
                MessageBox.Show($"Cannot find process: {PROCESS_NAME}");
                return;
            }

            PROCESS_BASE_ADDRESS = process.MainModule.BaseAddress;
            var processHandle = OpenProcess(0x1F0FFF, false, process.Id);

            IntPtr address = IntPtr.Add(PROCESS_BASE_ADDRESS, (int)CAMO_OFFSETS[index]);
            int bytesWritten;

            bool success = WriteProcessMemory(processHandle, address, ref value, sizeof(short), out bytesWritten);

            CloseHandle(processHandle);
        }*/

        private void AddWoodland_Click(object sender, EventArgs e)
        {
            MemoryManager.ToggleCamoState(MGS3UsableObjects.Woodland, true);
        }

        private void RemoveWoodland_Click(object sender, EventArgs e)
        {
            MemoryManager.ToggleCamoState(MGS3UsableObjects.Woodland, false);
        }

        private void AddBlackPaint_Click(object sender, EventArgs e)
        {
            MemoryManager.ToggleCamoState(MGS3UsableObjects.BlackFace, true);
        }

        private void RemoveBlackPaint_Click(object sender, EventArgs e)
        {
            MemoryManager.ToggleCamoState(MGS3UsableObjects.BlackFace, false);
        }

        private void AddWater_Click(object sender, EventArgs e)
        {
            MemoryManager.ToggleCamoState(MGS3UsableObjects.WaterFace, true);
        }

        private void RemoveWaterPaint_Click(object sender, EventArgs e)
        {
            MemoryManager.ToggleCamoState(MGS3UsableObjects.WaterFace, false);
        }

        private void AddDesert_Click(object sender, EventArgs e)
        {
            MemoryManager.ToggleCamoState(MGS3UsableObjects.Desert, true);
        }

        private void RemoveDesert_Click(object sender, EventArgs e)
        {
            MemoryManager.ToggleCamoState(MGS3UsableObjects.Desert, false);
        }

        private void AddSplitterPaint_Click(object sender, EventArgs e)
        {
            MemoryManager.ToggleCamoState(MGS3UsableObjects.SplitterFace, true);
        }

        private void RemoveSplitterPaint_Click(object sender, EventArgs e)
        {
            MemoryManager.ToggleCamoState(MGS3UsableObjects.SplitterFace, false);
        }

        private void AddSnowPaint_Click(object sender, EventArgs e)
        {
            MemoryManager.ToggleCamoState(MGS3UsableObjects.SnowFace, true);
        }

        private void RemoveSnowPaint_Click(object sender, EventArgs e)
        {
            MemoryManager.ToggleCamoState(MGS3UsableObjects.SnowFace, false);
        }

        private void AddKabuki_Click(object sender, EventArgs e)
        {
            MemoryManager.ToggleCamoState(MGS3UsableObjects.Kabuki, true);
        }

        private void RemoveKabuki_Click(object sender, EventArgs e)
        {
            MemoryManager.ToggleCamoState(MGS3UsableObjects.Kabuki, false);
        }

        private void AddZombie_Click(object sender, EventArgs e)
        {
            MemoryManager.ToggleCamoState(MGS3UsableObjects.Zombie, true);
        }

        private void RemoveZombie_Click(object sender, EventArgs e)
        {
            MemoryManager.ToggleCamoState(MGS3UsableObjects.Zombie, false);
        }

        private void AddOyama_Click(object sender, EventArgs e)
        {
            MemoryManager.ToggleCamoState(MGS3UsableObjects.Oyama, true);
        }

        private void RemoveOyama_Click(object sender, EventArgs e)
        {
            MemoryManager.ToggleCamoState(MGS3UsableObjects.Oyama, false);
        }

        private void AddMask_Click(object sender, EventArgs e)
        {
            MemoryManager.ToggleCamoState(MGS3UsableObjects.Mask, true);
        }

        private void RemoveMask_Click(object sender, EventArgs e)
        {
            MemoryManager.ToggleCamoState(MGS3UsableObjects.Mask, false);
        }

        private void AddGreen_Click(object sender, EventArgs e)
        {
            MemoryManager.ToggleCamoState(MGS3UsableObjects.Green, true);
        }

        private void RemoveGreen_Click(object sender, EventArgs e)
        {
            MemoryManager.ToggleCamoState(MGS3UsableObjects.Green, false);
        }

        private void AddBrown_Click(object sender, EventArgs e)
        {
            MemoryManager.ToggleCamoState(MGS3UsableObjects.Brown, true);
        }

        private void RemoveBrown_Click(object sender, EventArgs e)
        {
            MemoryManager.ToggleCamoState(MGS3UsableObjects.Brown, false);
        }

        private void AddInfinity_Click(object sender, EventArgs e)
        {
            MemoryManager.ToggleCamoState(MGS3UsableObjects.Infinity, true);
        }

        private void RemoveInfinity_Click(object sender, EventArgs e)
        {
            MemoryManager.ToggleCamoState(MGS3UsableObjects.Infinity, false);
        }

        private void AddSovietUnion_Click(object sender, EventArgs e)
        {
            MemoryManager.ToggleCamoState(MGS3UsableObjects.SovietUnion, true);
        }

        private void RemoveSovietUnion_Click(object sender, EventArgs e)
        {
            MemoryManager.ToggleCamoState(MGS3UsableObjects.SovietUnion, false);
        }

        private void AddUK_Click(object sender, EventArgs e)
        {
            MemoryManager.ToggleCamoState(MGS3UsableObjects.UK, true);
        }

        private void RemoveUK_Click(object sender, EventArgs e)
        {
            MemoryManager.ToggleCamoState(MGS3UsableObjects.UK, false);
        }

        private void AddFrance_Click(object sender, EventArgs e)
        {
            MemoryManager.ToggleCamoState(MGS3UsableObjects.France, true);
        }

        private void RemoveFrance_Click(object sender, EventArgs e)
        {
            MemoryManager.ToggleCamoState(MGS3UsableObjects.France, false);
        }

        private void AddGermany_Click(object sender, EventArgs e)
        {
            MemoryManager.ToggleCamoState(MGS3UsableObjects.Germany, true);
        }

        private void RemoveGermany_Click(object sender, EventArgs e)
        {
            MemoryManager.ToggleCamoState(MGS3UsableObjects.Germany, false);
        }

        private void AddItaly_Click(object sender, EventArgs e)
        {
            MemoryManager.ToggleCamoState(MGS3UsableObjects.Italy, true);
        }

        private void RemoveItaly_Click(object sender, EventArgs e)
        {
            MemoryManager.ToggleCamoState(MGS3UsableObjects.Italy, false);
        }

        private void AddSpain_Click(object sender, EventArgs e)
        {
            MemoryManager.ToggleCamoState(MGS3UsableObjects.Spain, true);
        }

        private void RemoveSpain_Click(object sender, EventArgs e)
        {
            MemoryManager.ToggleCamoState(MGS3UsableObjects.Spain, false);
        }

        private void AddSweden_Click(object sender, EventArgs e)
        {
            MemoryManager.ToggleCamoState(MGS3UsableObjects.Sweden, true);
        }

        private void RemoveSweden_Click(object sender, EventArgs e)
        {
            MemoryManager.ToggleCamoState(MGS3UsableObjects.Sweden, false);
        }

        private void AddJapan_Click(object sender, EventArgs e)
        {
            MemoryManager.ToggleCamoState(MGS3UsableObjects.Japan, true);
        }

        private void RemoveJapan_Click(object sender, EventArgs e)
        {
            MemoryManager.ToggleCamoState(MGS3UsableObjects.Japan, false);
        }

        private void AddUSA_Click(object sender, EventArgs e)
        {
            MemoryManager.ToggleCamoState(MGS3UsableObjects.USA, true);
        }

        private void RemoveUSA_Click(object sender, EventArgs e)
        {
            MemoryManager.ToggleCamoState(MGS3UsableObjects.USA, false);
        }

        private void AddOliveDrab_Click(object sender, EventArgs e)
        {
            MemoryManager.ToggleCamoState(MGS3UsableObjects.OliveDrab, true);
        }

        private void RemoveOliveDrab_Click(object sender, EventArgs e)
        {
            MemoryManager.ToggleCamoState(MGS3UsableObjects.OliveDrab, false);
        }

        private void AddTigerStripe_Click(object sender, EventArgs e)
        {
            MemoryManager.ToggleCamoState(MGS3UsableObjects.TigerStripe, true);
        }

        private void RemoveTigerStripe_Click(object sender, EventArgs e)
        {
            MemoryManager.ToggleCamoState(MGS3UsableObjects.TigerStripe, false);
        }

        private void AddLeaf_Click(object sender, EventArgs e)
        {
            MemoryManager.ToggleCamoState(MGS3UsableObjects.Leaf, true);
        }

        private void RemoveLeaf_Click(object sender, EventArgs e)
        {
            MemoryManager.ToggleCamoState(MGS3UsableObjects.Leaf, false);
        }

        private void AddTreeBark_Click(object sender, EventArgs e)
        {
            MemoryManager.ToggleCamoState(MGS3UsableObjects.TreeBark, true);
        }

        private void RemoveTreeBark_Click(object sender, EventArgs e)
        {
            MemoryManager.ToggleCamoState(MGS3UsableObjects.TreeBark, false);
        }

        private void AddChocoChip_Click(object sender, EventArgs e)
        {
            MemoryManager.ToggleCamoState(MGS3UsableObjects.ChocoChip, true);
        }

        private void RemoveChocoChip_Click(object sender, EventArgs e)
        {
            MemoryManager.ToggleCamoState(MGS3UsableObjects.ChocoChip, false);
        }

        private void AddSplitterBody_Click(object sender, EventArgs e)
        {
            MemoryManager.ToggleCamoState(MGS3UsableObjects.Splitter, true);
        }

        private void RemoveSplitterBody_Click(object sender, EventArgs e)
        {
            MemoryManager.ToggleCamoState(MGS3UsableObjects.Splitter, false);
        }

        private void AddRaindrop_Click(object sender, EventArgs e)
        {
            MemoryManager.ToggleCamoState(MGS3UsableObjects.Raindrop, true);
        }

        private void RemoveRaindrop_Click(object sender, EventArgs e)
        {
            MemoryManager.ToggleCamoState(MGS3UsableObjects.Raindrop, false);
        }

        private void AddSquare_Click(object sender, EventArgs e)
        {
            MemoryManager.ToggleCamoState(MGS3UsableObjects.Squares, true);
        }

        private void RemoveSquares_Click(object sender, EventArgs e)
        {
            MemoryManager.ToggleCamoState(MGS3UsableObjects.Squares, false);
        }

        private void AddWaterBody_Click(object sender, EventArgs e)
        {
            MemoryManager.ToggleCamoState(MGS3UsableObjects.Water, true);
        }

        private void RemoveWaterBody_Click(object sender, EventArgs e)
        {
            MemoryManager.ToggleCamoState(MGS3UsableObjects.Water, false);
        }

        private void AddBlackBody_Click(object sender, EventArgs e)
        {
            MemoryManager.ToggleCamoState(MGS3UsableObjects.Black, true);
        }

        private void RemoveBlackBody_Click(object sender, EventArgs e)
        {
            MemoryManager.ToggleCamoState(MGS3UsableObjects.Black, false);
        }

        private void AddSnowBody_Click(object sender, EventArgs e)
        {
            MemoryManager.ToggleCamoState(MGS3UsableObjects.Snow, true);
        }

        private void RemoveSnowBody_Click(object sender, EventArgs e)
        {
            MemoryManager.ToggleCamoState(MGS3UsableObjects.Snow, false);
        }

        private void AddSneakingSuit_Click(object sender, EventArgs e)
        {
            MemoryManager.ToggleCamoState(MGS3UsableObjects.SneakingSuit, true);
        }

        private void RemoveSneakingSuit_Click(object sender, EventArgs e)
        {
            MemoryManager.ToggleCamoState(MGS3UsableObjects.SneakingSuit, false);
        }

        private void AddScientist_Click(object sender, EventArgs e)
        {
            MemoryManager.ToggleCamoState(MGS3UsableObjects.Scientist, true);
        }

        private void RemoveScientist_Click(object sender, EventArgs e)
        {
            MemoryManager.ToggleCamoState(MGS3UsableObjects.Scientist, false);
        }

        private void AddOfficer_Click(object sender, EventArgs e)
        {
            MemoryManager.ToggleCamoState(MGS3UsableObjects.Officer, true);
        }

        private void RemoveOfficer_Click(object sender, EventArgs e)
        {
            MemoryManager.ToggleCamoState(MGS3UsableObjects.Officer, false);
        }

        private void AddMaintenance_Click(object sender, EventArgs e)
        {
            MemoryManager.ToggleCamoState(MGS3UsableObjects.Maintenance, true);
        }

        private void RemoveMaintenance_Click(object sender, EventArgs e)
        {
            MemoryManager.ToggleCamoState(MGS3UsableObjects.Maintenance, false);
        }

        private void AddTuxedo_Click(object sender, EventArgs e)
        {
            MemoryManager.ToggleCamoState(MGS3UsableObjects.Tuxedo, true);
        }

        private void RemoveTuxedo_Click(object sender, EventArgs e)
        {
            MemoryManager.ToggleCamoState(MGS3UsableObjects.Tuxedo, false);
        }

        private void AddHornetStripe_Click(object sender, EventArgs e)
        {
            MemoryManager.ToggleCamoState(MGS3UsableObjects.HornetStripe, true);
        }

        private void RemoveHornetStripe_Click(object sender, EventArgs e)
        {
            MemoryManager.ToggleCamoState(MGS3UsableObjects.HornetStripe, false);
        }

        private void AddMoss_Click(object sender, EventArgs e)
        {
            MemoryManager.ToggleCamoState(MGS3UsableObjects.Moss, true);
        }

        private void RemoveMoss_Click(object sender, EventArgs e)
        {
            MemoryManager.ToggleCamoState(MGS3UsableObjects.Moss, false);
        }

        private void Addfire_Click(object sender, EventArgs e)
        {
            MemoryManager.ToggleCamoState(MGS3UsableObjects.Fire, true);
        }

        private void RemoveFire_Click(object sender, EventArgs e)
        {
            MemoryManager.ToggleCamoState(MGS3UsableObjects.Fire, false);
        }

        private void AddSpirit_Click(object sender, EventArgs e)
        {
            MemoryManager.ToggleCamoState(MGS3UsableObjects.Spirit, true);
        }

        private void RemoveSpirit_Click(object sender, EventArgs e)
        {
            MemoryManager.ToggleCamoState(MGS3UsableObjects.Spirit, false);
        }

        private void AddColdWar_Click(object sender, EventArgs e)
        {
            MemoryManager.ToggleCamoState(MGS3UsableObjects.ColdWar, true);
        }

        private void RemoveColdWar_Click(object sender, EventArgs e)
        {
            MemoryManager.ToggleCamoState(MGS3UsableObjects.ColdWar, false);
        }

        private void AddSnake_Click(object sender, EventArgs e)
        {
            MemoryManager.ToggleCamoState(MGS3UsableObjects.Snake, true);
        }

        private void RemoveSnake_Click(object sender, EventArgs e)
        {
            MemoryManager.ToggleCamoState(MGS3UsableObjects.Snake, false);
        }

        private void AddGaKo_Click(object sender, EventArgs e)
        {
            MemoryManager.ToggleCamoState(MGS3UsableObjects.GaKo, true);
        }

        private void RemoveGaKo_Click(object sender, EventArgs e)
        {
            MemoryManager.ToggleCamoState(MGS3UsableObjects.GaKo, false);
        }

        private void AddDesertTiger_Click(object sender, EventArgs e)
        {
            MemoryManager.ToggleCamoState(MGS3UsableObjects.DesertTiger, true);
        }

        private void RemoveDesertTiger_Click(object sender, EventArgs e)
        {
            MemoryManager.ToggleCamoState(MGS3UsableObjects.DesertTiger, false);
        }

        private void AddDPM_Click(object sender, EventArgs e)
        {
            MemoryManager.ToggleCamoState(MGS3UsableObjects.DPM, true);
        }

        private void RemoveDPM_Click(object sender, EventArgs e)
        {
            MemoryManager.ToggleCamoState(MGS3UsableObjects.DPM, false);
        }

        private void AddFlecktarn_Click(object sender, EventArgs e)
        {
            MemoryManager.ToggleCamoState(MGS3UsableObjects.Flecktarn, true);
        }

        private void RemoveFlecktarn_Click(object sender, EventArgs e)
        {
            MemoryManager.ToggleCamoState(MGS3UsableObjects.Flecktarn, false);
        }

        private void AddAuscam_Click(object sender, EventArgs e)
        {
            MemoryManager.ToggleCamoState(MGS3UsableObjects.Auscam, true);
        }

        private void RemoveAuscam_Click(object sender, EventArgs e)
        {
            MemoryManager.ToggleCamoState(MGS3UsableObjects.Auscam, false);
        }

        private void AddAnimals_Click(object sender, EventArgs e)
        {
            MemoryManager.ToggleCamoState(MGS3UsableObjects.Animals, true);
        }

        private void RemoveAnimals_Click(object sender, EventArgs e)
        {
            MemoryManager.ToggleCamoState(MGS3UsableObjects.Animals, false);
        }

        private void AddFly_Click(object sender, EventArgs e)
        {
            MemoryManager.ToggleCamoState(MGS3UsableObjects.Fly, true);
        }

        private void RemoveFly_Click(object sender, EventArgs e)
        {
            MemoryManager.ToggleCamoState(MGS3UsableObjects.Fly, false);
        }

        private void AddSpider_Click(object sender, EventArgs e)
        {
            MemoryManager.ToggleCamoState(MGS3UsableObjects.Spider, true);
        }

        private void RemoveSpider_Click(object sender, EventArgs e)
        {
            MemoryManager.ToggleCamoState(MGS3UsableObjects.Spider, false);
        }

        private void AddBanana_Click(object sender, EventArgs e)
        {
            MemoryManager.ToggleCamoState(MGS3UsableObjects.Banana, true);
        }

        private void RemoveBanana_Click(object sender, EventArgs e)
        {
            MemoryManager.ToggleCamoState(MGS3UsableObjects.Banana, false);
        }
    }
}