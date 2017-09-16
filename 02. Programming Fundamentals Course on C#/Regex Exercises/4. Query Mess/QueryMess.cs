namespace _4.Query_Mess
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;

    public class QueryMess
    {
        public static void Main()
        {
            string input = Console.ReadLine();      
            List<string> resultsList = new List<string>();

            while (input != "END")
            {
                Dictionary<string, List<string>> queryDict = new Dictionary<string, List<string>>();
                StringBuilder sb = new StringBuilder();
                Regex regex = new Regex(@"(%20)|\+");
                Regex spacesRegex = new Regex(@"\s+");
                string replacedInput = regex.Replace(input, " ");
                string filteredInput = spacesRegex.Replace(replacedInput, " ");
                string[] splitedInput = filteredInput
                    .Split(new[] { '&', '?' }, StringSplitOptions.RemoveEmptyEntries);
                Regex matchPattern = new Regex(@"[a-zA-Z0-9]+=[a-zA-Z0-9]+|[a-zA-Z0-9]+= [a-zA-Z0-9]+|[a-zA-Z0-9]+ =[a-zA-Z0-9]+|[a-zA-Z0-9]+ = [a-zA-Z0-9]+| [a-zA-Z0-9]+=[a-zA-Z0-9]+| [a-zA-Z0-9]+ =[a-zA-Z0-9]+| [a-zA-Z0-9]+= [a-zA-Z0-9]+| [a-zA-Z0-9]+ = [a-zA-Z0-9]+");

                for (int i = 0; i < splitedInput.Length; i++)
                {
                    if (matchPattern.IsMatch(splitedInput[i]))
                    {
                        List<string> currQuery = splitedInput[i].Split('=').ToList();
                        string key = currQuery[0].Trim();
                        string value = currQuery[1].Trim();
                        List<string> valuesList = new List<string>();

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

                string result = string.Empty;

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
