using System.Collections.Generic;

namespace _04.Count_Symbols
{
    using System;

    public class CountSymbols
    {
        public static void Main()
        {
            /*
             This program reads some text from the console and counts the occurrences of each character in it. 
             Prints the results in alphabetical (lexicographical) order. 
             */

            var inputText = Console.ReadLine();
            var symbolOccurences = new SortedDictionary<char, int>();

            for (int i = 0; i < inputText.Length; i++)
            {
                if (!symbolOccurences.ContainsKey(inputText[i]))
                {
                    symbolOccurences.Add(inputText[i], 1);
                }
                else
                {
                    symbolOccurences[inputText[i]]++;
                }
            }

            foreach (var occurence in symbolOccurences)
            {
                Console.WriteLine($"{occurence.Key}: {occurence.Value} time/s");
            }
        }
    }
}
