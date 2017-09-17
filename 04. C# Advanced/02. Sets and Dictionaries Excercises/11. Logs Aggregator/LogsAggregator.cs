namespace _11.Logs_Aggregator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;


    public class LogsAggregator
    {
        public static void Main()
        {
            /*
             This program aggregates the logs data and prints for each user the total duration of his sessions and a list of unique IP addresses 
             in format "{user}: {duration} [{IP1}, {IP2}, …]". 
             Orders the users alphabetically. Orders the IPs alphabetically.
             At the first line the program recieves a number n which says how many log lines will follow. 
             Each of the next n lines holds a log information in format <IP> <user> <duration>. 
             */

            int inputCount = int.Parse(Console.ReadLine());

            SortedDictionary<string, SortedDictionary<string, int>> usersLogs = new SortedDictionary<string, SortedDictionary<string, int>>();
            
            for (int i = 0; i < inputCount; i++)
            {
                string[] tokens = Console.ReadLine()
                    .Split(' ');

                string ipAdress = tokens[0];
                string username = tokens[1];
                int duration = int.Parse(tokens[2]);

                if (!usersLogs.ContainsKey(username))
                {
                    usersLogs[username] = new SortedDictionary<string, int>();
                }

                if (!usersLogs[username].ContainsKey(ipAdress))
                {
                    usersLogs[username].Add(ipAdress, duration);
                }
                else
                {
                    usersLogs[username][ipAdress] += duration;
                }
            }

            foreach (var user in usersLogs)
            {
                Console.Write($"{user.Key}: {user.Value.Values.Sum()} ");
                Console.Write("[");
                Console.Write(string.Join(", ", user.Value.Keys));
                Console.Write("]");
                Console.WriteLine();
            }
        }
    }
}
