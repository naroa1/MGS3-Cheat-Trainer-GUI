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

        private short USPCurrentAmmoCount()
        {
            return (short)uspCurrentUpDown.Value;
        }

        private short USPMaxAmmoCount()
        {
            return (short)uspMaxUpDown.Value;
        }

        private short SOCOMCurrentAmmoCount()
        {
            return (short)socomCurrentUpDown.Value;
        }

        private short SOCOMMaxAmmoCount()
        {
            return (short)socomMaxUpDown.Value;
        }

        private short PSG1CurrentAmmoCount()
        {
            return (short)psg1CurrentUpDown.Value;
        }

        private short PSG1MaxAmmoCount()
        {
            return (short)psg1MaxUpDown.Value;
        }

        private short RGB6CurrentAmmoCount()
        {
            return (short)rgb6CurrentUpDown.Value;
        }

        private short RGB6MaxAmmoCount()
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

        private short AKCurrentAmmoCount()
        {
            return (short)akCurrentUpDown.Value;
        }

        private short AKMaxAmmoCount()
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

        private short PSG1TCurrentAmmoCount()
        {
            return (short)psg1TCurrentUpDown.Value;
        }

        private short PSG1TMaxAmmoCount()
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
        private void RationCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            MGS2UsableObjects.Ration.ToggleItem();
        }

        private void RationCurrentBtn_Click(object sender, EventArgs e)
        {
            MGS2UsableObjects.Ration.UpdateCurrentCount(CurrentRationValue());
        }

        private void RationMaxBtn_Click(object sender, EventArgs e)
        {
            MGS2UsableObjects.Ration.UpdateMaxCount(MaxRationValue());
        }

        private void BandageCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            MGS2UsableObjects.Bandage.ToggleItem();
        }

        private void BandageCurrentBtn_Click(object sender, EventArgs e)
        {
            MGS2UsableObjects.Bandage.UpdateCurrentCount(CurrentBandageValue());
        }

        private void BandageMaxBtn_Click(object sender, EventArgs e)
        {
            MGS2UsableObjects.Bandage.UpdateMaxCount(MaxBandageValue());
        }

        private void PentazeminCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            MGS2UsableObjects.Pentazemin.ToggleItem();
        }

        private void PentazeminCurrentBtn_Click(object sender, EventArgs e)
        {
            MGS2UsableObjects.Pentazemin.UpdateCurrentCount(CurrentPentazeminCount());
        }

        private void PentazeminMaxBtn_Click(object sender, EventArgs e)
        {
            MGS2UsableObjects.Pentazemin.UpdateMaxCount(MaxPentazeminCount());
        }

        private void CardBtn_Click(object sender, EventArgs e)
        {
            MGS2UsableObjects.Card.SetLevel(CardSecurityLevel());
        }

        private void CardCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            MGS2UsableObjects.Card.ToggleItem();
        }

        private void Binos1CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            MGS2UsableObjects.SnakeBinoculars.ToggleItem();
        }

        private void Binos2CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            MGS2UsableObjects.RaidenBinoculars.ToggleItem();
        }

        private void Camera1CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            MGS2UsableObjects.Camera1.ToggleItem();
        }

        private void Camera2CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            MGS2UsableObjects.Camera2.ToggleItem();
        }

        private void NvgCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            MGS2UsableObjects.NightVisionGoggles.ToggleItem();
        }

        private void ThermalCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            MGS2UsableObjects.ThermalGoggles.ToggleItem();
        }

        private void BodyArmorCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            MGS2UsableObjects.BodyArmor.ToggleItem();
        }

        private void MineDetectorCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            MGS2UsableObjects.MineDetector.ToggleItem();
        }

        private void ApSensorCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            MGS2UsableObjects.APSensor.ToggleItem();
        }

        private void SensorACheckBox_CheckedChanged(object sender, EventArgs e)
        {
            MGS2UsableObjects.SensorA.ToggleItem();
        }

        private void SensorBCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            MGS2UsableObjects.SensorB.ToggleItem();
        }

        private void PhoneCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            MGS2UsableObjects.Phone.ToggleItem();
        }

        private void ColdMedsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            MGS2UsableObjects.ColdMedicine.ToggleItem();
        }

        private void CigarettesCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            MGS2UsableObjects.Cigarettes.ToggleItem();
        }

        private void MoDiscCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            MGS2UsableObjects.MODisc.ToggleItem();
        }

        private void SocomSupCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            MGS2UsableObjects.SocomSuppressor.ToggleItem();
        }

        private void UspSupCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            MGS2UsableObjects.USPSuppressor.ToggleItem();
        }

        private void AkSupCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            MGS2UsableObjects.AKSuppressor.ToggleItem();
        }

        private void Box1CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            MGS2UsableObjects.Box1.ToggleItem();
        }

        private void Box2CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            MGS2UsableObjects.Box2.ToggleItem();
        }

        private void Box3CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            MGS2UsableObjects.Box3.ToggleItem();
        }

        private void Box4CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            MGS2UsableObjects.Box4.ToggleItem();
        }

        private void Box5CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            MGS2UsableObjects.Box5.ToggleItem();
        }

        private void WetBoxCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            MGS2UsableObjects.WetBox.ToggleItem();
        }

        private void BduCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            MGS2UsableObjects.BDU.ToggleItem();
        }

        private void BduMaskCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            //TODO: implement
        }

        private void BandanaCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            MGS2UsableObjects.Bandana.ToggleItem();
        }

        private void InfinityWigCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            MGS2UsableObjects.InfinityWig.ToggleItem();
        }

        private void BlueWigCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            MGS2UsableObjects.BlueWig.ToggleItem();
        }

        private void OrangeWigCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            MGS2UsableObjects.OrangeWig.ToggleItem();
        }

        private void StealthCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            MGS2UsableObjects.Stealth.ToggleItem();
        }

        private void DogTagsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            MGS2UsableObjects.DogTags.ToggleItem();
        }

        private void ShaverCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            MGS2UsableObjects.Shaver.ToggleItem();
        }

        private void ColdMedsCurrentBtn_Click(object sender, EventArgs e)
        {
            MGS2UsableObjects.ColdMedicine.UpdateCurrentCount(CurrentColdMedsCount());
        }

        private void ColdMedsMaxBtn_Click(object sender, EventArgs e)
        {
            MGS2UsableObjects.ColdMedicine.UpdateMaxCount(MaxColdMedsCount());
        }
        #endregion

        #region Weapons Button Functions
        private void AkMaxBtn_Click(object sender, EventArgs e)
        {
            MGS2UsableObjects.AKS74u.UpdateMaxAmmoCount(AKMaxAmmoCount());
        }

        private void M9CurrentBtn_Click(object sender, EventArgs e)
        {
            MGS2UsableObjects.M9.UpdateCurrentAmmoCount(M9CurrentAmmoCount());
        }

        private void M9MaxBtn_Click(object sender, EventArgs e)
        {
            MGS2UsableObjects.M9.UpdateMaxAmmoCount(M9MaxAmmoCount());
        }

        private void SocomCurrentBtn_Click(object sender, EventArgs e)
        {
            MGS2UsableObjects.SOCOM.UpdateCurrentAmmoCount(SOCOMCurrentAmmoCount());
        }

        private void SocomMaxBtn_Click(object sender, EventArgs e)
        {
            MGS2UsableObjects.SOCOM.UpdateMaxAmmoCount(SOCOMMaxAmmoCount());
        }

        private void UspCurrentBtn_Click(object sender, EventArgs e)
        {
            MGS2UsableObjects.USP.UpdateCurrentAmmoCount(USPCurrentAmmoCount());
        }

        private void UspMaxBtn_Click(object sender, EventArgs e)
        {
            MGS2UsableObjects.USP.UpdateMaxAmmoCount(USPMaxAmmoCount());
        }

        private void ChaffCurrentBtn_Click(object sender, EventArgs e)
        {
            MGS2UsableObjects.ChaffGrenade.UpdateCurrentAmmoCount(ChaffCurrentAmmoCount());
        }

        private void ChaffMaxBtn_Click(object sender, EventArgs e)
        {
            MGS2UsableObjects.ChaffGrenade.UpdateMaxAmmoCount(ChaffMaxAmmoCount());
        }

        private void StunCurrentBtn_Click(object sender, EventArgs e)
        {
            MGS2UsableObjects.StunGrenade.UpdateCurrentAmmoCount(StunCurrentAmmoCount());
        }

        private void StunMaxBtn_Click(object sender, EventArgs e)
        {
            MGS2UsableObjects.StunGrenade.UpdateMaxAmmoCount(StunMaxAmmoCount());
        }

        private void GrenadeCurrentBtn_Click(object sender, EventArgs e)
        {
            MGS2UsableObjects.Grenade.UpdateCurrentAmmoCount(GrenadeCurrentAmmoCount());
        }

        private void GrenadeMaxBtn_Click(object sender, EventArgs e)
        {
            MGS2UsableObjects.Grenade.UpdateMaxAmmoCount(GrenadeMaxAmmoCount());
        }

        private void MagazineCurrentBtn_Click(object sender, EventArgs e)
        {
            MGS2UsableObjects.Magazine.UpdateCurrentAmmoCount(MagazineCurrentAmmoCount());
        }

        private void MagazineMaxBtn_Click(object sender, EventArgs e)
        {
            MGS2UsableObjects.Magazine.UpdateMaxAmmoCount(MagazineMaxAmmoCount());
        }

        private void AkCurrentBtn_Click(object sender, EventArgs e)
        {
            MGS2UsableObjects.AKS74u.UpdateCurrentAmmoCount(AKCurrentAmmoCount());
        }

        private void M4CurrentBtn_Click(object sender, EventArgs e)
        {
            MGS2UsableObjects.M4.UpdateCurrentAmmoCount(M4CurrentAmmoCount());
        }

        private void M4MaxBtn_Click(object sender, EventArgs e)
        {
            MGS2UsableObjects.M4.UpdateMaxAmmoCount(M4MaxAmmoCount());
        }

        private void Psg1CurrentBtn_Click(object sender, EventArgs e)
        {
            MGS2UsableObjects.PSG1.UpdateCurrentAmmoCount(PSG1CurrentAmmoCount());
        }

        private void Psg1MaxBtn_Click(object sender, EventArgs e)
        {
            MGS2UsableObjects.PSG1.UpdateMaxAmmoCount(PSG1MaxAmmoCount());
        }

        private void Psg1TCurrentBtn_Click(object sender, EventArgs e)
        {
            MGS2UsableObjects.PSG1T.UpdateCurrentAmmoCount(PSG1TCurrentAmmoCount());
        }

        private void Psg1TMaxBtn_Click(object sender, EventArgs e)
        {
            MGS2UsableObjects.PSG1T.UpdateMaxAmmoCount(PSG1TMaxAmmoCount());
        }

        private void Rgb6CurrentBtn_Click(object sender, EventArgs e)
        {
            MGS2UsableObjects.RGB6.UpdateCurrentAmmoCount(RGB6CurrentAmmoCount());
        }

        private void Rgb6MaxBtn_Click(object sender, EventArgs e)
        {
            MGS2UsableObjects.RGB6.UpdateMaxAmmoCount(RGB6MaxAmmoCount());
        }

        private void NikitaCurrentBtn_Click(object sender, EventArgs e)
        {
            MGS2UsableObjects.Nikita.UpdateCurrentAmmoCount(NikitaCurrentAmmoCount());
        }

        private void NikitaMaxBtn_Click(object sender, EventArgs e)
        {
            MGS2UsableObjects.Nikita.UpdateMaxAmmoCount(NikitaMaxAmmoCount());
        }

        private void StingerCurrentBtn_Click(object sender, EventArgs e)
        {
            MGS2UsableObjects.Stinger.UpdateCurrentAmmoCount(StingerCurrentAmmoCount());
        }

        private void StingerMaxBtn_Click(object sender, EventArgs e)
        {
            MGS2UsableObjects.Stinger.UpdateMaxAmmoCount(StingerMaxAmmoCount());
        }

        private void ClaymoreCurrentBtn_Click(object sender, EventArgs e)
        {
            MGS2UsableObjects.Claymore.UpdateCurrentAmmoCount(ClaymoreCurrentAmmoCount());
        }

        private void ClaymoreMaxBtn_Click(object sender, EventArgs e)
        {
            MGS2UsableObjects.Claymore.UpdateMaxAmmoCount(ClaymoreMaxAmmoCount());
        }

        private void C4CurrentBtn_Click(object sender, EventArgs e)
        {
            MGS2UsableObjects.C4.UpdateCurrentAmmoCount(ClaymoreCurrentAmmoCount());
        }

        private void C4MaxBtn_Click(object sender, EventArgs e)
        {
            MGS2UsableObjects.C4.UpdateMaxAmmoCount(ClaymoreMaxAmmoCount());
        }

        private void BookCurrentBtn_Click(object sender, EventArgs e)
        {
            MGS2UsableObjects.Book.UpdateCurrentAmmoCount(BookCurrentAmmoCount());
        }

        private void BookMaxBtn_Click(object sender, EventArgs e)
        {
            MGS2UsableObjects.Book.UpdateMaxAmmoCount(BookMaxAmmoCount());
        }

        private void HfBladeLethalBtn_Click(object sender, EventArgs e)
        {
            MGS2UsableObjects.HighFrequencyBlade.SetToLethal();
        }

        private void HfBladeStunBtn_Click(object sender, EventArgs e)
        {
            MGS2UsableObjects.HighFrequencyBlade.SetToStun();
        }

        private void M9CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            MGS2UsableObjects.M9.ToggleWeapon();
        }

        private void SocomCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            MGS2UsableObjects.SOCOM.ToggleWeapon();
        }

        private void UspCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            MGS2UsableObjects.USP.ToggleWeapon();
        }

        private void ChaffCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            MGS2UsableObjects.ChaffGrenade.ToggleWeapon();
        }

        private void StunCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            MGS2UsableObjects.StunGrenade.ToggleWeapon();
        }

        private void GrenadeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            MGS2UsableObjects.Grenade.ToggleWeapon();
        }

        private void MagazineCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            MGS2UsableObjects.Magazine.ToggleWeapon();
        }

        private void AkCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            MGS2UsableObjects.AKS74u.ToggleWeapon();
        }

        private void M4CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            MGS2UsableObjects.M4.ToggleWeapon();
        }

        private void Psg1CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            MGS2UsableObjects.PSG1.ToggleWeapon();
        }

        private void Psg1TCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            MGS2UsableObjects.PSG1T.ToggleWeapon();
        }

        private void Rgb6CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            MGS2UsableObjects.RGB6.ToggleWeapon();
        }

        private void NikitaCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            MGS2UsableObjects.Nikita.ToggleWeapon();
        }

        private void StingerCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            MGS2UsableObjects.Stinger.ToggleWeapon();
        }

        private void ClaymoreCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            MGS2UsableObjects.Claymore.ToggleWeapon();
        }

        private void C4CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            MGS2UsableObjects.C4.ToggleWeapon();
        }

        private void BookCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            MGS2UsableObjects.Book.ToggleWeapon();
        }

        private void CoolantCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            MGS2UsableObjects.Coolant.ToggleWeapon();
        }

        private void Dmic1CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            MGS2UsableObjects.DMic.ToggleWeapon();
        }

        private void Dmic2CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            MGS2UsableObjects.DMic2.ToggleWeapon();
        }

        private void HfBladeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            MGS2UsableObjects.HighFrequencyBlade.ToggleWeapon();
        }
        #endregion

    }
}
