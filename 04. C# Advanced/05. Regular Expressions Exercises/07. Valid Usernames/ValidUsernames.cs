namespace _07.Valid_Usernames
{
    using System;
    using System.Text.RegularExpressions;

    public class ValidUsernames
    {
        public static void Main()
        {
            string[] inputUsernames = Console.ReadLine()
                .Split(new[] { '(', ')', '/', '\\', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            Regex regex = new Regex(@"\b[a-zA-Z][a-zA-Z0-9_]{2,24}\b");
            int bestSum = 0;
            int sum = 0;
            string firstBestName = "";
            string secondBestName = "";

            for (int i = 0; i < inputUsernames.Length - 1; i++)
            {
                string currUsername = inputUsernames[i];

                if (regex.IsMatch(currUsername))
                {
                    for (int j = i + 1; j < inputUsernames.Length; j++)
                    {
                        string nextUsername = inputUsernames[j];

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