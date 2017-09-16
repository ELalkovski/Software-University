namespace _2.Odd_Occurrences
{
    using System;
    using System.Collections.Generic;

    public class OddOccurrences
    {
        public static void Main()
        {
            string[] input = Console.ReadLine()
                .ToLower()
                .Split(' ');

            Dictionary<string, int> words = new Dictionary<string, int>();

            foreach (var word in input)
            {
                if (!words.ContainsKey(word))
                {
                    words[word] = 0;
                }

                words[word]++;
            }

            List<string> oddWords = new List<string>();

            foreach (var word in words.Keys)
            {
                if (words[word] % 2 != 0)
                {
                    oddWords.Add(word);
                }
            }

            Console.WriteLine(string.Join(", ",oddWords));
        }
    }
}
