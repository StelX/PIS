using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyPhotoshop
{
    public class Pixel
    {
        public double R { get; set; }
        public double G { get; set; }
        public double B { get; set; }
        public Pixel(double red, double green, double blue)
        {
            this.R = red;
            this.G = green;
            this.B = blue;
        }

    }
}
