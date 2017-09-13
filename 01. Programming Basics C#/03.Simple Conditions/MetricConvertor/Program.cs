using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetricConvertor
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var number = double.Parse(Console.ReadLine());
            string dimensionIN = (Console.ReadLine());
            string dimensionOUT = (Console.ReadLine());
            double firstRate = 0;
            double secondRate = 0;

            if (dimensionIN == "m")
            {
                firstRate = 1;
            }
            else if (dimensionIN == "mm")
            {
                firstRate = 1000;
            }

            else if (dimensionIN == "cm")
            {
                firstRate = 100;
            }
            else if (dimensionIN == "mi")
            {
                firstRate = 0.000621371192;
            }
            else if (dimensionIN == "in")
            {
                firstRate = 39.3700787;
            }
            else if (dimensionIN == "km")
            {
                firstRate = 0.001;
            }
            else if (dimensionIN == "ft")
            {
                firstRate = 3.2808399;
            }
            else if (dimensionIN == "yd")
            {
                firstRate = 1.0936133;
            }

            if (dimensionOUT == "m")
            {
                secondRate = 1;
            }
            else if (dimensionOUT == "mm")
            {
                secondRate = 1000;
            }
            else if (dimensionOUT == "cm")
            {
                secondRate = 100;
            }
            else if (dimensionOUT == "mi")
            {
                secondRate = 0.000621371192;
            }
            else if (dimensionOUT == "in")
            {
                secondRate = 39.3700787;
            }
            else if (dimensionOUT == "km")
            {
                secondRate = 0.001;
            }
            else if (dimensionOUT == "ft")
            {
                secondRate = 3.2808399;
            }
            else if (dimensionOUT == "yd")
            {
                secondRate = 1.0936133;
            }
            double result = number / firstRate * secondRate;
            Console.WriteLine(result + " " + dimensionOUT);

        }
    }
}
