namespace _04.Add_VAT
{
    using System;
    using System.Linq;

    public class AddVat
    {
        public static void Main()
        {
            double[] numbers = Console.ReadLine()
                .Split(new []{", "},StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .Select(n => n + n * 0.2)
                .ToArray();

            foreach (var num in numbers)
            {
                Console.WriteLine($"{num:f2}");
            }

        }
    }
}
