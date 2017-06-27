using System;
using System.Text;
using System.Text.RegularExpressions;

namespace _08.Extract_Hyperlinks
{
    public class ExtractHyperlinks
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var anchorTagsRegex = new Regex(@"<a\s.+?>");
            var hyperlinksRegex = new Regex(@"(href\s*=\s*""(?<result>.+?)"")|(href\s*=\s*'(?<result>.+?)')|(href\s*=\s*(?<result>.+?)[\s>])");
            var sb = new StringBuilder();

            while (input != "END")
            {
                sb.Append(input);
                input = Console.ReadLine();
            }

            var anchorMatches = anchorTagsRegex.Matches(sb.ToString());

            foreach (var aTag in anchorMatches)
            {
                var currTag = aTag.ToString();

                if (hyperlinksRegex.IsMatch(aTag.ToString()))
                {
                    var match = hyperlinksRegex.Match(aTag.ToString()).Groups["result"];
                    Console.WriteLine(match);
                }
            }
        }
    }
}