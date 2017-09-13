namespace MetricConvertor
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            double number = double.Parse(Console.ReadLine());
            string dimensionIn = (Console.ReadLine());
            string dimensionOut = (Console.ReadLine());
            double firstRate = 0;
            double secondRate = 0;

            if (dimensionIn == "m")
            {
                firstRate = 1;
            }
            else if (dimensionIn == "mm")
            {
                firstRate = 1000;
            }
            else if (dimensionIn == "cm")
            {
                firstRate = 100;
            }
            else if (dimensionIn == "mi")
            {
                firstRate = 0.000621371192;
            }
            else if (dimensionIn == "in")
            {
                firstRate = 39.3700787;
            }
            else if (dimensionIn == "km")
            {
                firstRate = 0.001;
            }
            else if (dimensionIn == "ft")
            {
                firstRate = 3.2808399;
            }
            else if (dimensionIn == "yd")
            {
                firstRate = 1.0936133;
            }

            if (dimensionOut == "m")
            {
                secondRate = 1;
            }
            else if (dimensionOut == "mm")
            {
                secondRate = 1000;
            }
            else if (dimensionOut == "cm")
            {
                secondRate = 100;
            }
            else if (dimensionOut == "mi")
            {
                secondRate = 0.000621371192;
            }
            else if (dimensionOut == "in")
            {
                secondRate = 39.3700787;
            }
            else if (dimensionOut == "km")
            {
                secondRate = 0.001;
            }
            else if (dimensionOut == "ft")
            {
                secondRate = 3.2808399;
            }
            else if (dimensionOut == "yd")
            {
                secondRate = 1.0936133;
            }

            double result = number / firstRate * secondRate;
            Console.WriteLine(result + " " + dimensionOut);
        }
    }
}
