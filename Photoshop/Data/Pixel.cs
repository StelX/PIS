using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyPhotoshop
{
    public struct Pixel
    {
        private double r;
        private double g;
        private double b;

        public Pixel(double red, double green, double blue)
        {
            r = red;
            g = green;
            b = blue;
        }

        public static Pixel operator * (Pixel pixel, double value)
        {
            return multiplePixel(pixel, value);
        }

        public static Pixel operator * (double value, Pixel pixel)
        {
            return multiplePixel(pixel, value);
        }
        
        private static Pixel multiplePixel(Pixel pixel, double value)
        {
            Pixel newPixel = new Pixel(pixel.R * value, pixel.G * value, pixel.B * value);
            return newPixel;
        }

        public double R
        {
            get
            {
                return r;
            }
            set
            {
                if (value > 1)
                {
                    r = 1;
                    return;
                }
                r = value;
            }
        }

        public double G
        {
            get
            {
                return g;
            }
            set
            {
                if (value > 1)
                {
                    g = 1;
                    return;
                }
                g = value;
            }
        }

        public double B
        {
            get
            {
                return b;
            }
            set
            {
                if (value > 1)
                {
                    b = 1;
                    return;
                }
                b = value;
            }
        }
    }
}
