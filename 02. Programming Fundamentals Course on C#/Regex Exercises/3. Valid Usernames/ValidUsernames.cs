namespace _3.Valid_Usernames
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    public class ValidUsernames
    {
        public static void Main()
        {
            string[] input = Console.ReadLine()
                .Split(new[] { ' ', '/', '\\', '(', ')'},StringSplitOptions.RemoveEmptyEntries);

            Regex regex = new Regex(@"\b[a-zA-z][a-zA-Z0-9_]{2,24}\b");
            List<string> validatedUsernames = new List<string>();

            foreach (var username in input)
            {
                if (regex.IsMatch(username))
                {
                    validatedUsernames.Add(username);
                }
            }

            int currSum = 0;
            int bestSum = 0;
            string firstUser = string.Empty;
            string secondUser = string.Empty;

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
