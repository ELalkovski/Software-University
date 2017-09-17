namespace _11.Palindromes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Palindromes
    {
        public static void Main()
        {
            string[] input = Console.ReadLine()
                .Split(new[] {' ', ',', '.', '!', '?'}, StringSplitOptions.RemoveEmptyEntries);

            List<string> palindromes = new List<string>();
            bool isPalindrome = false;

            for (int i = 0; i < input.Length; i++)
            {
                string currWord = input[i];
                int startCounter = 0;
                int endCounter = currWord.Length - 1;

                for (int j = 0; j < currWord.Length / 2; j++)
                {
                    if (currWord[startCounter] == currWord[endCounter])
                    {
                        isPalindrome = true;
                        startCounter++;
                        endCounter--;
                    }
                    else
                    {
                        isPalindrome = false;

                        break;
                    }
                }
                if (isPalindrome || currWord.Length == 1)
                {
                    palindromes.Add(currWord);
                }

                isPalindrome = false;
            }

            Console.WriteLine("[{0}]", string.Join(", ", palindromes.Distinct().OrderBy(w => w)));
        }
    }
}
