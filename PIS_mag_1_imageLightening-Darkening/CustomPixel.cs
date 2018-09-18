namespace PIS_mag_1_imageLightening_Darkening
{
    class CustomPixel
    {
        private int red;
        private int green;
        private int blue;

        public CustomPixel(int red, int green, int blue)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
        }

        public int Red { get => red; set => red = value; }
        public int Green { get => green; set => green = value; }
        public int Blue { get => blue; set => blue = value; }
    }
}