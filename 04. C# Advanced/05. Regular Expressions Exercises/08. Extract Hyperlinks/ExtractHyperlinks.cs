namespace _08.Extract_Hyperlinks
{
    using System;
    using System.Text;
    using System.Text.RegularExpressions;

    public class ExtractHyperlinks
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            Regex anchorTagsRegex = new Regex(@"<a\s.+?>");
            Regex hyperlinksRegex = new Regex(@"(href\s*=\s*""(?<result>.+?)"")|(href\s*=\s*'(?<result>.+?)')|(href\s*=\s*(?<result>.+?)[\s>])");
            StringBuilder sb = new StringBuilder();

            while (input != "END")
            {
                sb.Append(input);
                input = Console.ReadLine();
            }

            MatchCollection anchorMatches = anchorTagsRegex.Matches(sb.ToString());

            foreach (var aTag in anchorMatches)
            {
                string currTag = aTag.ToString();

                if (hyperlinksRegex.IsMatch(aTag.ToString()))
                {
                    Group match = hyperlinksRegex.Match(aTag.ToString()).Groups["result"];

                    Console.WriteLine(match);
                }
            }
        }
    }
}