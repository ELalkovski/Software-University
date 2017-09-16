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

            var input = Console.ReadLine();
            var users = new SortedDictionary<string, Dictionary<string, int>>();
            

            while (input != "end")
            {
                var tokens = input.Split(' ')
                    .Select(a => a.Trim())
                    .ToArray();

                var ipTokens = tokens[0].Split('=');
                var userTokens = tokens[2].Split('=');

                var ipAdress = ipTokens[1];
                var username = userTokens[1];

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
                var count = currUserAdresses.Count - 1;

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
