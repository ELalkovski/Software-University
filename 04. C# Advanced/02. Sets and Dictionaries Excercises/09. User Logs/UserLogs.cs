namespace _09.User_Logs
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class UserLogs
    {
        public static void Main()
        {
            /*
             The program recieves an input, until the string "end" is recieved, in the format:
                IP={IP.Address} message=’{A&sample&message}’ user={username}

                After that, it parses it and adds all the ip adresses that a certain user used to enter the site. It also keeps the count
                of how many times a certain ip adress was used.

                Finally the program prints the results for every user.
             */

            string input = Console.ReadLine();
            SortedDictionary<string, Dictionary<string, int>> users = new SortedDictionary<string, Dictionary<string, int>>();

            while (input != "end")
            {
                string[] tokens = input.Split(' ')
                    .Select(a => a.Trim())
                    .ToArray();

                string[] ipTokens = tokens[0].Split('=');
                string[] userTokens = tokens[2].Split('=');

                string ipAdress = ipTokens[1];
                string username = userTokens[1];

                if (!users.ContainsKey(username))
                {
                    users[username] = new Dictionary<string, int>();
                    users[username].Add(ipAdress, 1);
                }
                else
                {
                    if (!users[username].ContainsKey(ipAdress))
                    {
                        users[username].Add(ipAdress, 1);
                    }
                    else
                    {
                        users[username][ipAdress]++;
                    }
                }       

                input = Console.ReadLine();
            }

            foreach (KeyValuePair<string, Dictionary<string, int>> user in users)
            {
                Console.WriteLine($"{user.Key}: ");

                Dictionary<string, int> currUserAdresses = user.Value;
                int count = currUserAdresses.Count - 1;

                foreach (var adress in currUserAdresses)
                {
                    if (count > 0)
                    {
                        Console.Write($"{adress.Key} => {adress.Value}, ");
                    }
                    else
                    {
                        Console.Write($"{adress.Key} => {adress.Value}.");
                    }

                    count--;
                }

                Console.WriteLine();
            }
        }
    }
}
