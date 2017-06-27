using System;
using System.Text.RegularExpressions;

namespace _07.Valid_Usernames
{
    public class ValidUsernames
    {
        public static void Main()
        {
            var inputUsernames = Console.ReadLine()
                .Split(new[] { '(', ')', '/', '\\', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var regex = new Regex(@"\b[a-zA-Z][a-zA-Z0-9_]{2,24}\b");

            var bestSum = 0;
            var sum = 0;
            var firstBestName = "";
            var secondBestName = "";

            for (int i = 0; i < inputUsernames.Length - 1; i++)
            {
                var currUsername = inputUsernames[i];

                if (regex.IsMatch(currUsername))
                {
                    for (int j = i + 1; j < inputUsernames.Length; j++)
                    {
                        var nextUsername = inputUsernames[j];

                        if (regex.IsMatch(nextUsername))
                        {
                            sum = currUsername.Length + nextUsername.Length;

                            if (sum > bestSum)
                            {
                                bestSum = sum;
                                firstBestName = currUsername;
                                secondBestName = nextUsername;
                            }

                            break;
                        }
                    }
                }
            }
            Console.WriteLine(firstBestName);
            Console.WriteLine(secondBestName);
        }
    }
}