namespace _01.Unique_Usernames
{
    using System;
    using System.Collections.Generic;

    public class UniqueUsernames
    {
        public static void Main()
        {
            /*
             On the first recieves integer N. On the next N lines receives one username per line. 
             This program readss from the console a sequence of N usernames and keeps a collection only of the unique ones.
             Prints the collection on the console in order of insertion:
             */

            var n = int.Parse(Console.ReadLine());
            var hashSet = new HashSet<string>();

            for (int i = 0; i < n; i++)
            {
                var username = Console.ReadLine();

                hashSet.Add(username);
            }

            foreach (var username in hashSet)
            {
                Console.WriteLine(username);
            }
        }
    }
}
