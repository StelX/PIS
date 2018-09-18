using System;
using System.Drawing;
using System.Drawing.Imaging;

namespace PIS_mag_1_imageLightening_Darkening
{
    static class ImageFilter
    {
        public enum Filter
        {
            None,
            Light,
            Dark,
            Grayscale
        }

        public static Image DarkenImage(Image image, double value)
        {
            int alpha = Convert.ToInt32(value * 255);
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

        public static Image LightenImage(Image image, double value)
        {
            int alpha = Convert.ToInt32(value * 255);
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

        public static Image GrayscaleImage(Image imageInput, double value)
        {
            Bitmap image = new Bitmap(imageInput);

            float s = (float)(1 - value);
            var sr = (1 - s) * 0.2126f;
            var sg = (1 - s) * 0.7152f;
            var sb = (1 - s) * 0.0722f;

            using (var gfx = Graphics.FromImage(image))
            using (var attr = new ImageAttributes())
            {
                attr.SetColorMatrix(new ColorMatrix
                {
                    Matrix00 = sr + s,
                    Matrix01 = sr,
                    Matrix02 = sr,
                    Matrix10 = sg,
                    Matrix11 = sg + s,
                    Matrix12 = sg,
                    Matrix20 = sb,
                    Matrix21 = sb,
                    Matrix22 = sb + s
                });

                gfx.DrawImage(image,
                    new Rectangle(Point.Empty, image.Size),
                    0, 0,
                    image.Width,
                    image.Height,
                    GraphicsUnit.Pixel,
                    attr);
            }

            return image;
        }
    }
}
