namespace _3.Unicode_Characters
{
    using System;
    using System.Collections.Generic;

    public class UnicodeCharacters
    {
        public static void Main()
        {
            string inputWord = Console.ReadLine();
            List<string> unicodes = new List<string>();

            for (int i = 0; i < inputWord.Length; i++)
            {
                unicodes.Add("\\u" + ((int)inputWord[i]).ToString("X4").ToLower());
            }

            Console.WriteLine(string.Join("",unicodes));
        }
    }
}
