namespace _1.Extract_emails
{
    using System;
    using System.Text.RegularExpressions;

    public class ExtractEmails
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            Regex regex = new Regex(@"(?<= )[A-Za-z0-9]+[A-Za-z0-9._-]+\@[A-Za-z0-9]+[A-Za-z0-9._-]+\.[A-Za-z]{2,}");
            MatchCollection matches = regex.Matches(input);

            foreach (Match match in matches)
            {
                Console.WriteLine(match);
            }
        }
    }
}
