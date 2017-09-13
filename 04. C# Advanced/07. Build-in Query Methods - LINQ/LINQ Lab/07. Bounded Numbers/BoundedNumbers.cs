using System;
using System.Linq;

namespace _07.Bounded_Numbers
{
    public class BoundedNumbers
    {
        public static void Main()
        {
            var boundries = Console.ReadLine()
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
