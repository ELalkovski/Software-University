namespace _01.Match_Count
{
    using System;
    using System.Text.RegularExpressions;

    public class MatchCount
    {
        public static void Main()
        {
            Regex pattern = new Regex(Console.ReadLine());
            string text = Console.ReadLine();

            MatchCollection matches = pattern.Matches(text);

            Console.WriteLine(matches.Count);
        }
    }
}
