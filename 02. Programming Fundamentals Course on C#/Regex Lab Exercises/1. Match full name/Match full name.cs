namespace _1.Match_full_name
{
    using System;
    using System.Text.RegularExpressions;

    public class MatchNames
    {
        public static void Main()
        {
            string input = "ivan ivanov, Ivan ivanov, ivan Ivanov, IVan Ivanov, Ivan IvAnov, Ivan	Ivanov, Ivan Ivanov";
            Regex regex = new Regex(@"\b[A-Z][a-z]+ [A-Z][a-z]+\b");
            Match match = regex.Match(input);

            Console.WriteLine(match);
        }
    }
}
