namespace Trapezoid_area
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            double b1 = double.Parse(Console.ReadLine());
            double b2 = double.Parse(Console.ReadLine());
            double h1 = double.Parse(Console.ReadLine());
            double area = (b1 + b2) * h1 / 2;

            Console.WriteLine("Trapezoid area = " + area);
        }
    }
}
