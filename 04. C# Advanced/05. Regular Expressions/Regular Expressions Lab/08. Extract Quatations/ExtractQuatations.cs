using System;
using System.Text.RegularExpressions;

namespace _08.Extract_Quatations
{
    public class ExtractQuatations
    {
        public static void Main()
        {
            var regex = new Regex("(\"|\')(.*?)\\1");
            var input = Console.ReadLine();
            var matches = regex.Matches(input);
            foreach (Match match in matches)
            {
                Console.WriteLine(match.Groups[2].Value);
            }
        }
    }
}
