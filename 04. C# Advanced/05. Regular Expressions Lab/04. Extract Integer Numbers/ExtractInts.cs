namespace _04.Extract_Integer_Numbers
{
    using System;
    using System.Text.RegularExpressions;

    public class ExtractInts
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            string pattern = @"\d+";
            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(input);

            foreach (var match in matches)
            {
                Console.WriteLine(match);
            }
        }
    }
}
