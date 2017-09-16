namespace _2.Match_phone_number
{
    using System;
    using System.Text.RegularExpressions;

    public class MatchPhoneNumber
    {
        public static void Main()
        {
            string input = "359-2-222-2222, +359/2/222/2222, +359-2 222 2222, +359 2 222 2222";
            Regex regex = new Regex(@"\+(\d{3})\s\d\s\d{3}\s\d{4}");
            Match match = regex.Match(input);

            Console.WriteLine(match);
        }
    }
}
