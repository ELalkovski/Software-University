namespace Sort_Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SortNumbers
    {
        public static void Main()
        {
            List<double> input = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToList();

            input.Sort();

            Console.WriteLine(string.Join(" <= ", input));
        }
    }
}
