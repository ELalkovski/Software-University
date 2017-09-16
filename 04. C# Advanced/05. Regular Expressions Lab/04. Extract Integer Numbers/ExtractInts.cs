using System;
using System.Text.RegularExpressions;

namespace _04.Extract_Integer_Numbers
{
    public class ExtractInts
    {
        public static void Main()
        {
            var pattern = @"\d+";
            var regex = new Regex(pattern);
            var input = Console.ReadLine();
            var matches = regex.Matches(input);
            foreach (var match in matches)
            {
                Console.WriteLine(match);
            }
        }
    }
}
