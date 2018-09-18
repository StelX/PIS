using System;
using System.Drawing;

namespace PIS_mag_1_imageLightening_Darkening
{
    class CustomImage
    {
        public enum Filter
        {
            None,
            Light,
            Dark,
            Grayscale
        }

        private int height;
        private int width;

        private CustomPixel[,] pixels;
        private CustomPixel[,] referencePixels;

        public CustomImage(Bitmap image)
        {
            height = image.Height;
            width = image.Width;

            referencePixels = new CustomPixel[height, width];
            pixels = new CustomPixel[height, width];

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    int red = Convert.ToInt32(image.GetPixel(j, i).R / 25.5);
                    int green = Convert.ToInt32(image.GetPixel(j, i).G / 25.5);
                    int blue = Convert.ToInt32(image.GetPixel(j, i).B / 25.5);

                    referencePixels[i, j] = new CustomPixel(red, green, blue);
                    pixels[i, j] = new CustomPixel(red, green, blue);
                }
            }
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
                            Convert.ToInt32(pixels[i, j].Red * 25.5),
                            Convert.ToInt32(pixels[i, j].Green * 25.5),
                            Convert.ToInt32(pixels[i, j].Blue * 25.5)));
                }
            }
            return bitmap;
        }

        public Bitmap grayscale()
        {
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    int gray = Convert.ToInt32((referencePixels[i, j].Red + referencePixels[i, j].Green + referencePixels[i, j].Blue) / 3);
                    pixels[i, j].Red = gray;
                    pixels[i, j].Green = gray;
                    pixels[i, j].Blue = gray;
                }
            }

            return bitmap();
        }

        public Bitmap light(double value)
        {
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    int red = referencePixels[i, j].Red;
                    int green = referencePixels[i, j].Green;
                    int blue = referencePixels[i, j].Blue;

                    pixels[i, j].Red = Convert.ToInt32(red + (10 - red) * value);
                    pixels[i, j].Green = Convert.ToInt32(green + (10 - green) * value);
                    pixels[i, j].Blue = Convert.ToInt32(blue + (10 - blue) * value);
                }
            }

            return bitmap();
        }

        public Bitmap dark(double value)
        {
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    int red = referencePixels[i, j].Red;
                    int green = referencePixels[i, j].Green;
                    int blue = referencePixels[i, j].Blue;

                    pixels[i, j].Red = Convert.ToInt32(red + (1 - red) * value);
                    pixels[i, j].Green = Convert.ToInt32(green + (1 - green) * value);
                    pixels[i, j].Blue = Convert.ToInt32(blue + (1 - blue) * value);
                }
            }

            return bitmap();
        }

        public Bitmap reset()
        {
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    pixels[i, j] = new CustomPixel(
                        referencePixels[i, j].Red, 
                        referencePixels[i, j].Green, 
                        referencePixels[i, j].Blue);
                }
            }

            return bitmap();
        }
    }
}