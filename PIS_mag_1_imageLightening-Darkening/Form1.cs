using System;
using System.Drawing;
using System.Windows.Forms;

using static PIS_mag_1_imageLightening_Darkening.ImageFilter;

namespace PIS_mag_1_imageLightening_Darkening
{
    public partial class Form1 : Form
    {
        private Filter CurrentFilter;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            inputPictureBox.Image = Properties.Resources.mainImage;

            CurrentFilter = Filter.None;
            updateImageFilter();
            updateVisibleNumeric();
        }

        private void updateVisibleNumeric()
        {
            filterLevelNumeric.Visible = lighterRadioButton.Checked || darkerRadioButton.Checked;
        }

        private void updateImageFilter()
        {
            int alphaFilter = Convert.ToInt32(filterLevelNumeric.Value * 255);
            switch (CurrentFilter)
            {
                case Filter.None:
                    outputPictureBox.Image = Properties.Resources.mainImage;
                    break;
                case Filter.Light:
                    outputPictureBox.Image = LightenImage(inputPictureBox.Image, alphaFilter);
                    break;
                case Filter.Dark:
                    outputPictureBox.Image = DarkenImage(inputPictureBox.Image, alphaFilter);
                    break;
            }
        }

        private void filterLevelNumeric_ValueChanged(object sender, EventArgs e)
        {
            updateImageFilter();
        }

        private void noneRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            CurrentFilter = Filter.None;
            updateImageFilter();
            updateVisibleNumeric();
        }

        private void lighterRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            CurrentFilter = Filter.Light;
            updateImageFilter();
            updateVisibleNumeric();
        }

        private void darkerRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            CurrentFilter = Filter.Dark;
            updateImageFilter();
            updateVisibleNumeric();
        }
    }
}
