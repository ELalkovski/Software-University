using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _01.Match_Full_Name
{
    public class MatchFullName
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            while (input != "end")
            {
                var match = new Regex(@"\b[A-Z][a-z]{1,} [A-Z][a-z]{1,}\b").Match(input);
                Console.WriteLine(match);
                input = Console.ReadLine();
            }
        }
    }
}
