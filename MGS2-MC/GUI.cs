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

        private short CurrentChaffGrenadeCount()
        {
            return (short)chaffCurrentUpDown.Value;
        }

        private short MaxChaffGrenadeCount()
        {
            return (short)chaffMaxUpDown.Value;
        }

        private short CurrentStunGrenadeCount()
        {
            return (short)stunCurrentUpDown.Value;
        }

        private short MaxStunGrenadeCount()
        {
            return (short)stunMaxUpDown.Value;
        }

        private short CurrentGrenadeCount()
        {
            return (short)grenadeCurrentUpDown.Value;
        }

        private short MaxGrenadeCount()
        {
            return (short)grenadeMaxUpDown.Value;
        }

        private short CurrentBookCount()
        {
            return (short)bookCurrentUpDown.Value;
        }

        private short MaxBookCount()
        {
            return (short)bookMaxUpDown.Value;
        }

        private short CurrentMagazineCount()
        {
            return (short)magazineCurrentUpDown.Value;
        }

        private short MaxMagazineCount()
        {
            return (short)magazineMaxUpDown.Value;
        }

        private short CurrentClaymoreCount()
        {
            return (short)claymoreCurrentUpDown.Value;
        }

        private short MaxClaymoreCount()
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

        private void akMaxBtn_Click(object sender, EventArgs e)
        {

        }

        private void m9CurrentBtn_Click(object sender, EventArgs e)
        {

        }

        private void m9MaxBtn_Click(object sender, EventArgs e)
        {

        }

        private void socomCurrentBtn_Click(object sender, EventArgs e)
        {

        }

        private void socomMaxBtn_Click(object sender, EventArgs e)
        {

        }

        private void uspCurrentBtn_Click(object sender, EventArgs e)
        {

        }

        private void uspMaxBtn_Click(object sender, EventArgs e)
        {

        }

        private void chaffCurrentBtn_Click(object sender, EventArgs e)
        {
            MGS2UsableObjects.ChaffGrenade.UpdateCurrentAmmoCount(CurrentChaffGrenadeCount());
        }

        private void chaffMaxBtn_Click(object sender, EventArgs e)
        {
            //MGS2UsableObjects.ChaffGrenade.Update(MaxChaffGrenadeCount());
        }

        private void stunCurrentBtn_Click(object sender, EventArgs e)
        {
            MGS2UsableObjects.StunGrenade.UpdateCurrentAmmoCount(CurrentStunGrenadeCount());
        }

        private void stunMaxBtn_Click(object sender, EventArgs e)
        {

        }

        private void grenadeCurrentBtn_Click(object sender, EventArgs e)
        {
            MGS2UsableObjects.Grenade.UpdateCurrentAmmoCount(CurrentGrenadeCount());
        }

        private void grenadeMaxBtn_Click(object sender, EventArgs e)
        {

        }

        private void magazineCurrentBtn_Click(object sender, EventArgs e)
        {
            MGS2UsableObjects.Magazine.UpdateCurrentAmmoCount(CurrentMagazineCount());
        }

        private void magazineMaxBtn_Click(object sender, EventArgs e)
        {

        }

        private void akCurrentBtn_Click(object sender, EventArgs e)
        {

        }

        private void m4CurrentBtn_Click(object sender, EventArgs e)
        {

        }

        private void m4MaxBtn_Click(object sender, EventArgs e)
        {

        }

        private void psg1CurrentBtn_Click(object sender, EventArgs e)
        {

        }

        private void psg1MaxBtn_Click(object sender, EventArgs e)
        {

        }

        private void psg1TCurrentBtn_Click(object sender, EventArgs e)
        {

        }

        private void psg1TMaxBtn_Click(object sender, EventArgs e)
        {

        }

        private void rgb6CurrentBtn_Click(object sender, EventArgs e)
        {

        }

        private void rgb6MaxBtn_Click(object sender, EventArgs e)
        {

        }

        private void nikitaCurrentBtn_Click(object sender, EventArgs e)
        {

        }

        private void nikitaMaxBtn_Click(object sender, EventArgs e)
        {

        }

        private void stingerCurrentBtn_Click(object sender, EventArgs e)
        {

        }

        private void stingerMaxBtn_Click(object sender, EventArgs e)
        {

        }

        private void claymoreCurrentBtn_Click(object sender, EventArgs e)
        {
            MGS2UsableObjects.Claymore.UpdateCurrentAmmoCount(CurrentClaymoreCount());
        }

        private void claymoreMaxBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void c4CurrentBtn_Click(object sender, EventArgs e)
        {

        }

        private void c4MaxBtn_Click(object sender, EventArgs e)
        {

        }

        private void bookCurrentBtn_Click(object sender, EventArgs e)
        {
            MGS2UsableObjects.Book.UpdateCurrentAmmoCount(CurrentBookCount());
        }

        private void bookMaxBtn_Click(object sender, EventArgs e)
        {

        }

        private void hfBladeLethalBtn_Click(object sender, EventArgs e)
        {

        }

        private void hfBladeStunBtn_Click(object sender, EventArgs e)
        {

        }

        private void m9CheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void socomCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void uspCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chaffCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void stunCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void grenadeCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void magazineCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void akCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void m4CheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void psg1CheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void psg1TCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rgb6CheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void nikitaCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void stingerCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void claymoreCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void c4CheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void bookCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void coolantCheckBox_CheckedChanged(object sender, EventArgs e)
        {

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

        }
        #endregion

        /*private void button1_Click(object sender, EventArgs e)
        {
            MGS2UsableObjects.M9.UpdateCurrentAmmoCount(int.Parse(textBox1.Text));
        }*/
    }
}
