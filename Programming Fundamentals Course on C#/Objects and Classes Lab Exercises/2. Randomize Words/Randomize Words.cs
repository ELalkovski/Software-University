using System;
using System.Collections.Generic;
using System.Linq;

namespace _2.Randomize_Words
{
    class Program
    {
        public static void Main()
        {
            var words = Console.ReadLine().Split(' ');
            var random = new Random();

            for (int i = 0; i < words.Length; i++)
            {
                var currWord = words[i];
                var randomIndex = random.Next(0, words.Length);
                var tempWord = words[randomIndex];
                words[i] = tempWord;
                words[randomIndex] = currWord;
            }

            Console.WriteLine(string.Join("\r\n", words));
        }
    }
}
