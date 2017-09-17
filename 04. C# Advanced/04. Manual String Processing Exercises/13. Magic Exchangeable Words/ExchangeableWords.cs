namespace _5.Magic_exchangeable_words
{
    using System;
    using System.Collections.Generic;

    public class MagicWords
    {
        public static void Main()
        {
            string[] input = Console.ReadLine()
                .Split(' ');

            PrintIsExchangeble(input);
        }

        private static void PrintIsExchangeble(string[] input)
        {
            HashSet<char> firstWord = new HashSet<char>(input[0]);
            HashSet<char> secondWord = new HashSet<char>(input[1]);
            Console.WriteLine((firstWord.Count == secondWord.Count) ? "true" : "false");
        }
    }
}