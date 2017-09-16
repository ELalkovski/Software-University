using System;

namespace _13.TriFunction
{
    public class TriFunction
    {
        public static void Main()
        {
            var boundryLength = int.Parse(Console.ReadLine());
            var words = Console.ReadLine().Split(' ');

            Func<int, int, bool> isResult = (sum, boundry) => { return sum >= boundry; };

            Console.WriteLine(FindResult(boundryLength, words, isResult));    

        }

        private static string FindResult(int boundryLength, string[] words, Func<int, int, bool> isResult)
        {
            for (int i = 0; i < words.Length; i++)
            {
                var currWord = words[i];
                var sumOfChars = 0;

                foreach (char letter in currWord)
                {
                    sumOfChars += letter;
                }

                if (isResult(sumOfChars, boundryLength))
                {
                    return currWord;
                }
            }
            return "";
        }
    }
}
