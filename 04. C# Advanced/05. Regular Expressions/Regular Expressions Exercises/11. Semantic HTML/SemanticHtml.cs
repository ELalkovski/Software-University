using System;
using System.Text;
using System.Text.RegularExpressions;

namespace _11.Semantic_HTML
{
    public class SemanticHtml
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var sb = new StringBuilder();

            while (input != "END")
            {
                sb.AppendLine(input);
                input = Console.ReadLine();
            }

            var htmlDocument = sb.ToString();
            var openDivTagRegex = new Regex("<(div).+?>");
            var whitespacesPattern = new Regex("\\s+>");
            var matches = openDivTagRegex.Matches(htmlDocument);

            foreach (Match match in matches) // Replacing opening div tags with their apropriate cemantic tag
            {
                var matchToBeReplaced = match.ToString();
                var tagName = new Regex(@"(?<replacedGroup>id\s*=\s*""(?<name>.+?)"")|(?<replacedGroup>class\s*=\s*""(?<name>.+?)"")");
                var atributeMatch = tagName.Match(match.ToString());
                var replaceName = atributeMatch.Groups["name"].Value;
                matchToBeReplaced = matchToBeReplaced.Replace(match.Groups[1].Value, replaceName);
                matchToBeReplaced = matchToBeReplaced.Replace(atributeMatch.Groups["replacedGroup"].Value, "");
                matchToBeReplaced = Regex.Replace(matchToBeReplaced, "\\s+", " ");
                if (whitespacesPattern.IsMatch(matchToBeReplaced))
                {
                    var currMatch = whitespacesPattern.Match(matchToBeReplaced);
                    matchToBeReplaced = matchToBeReplaced.Replace(currMatch.ToString(), ">");
                    
                }

                htmlDocument = htmlDocument.Replace(match.ToString(), matchToBeReplaced);
            }

            var closeDivTagsRegex = new Regex(@"<\/(?<replace>div>\s*<(\s*!--\s*(?<name>.+?)\s*--))>");
            var closeMatches = closeDivTagsRegex.Matches(htmlDocument);

            foreach (Match match in closeMatches) // // Replacing closing div tags with their apropriate cemantic tag
            {
                var matchToBeReplaced = match.ToString();
                var replaceName = match.Groups["name"].Value;
                var tagToBeReplaced = match.Groups["replace"].Value;
                matchToBeReplaced = matchToBeReplaced.Replace(tagToBeReplaced, replaceName);

                htmlDocument = htmlDocument.Replace(match.ToString(), matchToBeReplaced);
            }
            Console.WriteLine(htmlDocument);
        }
    }
}
