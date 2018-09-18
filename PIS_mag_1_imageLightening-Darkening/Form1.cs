using System;
using System.Windows.Forms;

using static PIS_mag_1_imageLightening_Darkening.ImageFilter;

namespace PIS_mag_1_imageLightening_Darkening
{
    public partial class Form1 : Form
    {
        private Filter CurrentFilter;
        private CustomImage myImage;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            myImage = new CustomImage(Properties.Resources.mainImage);
            inputPictureBox.Image = myImage.bitmap();

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
            switch (CurrentFilter)
            {
                case Filter.None:
                    outputPictureBox.Image = myImage.reset();
                    break;
                case Filter.Light:
                    outputPictureBox.Image = myImage.light(Convert.ToDouble(filterLevelNumeric.Value));
                    break;
                case Filter.Dark:
                    outputPictureBox.Image = myImage.dark(Convert.ToDouble(filterLevelNumeric.Value));
                    break;
                case Filter.Grayscale:
                    outputPictureBox.Image = myImage.grayscale();
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

        private void grayscaleRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            CurrentFilter = Filter.Grayscale;
            updateImageFilter();
            updateVisibleNumeric();
        }
    }
}
