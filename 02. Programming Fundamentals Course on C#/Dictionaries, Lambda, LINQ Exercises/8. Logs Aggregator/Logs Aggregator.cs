namespace _8.Logs_Aggregator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class LogsAggregator
    {
        public static void Main()
        {
            int linesCount = int.Parse(Console.ReadLine());
            SortedDictionary<string, SortedDictionary<string, int>> logsDict = new SortedDictionary<string, SortedDictionary<string, int>>();

            int totalCount = 0;

            for (int i = 0; i < linesCount; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                string username = input[1];
                int duration = int.Parse(input[2]);
                string ipAdress = input[0];

                if (!logsDict.ContainsKey(username))
                {
                    logsDict[username] = new SortedDictionary<string, int>();
                }
                if (!logsDict[username].ContainsKey(ipAdress))
                {
                    logsDict[username][ipAdress] = 0;
                }

                logsDict[username][ipAdress] += duration;
            }

            Console.WriteLine();

            foreach (var outerPair in logsDict)
            {
                var sum = outerPair.Value.Values.Sum();

                Console.Write("{0}: {1} ", outerPair.Key, sum);
                Console.Write("[");
                Console.Write(string.Join(", ", outerPair.Value.Keys.Distinct()));
                Console.Write("]");
                Console.WriteLine();
            }
        }
    }
}
