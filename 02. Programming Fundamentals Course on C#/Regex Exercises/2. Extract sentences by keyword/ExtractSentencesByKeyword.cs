namespace _2.Extract_sentences_by_keyword
{
    using System;
    using System.Text.RegularExpressions;

    public class ExtractSentences
    {
        public static void Main()
        {
            string word = Console.ReadLine();
            char[] separators = new [] { '!', '.', '?' };
            string[] text = Console.ReadLine().Split(separators);
            Regex regex = new Regex($"\\b[{word}]+\\b");

            for (int i = 0; i < text.Length; i++)
            {
                bool isMatch = regex.IsMatch(text[i]);

                if (isMatch)
                {
                    Console.WriteLine(text[i]);
                }
            }
        }
    }
}
