namespace _8.Logs_Aggregator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class LogsAggregator
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var logsDict = new SortedDictionary<string, SortedDictionary<string, int>>();
            var totalCount = 0;

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(' ');
                var username = input[1];
                var duration = int.Parse(input[2]);
                var ipAdress = input[0];

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
