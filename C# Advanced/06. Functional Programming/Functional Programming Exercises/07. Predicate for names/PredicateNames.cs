using System;
using System.Linq;

namespace _07.Predicate_for_names
{
    public class PredicateNames
    {
        public static void Main()
        {
            var wordLengthBoundry = int.Parse(Console.ReadLine());
            var inputNames = Console.ReadLine()
                .Split(new []{" "}, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            Predicate<string> isLengthInBoundries = (w) => { return w.Length <= wordLengthBoundry; };

            Console.WriteLine(string.Join("\n", inputNames.FindAll(isLengthInBoundries)));
        }
    }
}
