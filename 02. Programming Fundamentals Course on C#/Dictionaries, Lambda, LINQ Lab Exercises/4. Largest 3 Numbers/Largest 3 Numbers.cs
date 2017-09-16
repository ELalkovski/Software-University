
namespace _4.Largest_3_Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Largest3Numbers
    {
        public static void Main()
        {
            IEnumerable<double> inputNums = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToList()
                .OrderByDescending(x => x)
                .Take(3);

            Console.WriteLine(string.Join(" ", inputNums));
        }
    }
}
