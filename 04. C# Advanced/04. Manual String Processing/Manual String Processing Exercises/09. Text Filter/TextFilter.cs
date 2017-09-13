using System;
using System.Linq;

namespace _09.Text_Filter
{
    public class TextFilter
    {
        public static void Main()
        {
            var banWords = Console.ReadLine()
                .Split(new []{' ', ','}, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            var text = Console.ReadLine();

            for (int i = 0; i < banWords.Length; i++)
            {
                var currWord = banWords[i];

                var replaceString = new string('*', currWord.Length);
                text = text.Replace(currWord, replaceString);
            }
            Console.WriteLine(text);
        }
    }
}
