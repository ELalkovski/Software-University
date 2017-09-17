namespace _04.Replace_anchor_tag
{
    using System;
    using System.Text;
    using System.Text.RegularExpressions;

    public class ReplaceTag
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            Regex regex = new Regex(@"(<a href="")(.*?)("">)(.*?)(<\/a>)");
            StringBuilder sb = new StringBuilder();

            while (input != "end")
            {
                sb.AppendLine(input);
                input = Console.ReadLine();
            }

            string recievedInput = sb.ToString();
            Match match = regex.Match(recievedInput);

            recievedInput = recievedInput.Replace(match.Groups[1].Value, @"[URL href=""");
            recievedInput = recievedInput.Replace(match.Groups[3].Value, @"""]");
            recievedInput = recievedInput.Replace(match.Groups[5].Value, "[/URL]");

            Console.WriteLine(recievedInput);
        }
    }
}