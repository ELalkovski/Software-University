namespace _02.Knights_of_Honor
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class KnightsOfHonor
    {
        public static void Main()
        {
            List<string> inputNames = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            Action<string> print = s => Console.WriteLine($"Sir {s}");

            inputNames.ForEach(print);
        }
    }
}
