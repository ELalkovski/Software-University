namespace _03.Non_Digit_Count
{
    using System;
    using System.Text.RegularExpressions;

    public class NonDigitCount
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            string pattern = @"\D";
            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(input);

            Console.WriteLine($"Non-digits: {matches.Count}");
        }
    }
}
