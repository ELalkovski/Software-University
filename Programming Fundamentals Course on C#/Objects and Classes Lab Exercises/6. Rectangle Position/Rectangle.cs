namespace _6.Rectangle_Position
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
     
    public class Rectangle
    {
        public int Left { get; set; }

        public int Top { get; set; }

        public int Width { get; set; }

        public int Height { get; set; }

        public int Area => Width * Height;

        public int Bottom => Top - Height;

        public int Right => Left + Width;
 
    }
}
