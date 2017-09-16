using System;
using System.Linq;

namespace _12.Character_Multiplier
{
    public class CharacterMultiplier
    {
        public static void Main()
        {
            var inputWords = Console.ReadLine()
                .Split(' ')
                .ToArray();

            var firstWord = inputWords[0];
            var secondWord = inputWords[1];

            Console.WriteLine(MultiplyChars(firstWord, secondWord));
        }

        private static int MultiplyChars(string firstWord, string secondWord)
        {
            var sum = 0;
            var longestLength = Math.Max(firstWord.Length, secondWord.Length);

            for (int i = 0; i < longestLength; i++)
            {
                var currSum = 0;
                if (i < firstWord.Length && i < secondWord.Length)
                {
                    currSum = (int)(firstWord[i]) * (int)(secondWord[i]);
                }
                else
                {
                    if (i < firstWord.Length)
                    {
                        currSum = (int)(firstWord[i]);
                    }
                    else
                    {
                        currSum = (int)(secondWord[i]);
                    }
                }
                sum += currSum;
            }

            return sum;
        }
    }
}
