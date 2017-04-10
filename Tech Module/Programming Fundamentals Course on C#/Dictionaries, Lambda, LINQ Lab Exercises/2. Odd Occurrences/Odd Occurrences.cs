using System;
using System.Collections.Generic;
using System.Linq;

namespace _2.Odd_Occurrences
{


    class OddOccurrences
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().ToLower().Split(' ');

            var words = new Dictionary<string, int>();

            foreach (var word in input)
            {
                if (!words.ContainsKey(word))
                {
                    words[word] = 0;
                }

                words[word]++;
            }

            var oddWords = new List<string>();

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
