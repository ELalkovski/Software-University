namespace _3.Intersection_of_Circles
{
    using System;

    public class Point
    {
        public int X { get; set; }
        
        public int Y { get; set; }

        public static int CalculateDistance(Point c1, Point c2)
        {
            return (int)Math.Sqrt(Math.Pow((c1.X - c2.X), 2) + Math.Pow((c1.Y - c2.Y), 2));
        }
    }
}

