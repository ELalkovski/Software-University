namespace _02.Vowels_Count
{
    using System;
    using System.Text.RegularExpressions;

    public class VowelsCount
    {
        public static void Main()
        {
            string pattern = "[AEIOUYaeiouy]";
            string input = Console.ReadLine();

            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(input);

            Console.WriteLine($"Vowels: {matches.Count}");
        }
    }
}
