using System;

namespace MyPhotoshop
{
	public class Photo
	{
		private int width;
		private int height;
        //public Pixel[,] data;
        private Pixel[,] pixels;

        public Photo(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        public Pixel[,] Pixels
        {
            set
            {
                pixels = value;
            }
        }

        public Pixel this[int x, int y]
        {
            get
            {
                return pixels[x, y];
            }
            set
            {
                pixels[x, y] = value;
            }
        }

        public int Width
        {
            get
            {
                return width;
            }
        }

        public int Height
        {
            get
            {
                return height;
            }
        }
    }
}

