using System;
using System.Text.RegularExpressions;

namespace _03.Non_Digit_Count
{
    public class NonDigitCount
    {
        public static void Main()
        {
            var pattern = @"\D";
            var regex = new Regex(pattern);
            var input = Console.ReadLine();
            var matches = regex.Matches(input);
            Console.WriteLine($"Non-digits: {matches.Count}");
        }
    }
}
