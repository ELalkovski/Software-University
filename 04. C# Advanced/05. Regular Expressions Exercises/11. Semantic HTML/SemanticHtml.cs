namespace _11.Semantic_HTML
{
    using System;
    using System.Text;
    using System.Text.RegularExpressions;

    public class SemanticHtml
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            StringBuilder sb = new StringBuilder();

            while (input != "END")
            {
                sb.AppendLine(input);
                input = Console.ReadLine();
            }

            string htmlDocument = sb.ToString();
            Regex openDivTagRegex = new Regex("<(div).+?>");
            Regex whitespacesPattern = new Regex("\\s+>");
            MatchCollection matches = openDivTagRegex.Matches(htmlDocument);

            foreach (Match match in matches) // Replacing opening div tags with their apropriate cemantic tag
            {
                string matchToBeReplaced = match.ToString();
                Regex tagName = new Regex(@"(?<replacedGroup>id\s*=\s*""(?<name>.+?)"")|(?<replacedGroup>class\s*=\s*""(?<name>.+?)"")");
                Match atributeMatch = tagName.Match(match.ToString());
                string replaceName = atributeMatch.Groups["name"].Value;

                matchToBeReplaced = matchToBeReplaced.Replace(match.Groups[1].Value, replaceName);
                matchToBeReplaced = matchToBeReplaced.Replace(atributeMatch.Groups["replacedGroup"].Value, "");
                matchToBeReplaced = Regex.Replace(matchToBeReplaced, "\\s+", " ");

                if (whitespacesPattern.IsMatch(matchToBeReplaced))
                {
                    Match currMatch = whitespacesPattern.Match(matchToBeReplaced);
                    matchToBeReplaced = matchToBeReplaced.Replace(currMatch.ToString(), ">");
                }

                htmlDocument = htmlDocument.Replace(match.ToString(), matchToBeReplaced);
            }

            Regex closeDivTagsRegex = new Regex(@"<\/(?<replace>div>\s*<(\s*!--\s*(?<name>.+?)\s*--))>");
            MatchCollection closeMatches = closeDivTagsRegex.Matches(htmlDocument);

            foreach (Match match in closeMatches) // // Replacing closing div tags with their apropriate cemantic tag
            {
                string matchToBeReplaced = match.ToString();
                string replaceName = match.Groups["name"].Value;
                string tagToBeReplaced = match.Groups["replace"].Value;

                matchToBeReplaced = matchToBeReplaced.Replace(tagToBeReplaced, replaceName);

                htmlDocument = htmlDocument.Replace(match.ToString(), matchToBeReplaced);
            }

            Console.WriteLine(htmlDocument);
        }
    }
}
