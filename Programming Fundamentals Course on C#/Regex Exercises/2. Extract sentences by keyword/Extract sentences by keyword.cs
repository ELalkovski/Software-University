using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _2.Extract_sentences_by_keyword
{
    public class ExtractSentences
    {
        public static void Main()
        {
            var word = Console.ReadLine();
            var separators = new char[] { '!', '.', '?' };
            var text = Console.ReadLine().Split(separators);
            var regex = new Regex($"\\b[{word}]+\\b");

            for (int i = 0; i < text.Length; i++)
            {
                var match = regex.IsMatch(text[i]);

                if (match)
                {
                    Console.WriteLine(text[i]);
                }
            }
           
        }
    }
}
