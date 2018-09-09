using System;

using System.Drawing;

using System.Windows.Forms;


namespace PIS_mag_1_imageLightening_Darkening
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pictureBox1.BackColor = Color.AliceBlue;
        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            // take dropped items  and store 
            var droppedFiles = (string[])e.Data.GetData(DataFormats.FileDrop);

            foreach (string file in droppedFiles)
            {
                pictureBox1.Image = Image.FromFile(file);
            }

        }

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            if(e.Data.GetDataPresent(DataFormats.FileDrop, false) == true)
            {
                e.Effect = DragDropEffects.All;
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

            pictureBox2.Image = Darker((Bitmap)(pictureBox1.Image), 128);
        
            

        }

        public static Bitmap Lighter(Bitmap image, int correction)
        {
            Bitmap bmp = new Bitmap(image);
            Rectangle r = new Rectangle(0, 0, bmp.Width, bmp.Height);
            var alpha = correction;
            using (Graphics g = Graphics.FromImage(bmp))
            {
                using (Brush cloud_brush = new SolidBrush(Color.FromArgb(alpha, Color.White)))
                {
                    g.FillRectangle(cloud_brush, r);
                }
            }
            return bmp;

        }

        public static Bitmap Darker(Bitmap image, int correction)
        {
            Bitmap bmp = new Bitmap(image);
            Rectangle r = new Rectangle(0, 0, bmp.Width, bmp.Height);
            var alpha = correction;
            using (Graphics g = Graphics.FromImage(bmp))
            {
                using (Brush cloud_brush = new SolidBrush(Color.FromArgb(alpha, Color.Black)))
                {
                    g.FillRectangle(cloud_brush, r);
                }
            }
            return bmp;

        }

    }
}
