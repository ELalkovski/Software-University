namespace CelsiusToFahrenheit
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            Console.Write("Celsius = ");
            double celcius = double.Parse(Console.ReadLine());

            double fahrenheit = celcius * 1.8 + 32;
            Console.WriteLine("Fahrenheit = " + fahrenheit);
        }
    }
}
