using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _1.Match_full_name
{
    public class MatchNames
    {
        public static void Main()
        {
            var input = "ivan ivanov, Ivan ivanov, ivan Ivanov, IVan Ivanov, Ivan IvAnov, Ivan	Ivanov, Ivan Ivanov";

            var regex = new Regex(@"\b[A-Z][a-z]+ [A-Z][a-z]+\b");
            var mathes = regex.Match(input);

            Console.WriteLine(string.Join("", mathes));
        }
    }
}
