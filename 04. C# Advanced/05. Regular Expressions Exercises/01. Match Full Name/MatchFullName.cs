namespace _01.Match_Full_Name
{
    using System;
    using System.Text.RegularExpressions;

    public class MatchFullName
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            while (input != "end")
            {
                Match match = new Regex(@"\b[A-Z][a-z]{1,} [A-Z][a-z]{1,}\b").Match(input);

                Console.WriteLine(match);
                input = Console.ReadLine();
            }
        }
    }
}
