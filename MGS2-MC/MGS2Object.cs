using System;

namespace MGS2_MC
{
    #region Internals
    internal class GameObject
    {
        internal string _name = "";
        internal IntPtr _nameOffset;
    }

    public interface IMGS2Object
    {
    }

    public abstract class MGS2Object : IMGS2Object
    {
        internal GameObject gameObject { get; set; }
        public string Name { get { return gameObject._name; } }
        public IntPtr NameMemoryOffset { get { return gameObject._nameOffset; } }

        public MGS2Object(string name, IntPtr nameMemoryOffset)
        {
            gameObject = new GameObject { _name = name, _nameOffset = nameMemoryOffset };
        }

        public void ChangeName(string name)
        {
            GameObject newGameObject = new GameObject { _name = name, _nameOffset = NameMemoryOffset };
            gameObject = newGameObject;
        }

        internal abstract void ToggleObject();
    }

    public class Durability
    {
        public dynamic Value { get; set; } //TODO: hard type this instead of dynamic. frick pythonic code. prolly int or float

        public Durability(dynamic value) {  Value = value; }
    }
    #endregion

    #region Item Classes
    public class BasicItem : MGS2Object
    {
        internal int InventoryOffset { get; set; }
        public BasicItem(string name, IntPtr nameMemoryOffset, int inventoryOffset) : base(name, nameMemoryOffset)
        {
            InventoryOffset = inventoryOffset;
        }

        internal override void ToggleObject()
        {
            MGS2MemoryManager.ToggleObject(InventoryOffset);
        }

        public void ToggleItem()
        {
            ToggleObject();
        }
    }

    public class LevelableItem : BasicItem
    {
        internal short Level { get; set; }

        public LevelableItem(string name, IntPtr nameMemoryOffset, int inventoryOffset, short level) : base(name, nameMemoryOffset, inventoryOffset)
        {
            Level = level;
        }

        public void SetLevel(short level)
        {
            //TODO: figure out logic for levels
            MGS2MemoryManager.UpdateObjectCurrentCount(this, level);
            Level = level;
        }
    }

    public class DurabilityItem : BasicItem
    {
        internal Durability Durability { get; set; }
        public DurabilityItem(string name, IntPtr nameMemoryOffset, int inventoryOffset, Durability durability) : base(name, nameMemoryOffset, inventoryOffset)
        {
            Durability = durability;
        }

        public void SetDurability(dynamic value)
        {
            Durability.Value = value;
        }
    }

    public class StackableItem : BasicItem
    {
        private int MIN_MAX_COUNT_DIFF = 96;
        internal int CountOffset { get; set; }
        internal int MaxCountOffset { get; set; }
        private short LastKnownCurrent = 1;
        public StackableItem(string name, IntPtr nameMemoryOffset, int inventoryOffset) : base(name, nameMemoryOffset, inventoryOffset)
        {
            CountOffset = inventoryOffset;
            MaxCountOffset = inventoryOffset + MIN_MAX_COUNT_DIFF;
        }

        public void UpdateCurrentCount(short count)
        {
            MGS2MemoryManager.UpdateObjectCurrentCount(this, count);
        }

        public new void ToggleItem()
        {
            //read current count: if 0, we are enabling, otherwise, disable
            short currentCount = BitConverter.ToInt16(MGS2MemoryManager.GetCurrentValue(CountOffset, sizeof(short)), 0);
            if (currentCount != 0)
            {
                LastKnownCurrent = currentCount;
                UpdateCurrentCount(0);
            }
            else
            {
                UpdateCurrentCount(LastKnownCurrent);
            }
        }

        public void UpdateMaxCount(short count)
        {
            MGS2MemoryManager.UpdateObjectMaxCount(this, count);
        }
    }
    #endregion

    #region Weapon Classes
    public class BasicWeapon : MGS2Object
    {
        public int InventoryOffset { get; set; }
        public BasicWeapon(string name, IntPtr nameMemoryOffset, int inventoryOffset) : base(name, nameMemoryOffset)
        {
            InventoryOffset = inventoryOffset;
        }

        internal override void ToggleObject()
        {
            MGS2MemoryManager.ToggleObject(InventoryOffset);
        }

        public void ToggleWeapon()
        {
            ToggleObject();
        }

        public void UpdateCurrentAmmoCount(int count)
        {
            short shortCount = (short)count;
            MGS2MemoryManager.UpdateObjectCurrentCount(this, shortCount);
        }
    }

    public class AmmoWeapon : BasicWeapon
    {
        private int MIN_MAX_COUNT_DIFF = 64;
        public int CurrentAmmoOffset { get { return InventoryOffset; } set { InventoryOffset = value; } }
        public int MaxAmmoOffset { get; set; }
        public AmmoWeapon(string name, IntPtr nameMemoryOffset, int inventoryOffset) : base(name, nameMemoryOffset, inventoryOffset)
        {
            CurrentAmmoOffset = inventoryOffset;
            MaxAmmoOffset = inventoryOffset + MIN_MAX_COUNT_DIFF;
         }
    }

    public class SpecialWeapon : BasicWeapon
    {
        public byte SpecialValue { get; set; }
        public SpecialWeapon(string name, IntPtr nameMemoryOffset, int inventoryOffset) : base(name, nameMemoryOffset, inventoryOffset)
        {
        }

        public new void ToggleWeapon()
        {
            ToggleObject();
        }
    }
    #endregion

    public class MGS2UsableObjects
    {
        private static int BASE_WEAPON_OFFSET = -66; //whenever a "new" "anchor" is chosen, only need to update this value and all others will update.
        private static int BASE_ITEM_OFFSET = BASE_WEAPON_OFFSET + 144;

        //TODO: update name pointers to, you know, real values :)
        #region Weapons
        #region Basic Weapons
        public static readonly BasicWeapon DMic = new BasicWeapon("Directional Microphone", IntPtr.Zero, BASE_WEAPON_OFFSET + 22); //GUI'd
        public static readonly BasicWeapon DMic2 = new BasicWeapon("Directional Microphone", IntPtr.Zero, BASE_WEAPON_OFFSET + 38); //GUI'd
        public static readonly BasicWeapon Coolant = new BasicWeapon("Coolant Spray", IntPtr.Zero, BASE_WEAPON_OFFSET + 26); //GUI'd
        #endregion
        #region Ammo Weapons
        public static readonly AmmoWeapon M9 = new AmmoWeapon("M9", IntPtr.Zero, BASE_WEAPON_OFFSET); //GUI'd
        public static readonly AmmoWeapon USP = new AmmoWeapon("USP", IntPtr.Zero, BASE_WEAPON_OFFSET + 2); //GUI'd
        public static readonly AmmoWeapon SOCOM = new AmmoWeapon("SOCOM", IntPtr.Zero, BASE_WEAPON_OFFSET + 4); //GUI'd
        public static readonly AmmoWeapon PSG1 = new AmmoWeapon("PSG1", IntPtr.Zero, BASE_WEAPON_OFFSET + 6); //GUI'd
        public static readonly AmmoWeapon RGB6 = new AmmoWeapon("RGB6", IntPtr.Zero, BASE_WEAPON_OFFSET + 8); //GUI'd
        public static readonly AmmoWeapon Nikita = new AmmoWeapon("Nikita", IntPtr.Zero, BASE_WEAPON_OFFSET + 10); //GUI'd
        public static readonly AmmoWeapon Stinger = new AmmoWeapon("Stinger", IntPtr.Zero, BASE_WEAPON_OFFSET + 12); //GUI'd
        public static readonly AmmoWeapon Claymore = new AmmoWeapon("Claymore", IntPtr.Zero, BASE_WEAPON_OFFSET + 14); //GUI'd
        public static readonly AmmoWeapon C4 = new AmmoWeapon("C4", IntPtr.Zero, BASE_WEAPON_OFFSET + 16); //GUI'd
        public static readonly AmmoWeapon ChaffGrenade = new AmmoWeapon("Chaff Grenade", IntPtr.Zero, BASE_WEAPON_OFFSET + 18); //GUI'd
        public static readonly AmmoWeapon StunGrenade = new AmmoWeapon("Stun Grenade", IntPtr.Zero, BASE_WEAPON_OFFSET + 20); //GUI'd
        public static readonly AmmoWeapon AKS74u = new AmmoWeapon("AKS74u", IntPtr.Zero, BASE_WEAPON_OFFSET + 28); //GUI'd
        public static readonly AmmoWeapon Magazine = new AmmoWeapon("Magazine", IntPtr.Zero, BASE_WEAPON_OFFSET + 30); //GUI'd
        public static readonly AmmoWeapon Grenade = new AmmoWeapon("Grenade", IntPtr.Zero, BASE_WEAPON_OFFSET + 32); //GUI'd
        public static readonly AmmoWeapon M4 = new AmmoWeapon("M4", IntPtr.Zero, BASE_WEAPON_OFFSET + 34); //GUI'd
        public static readonly AmmoWeapon PSG1T = new AmmoWeapon("PGS1-T", IntPtr.Zero, BASE_WEAPON_OFFSET + 36); //GUI'd
        public static readonly AmmoWeapon Book = new AmmoWeapon("Book", IntPtr.Zero, BASE_WEAPON_OFFSET + 40); //GUI'd
        #endregion
        #region Special Weapons
        public static readonly SpecialWeapon HighFrequencyBlade = new SpecialWeapon("HF Blade", IntPtr.Zero, BASE_WEAPON_OFFSET + 24); //GUI'd
        #endregion
        #endregion

        #region Items
        #region Basic Items
        public static readonly BasicItem SnakeBinoculars = new BasicItem("Binoculars", IntPtr.Zero, BASE_ITEM_OFFSET + 2);
        public static readonly BasicItem BodyArmor = new BasicItem("Body Armor", IntPtr.Zero, BASE_ITEM_OFFSET + 12);
        public static readonly BasicItem Stealth = new BasicItem("Stealth", IntPtr.Zero, BASE_ITEM_OFFSET + 14);
        public static readonly BasicItem MineDetector = new BasicItem("Mine Detector", IntPtr.Zero, BASE_ITEM_OFFSET + 16);
        public static readonly BasicItem SensorA = new BasicItem("Sensor A", IntPtr.Zero, BASE_ITEM_OFFSET + 18);
        public static readonly BasicItem SensorB = new BasicItem("Sensor B", IntPtr.Zero, BASE_ITEM_OFFSET + 20);
        public static readonly BasicItem NightVisionGoggles = new BasicItem("NVG", IntPtr.Zero, BASE_ITEM_OFFSET + 22);
        public static readonly BasicItem ThermalGoggles = new BasicItem("ThermalG", IntPtr.Zero, BASE_ITEM_OFFSET + 24);
        public static readonly BasicItem RaidenBinoculars = new BasicItem("Binoculars", IntPtr.Zero, BASE_ITEM_OFFSET + 26);
        public static readonly BasicItem DigitalCamera = new BasicItem("Digital Camera", IntPtr.Zero, BASE_ITEM_OFFSET + 28);
        public static readonly BasicItem Cigarettes = new BasicItem("Cigs", IntPtr.Zero, BASE_ITEM_OFFSET + 32);
        public static readonly BasicItem Shaver = new BasicItem("Shaver", IntPtr.Zero, BASE_ITEM_OFFSET + 36);
        public static readonly BasicItem Phone = new BasicItem("Phone", IntPtr.Zero, BASE_ITEM_OFFSET + 38);
        public static readonly BasicItem Camera1 = new BasicItem("Camera", IntPtr.Zero, BASE_ITEM_OFFSET + 40);
        public static readonly BasicItem APSensor = new BasicItem("AP Sensor", IntPtr.Zero, BASE_ITEM_OFFSET + 48);
        public static readonly BasicItem UnknownItem = new BasicItem("Unknown Item", IntPtr.Zero, BASE_ITEM_OFFSET + 54); //TODO: unused? need to confirm
        public static readonly BasicItem SocomSuppressor = new BasicItem("SOCOM Suppressor", IntPtr.Zero, BASE_ITEM_OFFSET + 56);
        public static readonly BasicItem AKSuppressor = new BasicItem("AK Suppressor", IntPtr.Zero, BASE_ITEM_OFFSET + 58);
        public static readonly BasicItem Camera2 = new BasicItem("Camera", IntPtr.Zero, BASE_ITEM_OFFSET + 60);
        public static readonly BasicItem Bandana = new BasicItem("Bandana", IntPtr.Zero, BASE_ITEM_OFFSET + 62);
        public static readonly BasicItem MODisc = new BasicItem("MODisc", IntPtr.Zero, BASE_ITEM_OFFSET + 66);
        public static readonly BasicItem USPSuppressor = new BasicItem("USP Suppressor", IntPtr.Zero, BASE_ITEM_OFFSET + 68);
        public static readonly BasicItem InfinityWig = new BasicItem("Infinity Wig", IntPtr.Zero, BASE_ITEM_OFFSET + 70);
        public static readonly BasicItem BlueWig = new BasicItem("Blue Wig", IntPtr.Zero, BASE_ITEM_OFFSET + 72);
        public static readonly BasicItem OrangeWig = new BasicItem("Orange Wig", IntPtr.Zero, BASE_ITEM_OFFSET + 74);
        public static readonly BasicItem ColorWig = new BasicItem("Color Wig", IntPtr.Zero, BASE_ITEM_OFFSET + 76); //unused
        public static readonly BasicItem ColorWig2 = new BasicItem("Color Wig 2", IntPtr.Zero, BASE_ITEM_OFFSET + 78); //unused
        #endregion
        #region Durability Items
        public static readonly DurabilityItem BDU = new DurabilityItem("BDU", IntPtr.Zero, BASE_ITEM_OFFSET + 10, new Durability(255)); //TODO: determine durability
        public static readonly DurabilityItem Box1 = new DurabilityItem("Box1", IntPtr.Zero, BASE_ITEM_OFFSET + 30, new Durability(255)); //TODO: determine durability
        public static readonly DurabilityItem Box2 = new DurabilityItem("Box2", IntPtr.Zero, BASE_ITEM_OFFSET + 42, new Durability(255)); //TODO: determine durability
        public static readonly DurabilityItem Box3 = new DurabilityItem("Box3", IntPtr.Zero, BASE_ITEM_OFFSET + 44, new Durability(255)); //TODO: determine durability
        public static readonly DurabilityItem WetBox = new DurabilityItem("WetBox", IntPtr.Zero, BASE_ITEM_OFFSET + 46, new Durability(255)); //TODO: determine durability
        public static readonly DurabilityItem Box4 = new DurabilityItem("Box4", IntPtr.Zero, BASE_ITEM_OFFSET + 50, new Durability(255)); //TODO: determine durability
        public static readonly DurabilityItem Box5 = new DurabilityItem("Box5", IntPtr.Zero, BASE_ITEM_OFFSET + 52, new Durability(255)); //TODO: determine durability
        #endregion
        #region Enumerable Items
        public static readonly StackableItem Ration = new StackableItem("Ration", IntPtr.Zero, BASE_ITEM_OFFSET);
        public static readonly StackableItem ColdMedicine = new StackableItem("Cold Medicine", IntPtr.Zero, BASE_ITEM_OFFSET + 4);
        public static readonly StackableItem Bandage = new StackableItem("Bandage", IntPtr.Zero, BASE_ITEM_OFFSET + 6);
        public static readonly StackableItem Pentazemin = new StackableItem("Pentazemin", IntPtr.Zero, BASE_ITEM_OFFSET + 8);
        public static readonly StackableItem DogTags = new StackableItem("DogTags", IntPtr.Zero, BASE_ITEM_OFFSET + 64);
        #endregion
        #region Levelable Items
        public static readonly LevelableItem Card = new LevelableItem("Card", IntPtr.Zero, BASE_ITEM_OFFSET + 34, 1); //TODO: determine card levels
        #endregion
        #endregion
    }
}
