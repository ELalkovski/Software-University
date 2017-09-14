namespace Circle_Area__12_digits_precision_
{
    using System;

    public class CircleArea
    {
        public static void Main()
        {
            Console.Write("Enter a radius: ");
            double r = double.Parse(Console.ReadLine());
            double area = Math.PI * r * r;
            Console.WriteLine("Area of the circle is {0:f12}",area);
        }
    }
}
