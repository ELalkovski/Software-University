using System;
using System.Linq;

namespace _02.Knights_of_Honor
{
    public class KnightsOfHonor
    {
        public static void Main()
        {
            var inputNames = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            Action<string> print = s => Console.WriteLine($"Sir {s}");

            inputNames.ForEach(print);
        }
    }
}
