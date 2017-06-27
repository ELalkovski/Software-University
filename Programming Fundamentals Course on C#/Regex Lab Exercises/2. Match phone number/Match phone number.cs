using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _2.Match_phone_number
{
    public class MatchPhoneNumber
    {
        public static void Main()
        {
            var input = "359-2-222-2222, +359/2/222/2222, +359-2 222 2222, +359 2 222 2222";
            var regex = new Regex(@"\+(\d{3})\s\d\s\d{3}\s\d{4}");
            var matches = regex.Match(input);
            Console.WriteLine(string.Join("",matches));
        }
    }
}
