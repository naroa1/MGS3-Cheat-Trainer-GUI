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

        private void rationCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            MGS2UsableObjects.Ration.ToggleItem(); //TODO: verify this works
        }

        private void rationCurrentBtn_Click(object sender, EventArgs e)
        {
            MGS2UsableObjects.Ration.UpdateCurrentCount((int) rationCurrentUpDown.Value);
        }

        private void rationMaxBtn_Click(object sender, EventArgs e)
        {
            MGS2UsableObjects.Ration.UpdateCurrentCount((int)rationMaxUpDown.Value);
        }

        private void bandageCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            MGS2UsableObjects.Bandage.ToggleItem(); //TODO: verify this works
        }

        private void bandageCurrentBtn_Click(object sender, EventArgs e)
        {

        }

        private void bandageMaxBtn_Click(object sender, EventArgs e)
        {

        }

        private void pentazeminCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pentazeminCurrentBtn_Click(object sender, EventArgs e)
        {

        }

        private void pentazeminMaxBtn_Click(object sender, EventArgs e)
        {

        }

        private void cardBtn_Click(object sender, EventArgs e)
        {

        }

        private void cardCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void binos1CheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void binos2CheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void camera1CheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void camera2CheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void nvgCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void thermalCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void bodyArmorCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void mineDetectorCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void apSensorCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void sensorACheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void sensorBCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void phoneCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void coldMedsCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cigarettesCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void moDiscCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void socomSupCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void uspSupCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void akSupCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void box1CheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void box2CheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void box3CheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void box4CheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void box5CheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void wetBoxCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void bduCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void bandanaCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void infinityWigCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void blueWigCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void orangeWigCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void stealthCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dogTagsCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void shaverCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        /*private void button1_Click(object sender, EventArgs e)
        {
            MGS2UsableObjects.M9.UpdateCurrentAmmoCount(int.Parse(textBox1.Text));
        }*/
    }
}
