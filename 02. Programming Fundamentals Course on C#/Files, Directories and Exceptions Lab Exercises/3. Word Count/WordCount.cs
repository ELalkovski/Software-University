namespace _3.Word_Count
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class WordCount
    {
        public static void Main()
        {
            string inputFile = "input.txt";
            string[] text = File.ReadAllText(inputFile)
                .ToLower()
                .Split(new char []{ '\n','\r',' ', '.', ',', '!', '?', '-'}, StringSplitOptions.RemoveEmptyEntries);

            string wordsFile = "words.txt";
            string[] words = File.ReadAllText(wordsFile)
                .ToLower()
                .Split(' ');

            Dictionary<string, int> wordsCount = new Dictionary<string, int>();

            foreach (var word in words)
            {
                wordsCount[word] = 0;
            }

            foreach (var word in text)
            {
                if (wordsCount.ContainsKey(word))
                {
                    wordsCount[word]++;
                }
            }

            foreach (var word in wordsCount.OrderByDescending(x => x.Value))
            {
                File.AppendAllText("output.txt", $" {word.Key} - {word.Value}" + Environment.NewLine);
            }
        }
    }
}
