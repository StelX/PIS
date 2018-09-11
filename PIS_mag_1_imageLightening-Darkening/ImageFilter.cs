using System.Drawing;

namespace PIS_mag_1_imageLightening_Darkening
{
    static class ImageFilter
    {
        public enum Filter
        {
            None,
            Light,
            Dark
        }

        public static Image DarkenImage(Image image, int alpha)
        {
            Bitmap bitmap = new Bitmap(image);
            Rectangle rectangle = new Rectangle(0, 0, bitmap.Width, bitmap.Height);

            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                using (Brush darkenBrush = new SolidBrush(Color.FromArgb(alpha, Color.Black)))
                {
                    graphics.FillRectangle(darkenBrush, rectangle);
                }
            }
            return bitmap;
        }

        public static Image LightenImage(Image image, int alpha)
        {
            Bitmap bitmap = new Bitmap(image);
            Rectangle rectangle = new Rectangle(0, 0, bitmap.Width, bitmap.Height);

            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                using (Brush lightenBrush = new SolidBrush(Color.FromArgb(alpha, Color.White)))
                {
                    graphics.FillRectangle(lightenBrush, rectangle);
                }
            }
            return bitmap;
        }
    }
}
