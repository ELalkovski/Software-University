namespace _4.Palindromes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Palindromes
    {
        public static void Main()
        {
            char[] separators = new [] { ',', '?', ' ', '!', '.' };
            string[] inputWords = Console.ReadLine()
                .Split(separators, StringSplitOptions.RemoveEmptyEntries);
            List<string> paliWords = new List<string>();

            foreach (var word in inputWords)
            {
                if (IsPalindrome(word))
                {
                    paliWords.Add(word);
                }
            }

            Console.WriteLine(string.Join(", ", paliWords.Distinct().OrderBy(x => x)));
        }

        private static bool IsPalindrome(string word)
        {
            string first = word.Substring(0, word.Length / 2);
            char[] arr = word.ToCharArray();
            Array.Reverse(arr);
            string temp = new string(arr);
            string second = temp.Substring(0, temp.Length / 2);

            return first.Equals(second);
        }
    }
}
