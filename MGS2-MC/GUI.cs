using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MGS2_MC
{
    public partial class GUI : Form
    {
        public GUI()
        {
            InitializeComponent();
        }

        #region GUI getters
        private short CurrentRationValue()
        {
            return (short)rationCurrentUpDown.Value;
        }

        private short MaxRationValue()
        {
            return (short)rationMaxUpDown.Value;
        }

        private short CurrentBandageValue()
        {
            return (short)bandageCurrentUpDown.Value;
        }

        private short MaxBandageValue()
        {
            return (short)bandageMaxUpDown.Value;
        }

        private short CurrentPentazeminCount()
        {
            return (short)pentazeminCurrentUpDown.Value;
        }

        private short MaxPentazeminCount()
        {
            return (short)pentazeminMaxUpDown.Value;
        }

        private short CurrentDogTagCount()
        {
            return (short)dogTagsCurrentUpDown.Value;
        }

        private short MaxDogTagCount()
        {
            return (short)dogTagsMaxUpDown.Value;
        }

        private short CurrentColdMedsCount()
        {
            return (short)coldMedsCurrentUpDown.Value;
        }

        private short MaxColdMedsCount()
        {
            return (short)coldMedsMaxUpDown.Value;
        }

        private short CardSecurityLevel()
        {
            return (short)cardUpDown.Value;
        }

        private short M9CurrentAmmoCount()
        {
            return (short)m9CurrentUpDown.Value;
        }

        private short M9MaxAmmoCount()
        {
            return (short)m9MaxUpDown.Value;
        }

        private short UspCurrentAmmoCount()
        {
            return (short)uspCurrentUpDown.Value;
        }

        private short UspMaxAmmoCount()
        {
            return (short)uspMaxUpDown.Value;
        }

        private short SocomCurrentAmmoCount()
        {
            return (short)socomCurrentUpDown.Value;
        }

        private short SocomMaxAmmoCount()
        {
            return (short)socomMaxUpDown.Value;
        }

        private short Psg1CurrentAmmoCount()
        {
            return (short)psg1CurrentUpDown.Value;
        }

        private short Psg1MaxAmmoCount()
        {
            return (short)psg1MaxUpDown.Value;
        }

        private short Rgb6CurrentAmmoCount()
        {
            return (short)rgb6CurrentUpDown.Value;
        }

        private short Rgb6MaxAmmoCount()
        {
            return (short)rgb6MaxUpDown.Value;
        }

        private short NikitaCurrentAmmoCount()
        {
            return (short)nikitaCurrentUpDown.Value;
        }

        private short NikitaMaxAmmoCount()
        {
            return (short)nikitaMaxUpDown.Value;
        }

        private short StingerCurrentAmmoCount()
        {
            return (short)stingerCurrentUpDown.Value;
        }

        private short StingerMaxAmmoCount()
        {
            return (short)stingerMaxUpDown.Value;
        }

        private short C4CurrentAmmoCount()
        {
            return (short)c4CurrentUpDown.Value;
        }

        private short C4MaxAmmoCount()
        {
            return (short)c4MaxUpDown.Value;
        }

        private short AkCurrentAmmoCount()
        {
            return (short)akCurrentUpDown.Value;
        }

        private short AkMaxAmmoCount()
        {
            return (short)akMaxUpDown.Value;
        }

        private short M4CurrentAmmoCount()
        {
            return (short)m4CurrentUpDown.Value;
        }

        private short M4MaxAmmoCount()
        {
            return (short)m4MaxUpDown.Value;
        }

        private short Psg1TCurrentAmmoCount()
        {
            return (short)psg1TCurrentUpDown.Value;
        }

        private short Psg1TMaxAmmoCount()
        {
            return (short)psg1TMaxUpDown.Value;
        }

        private short ChaffCurrentAmmoCount()
        {
            return (short)chaffCurrentUpDown.Value;
        }

        private short ChaffMaxAmmoCount()
        {
            return (short)chaffMaxUpDown.Value;
        }

        private short StunCurrentAmmoCount()
        {
            return (short)stunCurrentUpDown.Value;
        }

        private short StunMaxAmmoCount()
        {
            return (short)stunMaxUpDown.Value;
        }

        private short GrenadeCurrentAmmoCount()
        {
            return (short)grenadeCurrentUpDown.Value;
        }

        private short GrenadeMaxAmmoCount()
        {
            return (short)grenadeMaxUpDown.Value;
        }

        private short BookCurrentAmmoCount()
        {
            return (short)bookCurrentUpDown.Value;
        }

        private short BookMaxAmmoCount()
        {
            return (short)bookMaxUpDown.Value;
        }

        private short MagazineCurrentAmmoCount()
        {
            return (short)magazineCurrentUpDown.Value;
        }

        private short MagazineMaxAmmoCount()
        {
            return (short)magazineMaxUpDown.Value;
        }

        private short ClaymoreCurrentAmmoCount()
        {
            return (short)claymoreCurrentUpDown.Value;
        }

        private short ClaymoreMaxAmmoCount()
        {
            return (short)claymoreMaxUpDown.Value;
        }

        private bool DMic1Enabled()
        {
            return dmic1CheckBox.Checked;
        }

        private bool DMic2Enabled()
        {
            return dmic2CheckBox.Checked;
        }

        private bool CoolantEnabled()
        {
            return coolantCheckBox.Checked;
        }

        private bool HfBladeEnabled()
        {
            return hfBladeCheckBox.Checked;
        }
        #endregion

        #region Items Button Functions
        private void rationCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            MGS2UsableObjects.Ration.ToggleItem();
        }

        private void rationCurrentBtn_Click(object sender, EventArgs e)
        {
            MGS2UsableObjects.Ration.UpdateCurrentCount(CurrentRationValue());
        }

        private void rationMaxBtn_Click(object sender, EventArgs e)
        {
            MGS2UsableObjects.Ration.UpdateMaxCount(MaxRationValue());
        }

        private void bandageCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            MGS2UsableObjects.Bandage.ToggleItem();
        }

        private void bandageCurrentBtn_Click(object sender, EventArgs e)
        {
            MGS2UsableObjects.Bandage.UpdateCurrentCount(CurrentBandageValue());
        }

        private void bandageMaxBtn_Click(object sender, EventArgs e)
        {
            MGS2UsableObjects.Bandage.UpdateMaxCount(MaxBandageValue());
        }

        private void pentazeminCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            MGS2UsableObjects.Pentazemin.ToggleItem();
        }

        private void pentazeminCurrentBtn_Click(object sender, EventArgs e)
        {
            MGS2UsableObjects.Pentazemin.UpdateCurrentCount(CurrentPentazeminCount());
        }

        private void pentazeminMaxBtn_Click(object sender, EventArgs e)
        {
            MGS2UsableObjects.Pentazemin.UpdateMaxCount(MaxPentazeminCount());
        }

        private void cardBtn_Click(object sender, EventArgs e)
        {
            MGS2UsableObjects.Card.SetLevel(CardSecurityLevel());
        }

        private void cardCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            MGS2UsableObjects.Card.ToggleItem();
        }

        private void binos1CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            MGS2UsableObjects.SnakeBinoculars.ToggleItem();
        }

        private void binos2CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            MGS2UsableObjects.RaidenBinoculars.ToggleItem();
        }

        private void camera1CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            MGS2UsableObjects.Camera1.ToggleItem();
        }

        private void camera2CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            MGS2UsableObjects.Camera2.ToggleItem();
        }

        private void nvgCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            MGS2UsableObjects.NightVisionGoggles.ToggleItem();
        }

        private void thermalCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            MGS2UsableObjects.ThermalGoggles.ToggleItem();
        }

        private void bodyArmorCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            MGS2UsableObjects.BodyArmor.ToggleItem();
        }

        private void mineDetectorCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            MGS2UsableObjects.MineDetector.ToggleItem();
        }

        private void apSensorCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            MGS2UsableObjects.APSensor.ToggleItem();
        }

        private void sensorACheckBox_CheckedChanged(object sender, EventArgs e)
        {
            MGS2UsableObjects.SensorA.ToggleItem();
        }

        private void sensorBCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            MGS2UsableObjects.SensorB.ToggleItem();
        }

        private void phoneCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            MGS2UsableObjects.Phone.ToggleItem();
        }

        private void coldMedsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            MGS2UsableObjects.ColdMedicine.ToggleItem();
        }

        private void cigarettesCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            MGS2UsableObjects.Cigarettes.ToggleItem();
        }

        private void moDiscCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            MGS2UsableObjects.MODisc.ToggleItem();
        }

        private void socomSupCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            MGS2UsableObjects.SocomSuppressor.ToggleItem();
        }

        private void uspSupCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            MGS2UsableObjects.USPSuppressor.ToggleItem();
        }

        private void akSupCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            MGS2UsableObjects.AKSuppressor.ToggleItem();
        }

        private void box1CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            MGS2UsableObjects.Box1.ToggleItem();
        }

        private void box2CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            MGS2UsableObjects.Box2.ToggleItem();
        }

        private void box3CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            MGS2UsableObjects.Box3.ToggleItem();
        }

        private void box4CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            MGS2UsableObjects.Box4.ToggleItem();
        }

        private void box5CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            MGS2UsableObjects.Box5.ToggleItem();
        }

        private void wetBoxCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            MGS2UsableObjects.WetBox.ToggleItem();
        }

        private void bduCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            MGS2UsableObjects.BDU.ToggleItem();
        }

        private void bandanaCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            MGS2UsableObjects.Bandana.ToggleItem();
        }

        private void infinityWigCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            MGS2UsableObjects.InfinityWig.ToggleItem();
        }

        private void blueWigCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            MGS2UsableObjects.BlueWig.ToggleItem();
        }

        private void orangeWigCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            MGS2UsableObjects.OrangeWig.ToggleItem();
        }

        private void stealthCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            MGS2UsableObjects.Stealth.ToggleItem();
        }

        private void dogTagsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            MGS2UsableObjects.DogTags.ToggleItem();
        }

        private void shaverCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            MGS2UsableObjects.Shaver.ToggleItem();
        }

        private void coldMedsCurrentBtn_Click(object sender, EventArgs e)
        {
            MGS2UsableObjects.ColdMedicine.UpdateCurrentCount(CurrentColdMedsCount());
        }

        private void coldMedsMaxBtn_Click(object sender, EventArgs e)
        {
            MGS2UsableObjects.ColdMedicine.UpdateMaxCount(MaxColdMedsCount());
        }
        #endregion

        #region Weapons Button Functions
        private void akMaxBtn_Click(object sender, EventArgs e)
        {
            MGS2UsableObjects.AKS74u.UpdateMaxAmmoCount(AkMaxAmmoCount());
        }

        private void m9CurrentBtn_Click(object sender, EventArgs e)
        {
            MGS2UsableObjects.M9.UpdateCurrentAmmoCount(M9CurrentAmmoCount());
        }

        private void m9MaxBtn_Click(object sender, EventArgs e)
        {
            MGS2UsableObjects.M9.UpdateMaxAmmoCount(M9MaxAmmoCount());
        }

        private void socomCurrentBtn_Click(object sender, EventArgs e)
        {
            MGS2UsableObjects.SOCOM.UpdateCurrentAmmoCount(SocomCurrentAmmoCount());
        }

        private void socomMaxBtn_Click(object sender, EventArgs e)
        {
            MGS2UsableObjects.SOCOM.UpdateMaxAmmoCount(SocomMaxAmmoCount());
        }

        private void uspCurrentBtn_Click(object sender, EventArgs e)
        {
            MGS2UsableObjects.USP.UpdateCurrentAmmoCount(UspCurrentAmmoCount());
        }

        private void uspMaxBtn_Click(object sender, EventArgs e)
        {
            MGS2UsableObjects.USP.UpdateMaxAmmoCount(UspMaxAmmoCount());
        }

        private void chaffCurrentBtn_Click(object sender, EventArgs e)
        {
            MGS2UsableObjects.ChaffGrenade.UpdateCurrentAmmoCount(ChaffCurrentAmmoCount());
        }

        private void chaffMaxBtn_Click(object sender, EventArgs e)
        {
            MGS2UsableObjects.ChaffGrenade.UpdateMaxAmmoCount(ChaffMaxAmmoCount());
        }

        private void stunCurrentBtn_Click(object sender, EventArgs e)
        {
            MGS2UsableObjects.StunGrenade.UpdateCurrentAmmoCount(StunCurrentAmmoCount());
        }

        private void stunMaxBtn_Click(object sender, EventArgs e)
        {
            MGS2UsableObjects.StunGrenade.UpdateMaxAmmoCount(StunMaxAmmoCount());
        }

        private void grenadeCurrentBtn_Click(object sender, EventArgs e)
        {
            MGS2UsableObjects.Grenade.UpdateCurrentAmmoCount(GrenadeCurrentAmmoCount());
        }

        private void grenadeMaxBtn_Click(object sender, EventArgs e)
        {
            MGS2UsableObjects.Grenade.UpdateMaxAmmoCount(GrenadeMaxAmmoCount());
        }

        private void magazineCurrentBtn_Click(object sender, EventArgs e)
        {
            MGS2UsableObjects.Magazine.UpdateCurrentAmmoCount(MagazineCurrentAmmoCount());
        }

        private void magazineMaxBtn_Click(object sender, EventArgs e)
        {
            MGS2UsableObjects.Magazine.UpdateMaxAmmoCount(MagazineMaxAmmoCount());
        }

        private void akCurrentBtn_Click(object sender, EventArgs e)
        {
            MGS2UsableObjects.AKS74u.UpdateCurrentAmmoCount(AkCurrentAmmoCount());
        }

        private void m4CurrentBtn_Click(object sender, EventArgs e)
        {
            MGS2UsableObjects.M4.UpdateCurrentAmmoCount(M4CurrentAmmoCount());
        }

        private void m4MaxBtn_Click(object sender, EventArgs e)
        {
            MGS2UsableObjects.M4.UpdateMaxAmmoCount(M4MaxAmmoCount());
        }

        private void psg1CurrentBtn_Click(object sender, EventArgs e)
        {
            MGS2UsableObjects.PSG1.UpdateCurrentAmmoCount(Psg1CurrentAmmoCount());
        }

        private void psg1MaxBtn_Click(object sender, EventArgs e)
        {
            MGS2UsableObjects.PSG1.UpdateMaxAmmoCount(Psg1MaxAmmoCount());
        }

        private void psg1TCurrentBtn_Click(object sender, EventArgs e)
        {
            MGS2UsableObjects.PSG1T.UpdateCurrentAmmoCount(Psg1TCurrentAmmoCount());
        }

        private void psg1TMaxBtn_Click(object sender, EventArgs e)
        {
            MGS2UsableObjects.PSG1T.UpdateMaxAmmoCount(Psg1TMaxAmmoCount());
        }

        private void rgb6CurrentBtn_Click(object sender, EventArgs e)
        {
            MGS2UsableObjects.RGB6.UpdateCurrentAmmoCount(Rgb6CurrentAmmoCount());
        }

        private void rgb6MaxBtn_Click(object sender, EventArgs e)
        {
            MGS2UsableObjects.RGB6.UpdateMaxAmmoCount(Rgb6MaxAmmoCount());
        }

        private void nikitaCurrentBtn_Click(object sender, EventArgs e)
        {
            MGS2UsableObjects.Nikita.UpdateCurrentAmmoCount(NikitaCurrentAmmoCount());
        }

        private void nikitaMaxBtn_Click(object sender, EventArgs e)
        {
            MGS2UsableObjects.Nikita.UpdateMaxAmmoCount(NikitaMaxAmmoCount());
        }

        private void stingerCurrentBtn_Click(object sender, EventArgs e)
        {
            MGS2UsableObjects.Stinger.UpdateCurrentAmmoCount(StingerCurrentAmmoCount());
        }

        private void stingerMaxBtn_Click(object sender, EventArgs e)
        {
            MGS2UsableObjects.Stinger.UpdateMaxAmmoCount(StingerMaxAmmoCount());
        }

        private void claymoreCurrentBtn_Click(object sender, EventArgs e)
        {
            MGS2UsableObjects.Claymore.UpdateCurrentAmmoCount(ClaymoreCurrentAmmoCount());
        }

        private void claymoreMaxBtn_Click(object sender, EventArgs e)
        {
            MGS2UsableObjects.Claymore.UpdateMaxAmmoCount(ClaymoreMaxAmmoCount());
        }

        private void c4CurrentBtn_Click(object sender, EventArgs e)
        {
            MGS2UsableObjects.C4.UpdateCurrentAmmoCount(ClaymoreCurrentAmmoCount());
        }

        private void c4MaxBtn_Click(object sender, EventArgs e)
        {
            MGS2UsableObjects.C4.UpdateMaxAmmoCount(ClaymoreMaxAmmoCount());
        }

        private void bookCurrentBtn_Click(object sender, EventArgs e)
        {
            MGS2UsableObjects.Book.UpdateCurrentAmmoCount(BookCurrentAmmoCount());
        }

        private void bookMaxBtn_Click(object sender, EventArgs e)
        {
            MGS2UsableObjects.Book.UpdateMaxAmmoCount(BookMaxAmmoCount());
        }

        private void hfBladeLethalBtn_Click(object sender, EventArgs e)
        {
            MGS2UsableObjects.HighFrequencyBlade.SetToLethal();
        }

        private void hfBladeStunBtn_Click(object sender, EventArgs e)
        {
            MGS2UsableObjects.HighFrequencyBlade.SetToStun();
        }

        private void m9CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            MGS2UsableObjects.M9.ToggleWeapon();
        }

        private void socomCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            MGS2UsableObjects.SOCOM.ToggleWeapon();
        }

        private void uspCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            MGS2UsableObjects.USP.ToggleWeapon();
        }

        private void chaffCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            MGS2UsableObjects.ChaffGrenade.ToggleWeapon();
        }

        private void stunCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            MGS2UsableObjects.StunGrenade.ToggleWeapon();
        }

        private void grenadeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            MGS2UsableObjects.Grenade.ToggleWeapon();
        }

        private void magazineCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            MGS2UsableObjects.Magazine.ToggleWeapon();
        }

        private void akCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            MGS2UsableObjects.AKS74u.ToggleWeapon();
        }

        private void m4CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            MGS2UsableObjects.M4.ToggleWeapon();
        }

        private void psg1CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            MGS2UsableObjects.PSG1.ToggleWeapon();
        }

        private void psg1TCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            MGS2UsableObjects.PSG1T.ToggleWeapon();
        }

        private void rgb6CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            MGS2UsableObjects.RGB6.ToggleWeapon();
        }

        private void nikitaCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            MGS2UsableObjects.Nikita.ToggleWeapon();
        }

        private void stingerCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            MGS2UsableObjects.Stinger.ToggleWeapon();
        }

        private void claymoreCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            MGS2UsableObjects.Claymore.ToggleWeapon();
        }

        private void c4CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            MGS2UsableObjects.C4.ToggleWeapon();
        }

        private void bookCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            MGS2UsableObjects.Book.ToggleWeapon();
        }

        private void coolantCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            MGS2UsableObjects.Coolant.ToggleWeapon();
        }

        private void dmic1CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            MGS2UsableObjects.DMic.ToggleWeapon();
        }

        private void dmic2CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            MGS2UsableObjects.DMic2.ToggleWeapon();
        }

        private void hfBladeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            MGS2UsableObjects.HighFrequencyBlade.ToggleWeapon();
        }
        #endregion
    }
}
