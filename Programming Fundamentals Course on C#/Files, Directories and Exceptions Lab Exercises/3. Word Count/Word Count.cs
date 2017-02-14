using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace _3.Word_Count
{
    class Program
    {
        public static void Main()
        {
            var inputFile = "input.txt";
            var text = File.ReadAllText(inputFile)
                .ToLower()
                .Split(new char []{ '\n','\r',' ', '.', ',', '!', '?', '-'}, StringSplitOptions.RemoveEmptyEntries);

            var wordsFile = "words.txt";
            var words = File.ReadAllText(wordsFile)
                .ToLower()
                .Split(' ');

            var wordsCount = new Dictionary<string, int>();

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
