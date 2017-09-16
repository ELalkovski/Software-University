using System;
using System.Text;
using System.Text.RegularExpressions;

namespace _04.Replace_anchor_tag
{
    public class ReplaceTag
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var regex = new Regex(@"(<a href="")(.*?)("">)(.*?)(<\/a>)");
            var sb = new StringBuilder();

            while (input != "end")
            {
                sb.AppendLine(input);
                input = Console.ReadLine();
            }

            var recievedInput = sb.ToString();
            var match = regex.Match(recievedInput);
            recievedInput = recievedInput.Replace(match.Groups[1].Value, @"[URL href=""");
            recievedInput = recievedInput.Replace(match.Groups[3].Value, @"""]");
            recievedInput = recievedInput.Replace(match.Groups[5].Value, "[/URL]");
            Console.WriteLine(recievedInput);
        }
    }
}