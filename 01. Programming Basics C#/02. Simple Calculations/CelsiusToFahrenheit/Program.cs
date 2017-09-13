using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CelsiusToFahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Celsius = ");
            var Celcius = double.Parse(Console.ReadLine());
            var Fahrenheit = Celcius * 1.8 + 32;
            Console.WriteLine("Fahrenheit = " + Fahrenheit);
        }
    }
}
