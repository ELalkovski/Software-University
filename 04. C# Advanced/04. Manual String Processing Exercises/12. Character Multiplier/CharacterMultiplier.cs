namespace _12.Character_Multiplier
{
    using System;
    using System.Linq;

    public class CharacterMultiplier
    {
        public static void Main()
        {
            string[] inputWords = Console.ReadLine()
                .Split(' ');

            string firstWord = inputWords[0];
            string secondWord = inputWords[1];

            Console.WriteLine(MultiplyChars(firstWord, secondWord));
        }

        private static int MultiplyChars(string firstWord, string secondWord)
        {
            int sum = 0;
            int longestLength = Math.Max(firstWord.Length, secondWord.Length);

            for (int i = 0; i < longestLength; i++)
            {
                int currSum = 0;

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
