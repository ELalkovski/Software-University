namespace _07.Bounded_Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class BoundedNumbers
    {
        public static void Main()
        {
            List<int> boundries = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            Console.WriteLine(string.Join(" ", Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList()
                .FindAll(n => n >= Math.Min(boundries[0], boundries[1]) && n <= Math.Max(boundries[0], boundries[1]))));

        }
    }
}
