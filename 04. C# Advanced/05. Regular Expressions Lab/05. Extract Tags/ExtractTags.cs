using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _05.Extract_Tags
{
    public class ExtractTags
    {
        public static void Main()
        {
            var pattern = @"<.+?>";
            var regex = new Regex(pattern);
            var input = Console.ReadLine();

            while (input != "END")
            {
                var matches = regex.Matches(input);

                foreach (var match in matches)
                {
                    Console.WriteLine(match);
                }
                input = Console.ReadLine();
            }
        }
    }
}
