using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _3.Valid_Usernames
{
    public class ValidUsernames
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(new[] { ' ', '/', '\\', '(', ')'},StringSplitOptions.RemoveEmptyEntries);

            var regex = new Regex(@"\b[a-zA-z][a-zA-Z0-9_]{2,24}\b");
            var validatedUsernames = new List<string>();

            foreach (var username in input)
            {
                if (regex.IsMatch(username))
                {
                    validatedUsernames.Add(username);
                }
            }

            var currSum = 0;
            var bestSum = 0;
            var firstUser = string.Empty;
            var secondUser = string.Empty;

            for (int i = 0; i < validatedUsernames.Count - 1; i++)
            {
                currSum = validatedUsernames[i].Length + validatedUsernames[i + 1].Length;

                if (currSum > bestSum)
                {
                    bestSum = currSum;
                    firstUser = validatedUsernames[i];
                    secondUser = validatedUsernames[i + 1];
                }
            }

            Console.WriteLine(firstUser);
            Console.WriteLine(secondUser);
        }
    }
}
