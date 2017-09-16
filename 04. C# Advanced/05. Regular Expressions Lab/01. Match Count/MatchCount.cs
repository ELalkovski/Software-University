using System;
using System.Text.RegularExpressions;

namespace _01.Match_Count
{
    public class MatchCount
    {
        public static void Main()
        {
            var pattern = new Regex(Console.ReadLine());
            var text = Console.ReadLine();
            var matches = pattern.Matches(text);
            Console.WriteLine(matches.Count);
        }
    }
}
