using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIS_mag_1_imageLightening_Darkening
{
    class CustomImage
    {
        private int height;
        private int width;

        private CustomPixel[,] pixels;
        private CustomPixel[,] referencePixels;

        public CustomImage(Bitmap image)
        {
            height = image.Height;
            width = image.Width;

            referencePixels = new CustomPixel[height, width];

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    referencePixels[i, j] = new CustomPixel(
                        (int)(image.GetPixel(j, i).R / 25.5),
                        (int)(image.GetPixel(j, i).G / 25.5),
                        (int)(image.GetPixel(j, i).B / 25.5));
                }
            }

            pixels = referencePixels;
        }

        public Bitmap bitmap()
        {
            Bitmap bitmap = new Bitmap(width, height);

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    bitmap.SetPixel(
                        j, i, Color.FromArgb(
                            (int)(pixels[i, j].Red * 25.5),
                            (int)(pixels[i, j].Green * 25.5),
                            (int)(pixels[i, j].Blue * 25.5)));
                }
            }
            return bitmap;
        }

        public void reset()
        {
            pixels = referencePixels;
        }
    }
}