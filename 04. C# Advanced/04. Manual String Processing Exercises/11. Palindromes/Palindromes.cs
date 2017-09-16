using System;
using System.Collections.Generic;
using System.Linq;

namespace _11.Palindromes
{
    public class Palindromes
    {
        public static void Main()
        {
            var input = Console.ReadLine()
                .Split(new[] { ' ', ',', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            var palindromes = new List<string>();
            bool isPalindrome = false;

            for (int i = 0; i < input.Length; i++)
            {
                var currWord = input[i];
                var startCounter = 0;
                var endCounter = currWord.Length - 1;

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
