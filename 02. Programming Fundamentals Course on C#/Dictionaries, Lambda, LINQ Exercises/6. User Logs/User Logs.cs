namespace _6.User_Logs
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class UserLogs
    {
        public static void Main()
        {
            SortedDictionary<string, List<string>> users = new SortedDictionary<string, List<string>>();
            string command = "";

            while (true)
            {
                List<string> entry = Console.ReadLine()
                    .Split()
                    .ToList();

                command = entry[0];

                if (command == "end")
                {
                    break;
                }

                int indexOfIP = command.IndexOf('=') + 1;
                string ip = command.Substring(indexOfIP);
                int indexOfUser = entry[2].LastIndexOf('=') + 1;
                string user = entry[2].Substring(indexOfUser);

                List<string> allIps = new List<string>();
                allIps.Add(ip);

                if (!users.ContainsKey(user))
                {
                    users[user] = allIps;
                }
                else
                {
                    users[user].AddRange(allIps);
                }
            }

            foreach (var user in users)
            {
                Console.WriteLine(user.Key + ": ");
                List<string> ips = user.Value;
                Dictionary<string, int> numberOfIPs = new Dictionary<string, int>();

                foreach (var ip in ips)
                {
                    if (!numberOfIPs.ContainsKey(ip))
                    {
                        numberOfIPs[ip] = 1;
                    }
                    else
                    {
                        numberOfIPs[ip] += 1;
                    }
                }

                int count = numberOfIPs.Count;

                foreach (var ip in numberOfIPs)
                {
                    count--;

                    if (count > 0)
                    {
                        Console.Write(ip.Key + " => " + ip.Value + ", ");
                    }
                    else
                    {
                        Console.Write(ip.Key + " => " + ip.Value + ". ");
                    }
                }

                Console.WriteLine();
            }
        }
    }
}
