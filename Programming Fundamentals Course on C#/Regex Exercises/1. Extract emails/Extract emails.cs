using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _1.Extract_emails
{
    public class ExtractEmails
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var regex = new Regex(@"(?<= )[A-Za-z0-9]+[A-Za-z0-9._-]+\@[A-Za-z0-9]+[A-Za-z0-9._-]+\.[A-Za-z]{2,}");
            var matches = regex.Matches(input);

            foreach (Match match in matches)
            {
                Console.WriteLine(match);
            }
        }
    }
}
