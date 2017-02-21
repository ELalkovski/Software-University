using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3.Unicode_Characters
{
    public class Unicode
    {
        public static void Main()
        {
            string inputWord = Console.ReadLine();
            var unicodes = new List<string>();

            for (int i = 0; i < inputWord.Length; i++)
            {
                unicodes.Add("\\u" + ((int)inputWord[i]).ToString("X4").ToLower());
            }
            Console.WriteLine(string.Join("",unicodes));
        }
    }
}
