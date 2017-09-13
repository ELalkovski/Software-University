namespace Inches_To_Centimeters
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            Console.Write("inches = ");
            double inches = double.Parse(Console.ReadLine());
            double centimeters = inches * 2.54;

            Console.WriteLine(centimeters);
        }
    }
}
