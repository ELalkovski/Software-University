
namespace _4.Largest_3_Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;


    class Largest3Numbers
    {
        public static void Main()
        {
            var inputNums = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToList()
                .OrderByDescending(x => x)
                .Take(3);

            Console.WriteLine(string.Join(" ", inputNums));
        }
    }
}
