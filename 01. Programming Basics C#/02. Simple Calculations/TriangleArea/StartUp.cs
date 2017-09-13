namespace TriangleArea
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            double area = a * h / 2;

            Console.WriteLine("Triangle area = " + Math.Round(area, 2));
        }
    }
}
