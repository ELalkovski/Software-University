using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5.Magic_exchangeable_words
{
    public class MagicWords
    {
        public static void PrintIsExchangeble(string [] input)
        {
            HashSet<char> firstWord = new HashSet<char>(input[0]);
            HashSet<char> secondWord = new HashSet<char>(input[1]);
            Console.WriteLine((firstWord.Count == secondWord.Count) ? "true" : "false");
        }

        public static void Main()
        {
            var input = Console.ReadLine().Split(' ');
            PrintIsExchangeble(input);
        }
    }
}
