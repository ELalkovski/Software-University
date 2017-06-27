using System;
using System.Text.RegularExpressions;

namespace _02.Vowels_Count
{
    class VowelsCount
    {
        static void Main()
        {
            var pattern = "[AEIOUYaeiouy]";
            var regex = new Regex(pattern);
            var input = Console.ReadLine();
            var matches = regex.Matches(input);
            Console.WriteLine($"Vowels: {matches.Count}");
        }
    }
}
