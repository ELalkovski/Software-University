namespace _04.Special_Words
{
    using System;
    using System.Collections.Generic;

    public class SpecialWords
    {
        public static void Main()
        {
            char[] separators = new[] {'(', ')', '[', ']', '<', '>', ',', '-', '!', '?', ' '};
            string[] inputWords = Console.ReadLine()
                .Split(separators, StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> wordsCount = new Dictionary<string, int>();

            for (int i = 0; i < inputWords.Length; i++)
            {
                wordsCount.Add(inputWords[i], 0);
            }

            string[] text = Console.ReadLine()
                .Split(separators, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < text.Length; i++)
            {
                if (wordsCount.ContainsKey(text[i]))
                {
                    wordsCount[text[i]]++;
                }
            }

            foreach (var word in wordsCount)
            {
                Console.WriteLine($"{word.Key} - {word.Value}");
            }
        }
    }
}
