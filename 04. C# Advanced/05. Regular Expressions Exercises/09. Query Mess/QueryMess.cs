using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace _09.Query_Mess
{
    public class QueryMess
    {
        public static void Main()
        {
            var input = Console.ReadLine()
                .Split(new[] { '&', '?' }, StringSplitOptions.RemoveEmptyEntries);

            var regex = new Regex(@"(?<key>[^&?]+)\s*=\s*(?<value>[^&?]+)");
            var spacePattern = new Regex(@"%20|\+");

            var fields = new Dictionary<string, List<string>>();
            var results = new List<string>();
            var sb = new StringBuilder();

            while (input[0] != "END")
            {
                for (int i = 0; i < input.Length; i++)
                {
                    var currField = input[i];
                    if (spacePattern.IsMatch(currField))
                    {
                        var matches = spacePattern.Matches(currField);
                        foreach (var match in matches)
                        {
                            currField = currField.Replace(match.ToString(), " ");
                        }
                    }
                    if (regex.IsMatch(currField))
                    {
                        var key = regex.Match(currField).Groups["key"].Value.Trim();
                        var value = regex.Match(currField).Groups["value"].Value.Trim();

                        try
                        {
                            var tokensOfValue = value.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
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