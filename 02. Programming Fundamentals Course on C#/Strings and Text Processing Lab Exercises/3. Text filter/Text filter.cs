using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3.Text_filter
{
    public class TextFilter
    {
        public static void Main()
        {
            var separators = new char[] { ',', ' ' };
            var banWords = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries);
            var inputText = Console.ReadLine();

            foreach (var banWord in banWords)
            {
                if (inputText.Contains(banWord))
                {
                    inputText = inputText.Replace(banWord, new string('*', banWord.Length));
                }
            }

            Console.WriteLine(inputText);
        }
    }
}
