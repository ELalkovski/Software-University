using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _4.Query_Mess
{
    public class QueryMess
    {
        public static void Main()
        {
            var input = Console.ReadLine();      
            var resultsList = new List<string>();

            while (input != "END")
            {
                var queryDict = new Dictionary<string, List<string>>();
                var sb = new StringBuilder();
                var regex = new Regex(@"(%20)|\+");
                var spacesRegex = new Regex(@"\s+");
                var replacedInput = regex.Replace(input, " ");
                var filteredInput = spacesRegex.Replace(replacedInput, " ");
                var splitedInput = filteredInput.Split(new[] { '&', '?' }, StringSplitOptions.RemoveEmptyEntries);
                var matchPattern = new Regex(@"[a-zA-Z0-9]+=[a-zA-Z0-9]+|[a-zA-Z0-9]+= [a-zA-Z0-9]+|[a-zA-Z0-9]+ =[a-zA-Z0-9]+|[a-zA-Z0-9]+ = [a-zA-Z0-9]+| [a-zA-Z0-9]+=[a-zA-Z0-9]+| [a-zA-Z0-9]+ =[a-zA-Z0-9]+| [a-zA-Z0-9]+= [a-zA-Z0-9]+| [a-zA-Z0-9]+ = [a-zA-Z0-9]+");

                for (int i = 0; i < splitedInput.Length; i++)
                {
                    if (matchPattern.IsMatch(splitedInput[i]))
                    {
                        var currQuery = splitedInput[i].Split('=').ToList();
                        var key = currQuery[0].Trim();
                        var value = currQuery[1].Trim();
                        var valuesList = new List<string>();

                        if (queryDict.ContainsKey(key))
                        {
                            valuesList.Add(value);
                            queryDict[key].AddRange(valuesList);
                        }
                        else
                        {
                            valuesList.Add(value);
                            queryDict.Add(key, valuesList);

                        }
                    }
                    
                }
                var result = string.Empty;

                foreach (var item in queryDict)
                {
                    string piece = $"{item.Key}=[{string.Join(", ", item.Value)}]";
                    result = sb.Append(piece).ToString();
                }
                resultsList.Add(result);
                input = Console.ReadLine();

            }

            foreach (var line in resultsList)
            {
                Console.WriteLine(line);
            }
        }
    }
}
