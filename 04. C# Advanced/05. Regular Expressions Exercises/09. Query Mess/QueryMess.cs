namespace _09.Query_Mess
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Text.RegularExpressions;

    public class QueryMess
    {
        public static void Main()
        {
            string[] input = Console.ReadLine()
                .Split(new[] { '&', '?' }, StringSplitOptions.RemoveEmptyEntries);

            Regex regex = new Regex(@"(?<key>[^&?]+)\s*=\s*(?<value>[^&?]+)");
            Regex spacePattern = new Regex(@"%20|\+");

            Dictionary<string, List<string>> fields = new Dictionary<string, List<string>>();
            List<string> results = new List<string>();
            StringBuilder sb = new StringBuilder();

            while (input[0] != "END")
            {
                for (int i = 0; i < input.Length; i++)
                {
                    string currField = input[i];

                    if (spacePattern.IsMatch(currField))
                    {
                        MatchCollection matches = spacePattern.Matches(currField);

                        foreach (var match in matches)
                        {
                            currField = currField.Replace(match.ToString(), " ");
                        }
                    }
                    if (regex.IsMatch(currField))
                    {
                        string key = regex.Match(currField).Groups["key"].Value.Trim();
                        string value = regex.Match(currField).Groups["value"].Value.Trim();

                        try
                        {
                            string[] tokensOfValue = value.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                            value = string.Join(" ", tokensOfValue);
                        }
                        catch (Exception)
                        {
                        }

                        if (!fields.ContainsKey(key))
                        {
                            fields.Add(key, new List<string>());
                        }

                        fields[key].Add(value);
                    }
                }

                foreach (var field in fields)
                {
                    sb.Append($"{field.Key}=[");
                    sb.Append(string.Join(", ", field.Value));
                    sb.Append("]");
                }

                results.Add(sb.ToString());
                sb.Clear();
                fields = new Dictionary<string, List<string>>();
                input = Console.ReadLine()
                    .Split(new[] { '&' }, StringSplitOptions.RemoveEmptyEntries);
            }

            foreach (var entry in results)
            {
                Console.WriteLine(entry);
            }
        }
    }
}