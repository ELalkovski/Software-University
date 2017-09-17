namespace _07.Predicate_for_names
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class PredicateNames
    {
        public static void Main()
        {
            int wordLengthBoundry = int.Parse(Console.ReadLine());
            List<string> inputNames = Console.ReadLine()
                .Split(new []{" "}, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            Predicate<string> isLengthInBoundries = (w) => { return w.Length <= wordLengthBoundry; };

            Console.WriteLine(string.Join("\n", inputNames.FindAll(isLengthInBoundries)));
        }
    }
}
