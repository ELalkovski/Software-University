namespace Calculate_Triangle_Area
{
    using System;

    public class TriangleArea
    {
        public static void Main()
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            Console.WriteLine(GetTriangleArea(width, height)); 
        }

        private static double GetTriangleArea(double width, double height)
        {
            return width * height / 2;
        }
    }
}
