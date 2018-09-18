using System;

namespace PIS_mag_1_imageLightening_Darkening
{
    class CustomPixel
    {
        private int red;
        private int green;
        private int blue;

        static private double coeff = 255 / 10;

        public CustomPixel(int red, int green, int blue)
        {
            this.red = Convert.ToInt32(red / coeff);
            this.green = Convert.ToInt32(green / coeff);
            this.blue = Convert.ToInt32(blue / coeff);
        }

        public int Red
        {
            get => Convert.ToInt32(red * coeff);
            set => red = Convert.ToInt32(value / coeff);
        }

        public int Green
        {
            get => Convert.ToInt32(green * coeff);
            set => green = Convert.ToInt32(value / coeff);
        }

        public int Blue
        {
            get => Convert.ToInt32(blue * coeff);
            set => blue = Convert.ToInt32(value / coeff);
        }
    }
}