namespace _4.Split_by_Word_Casing
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SplitWordByCasing
    {
        public static void Main()
        {
            char[] separators = { ' ', ',', ';', ':', '.', '!', '(', ')', '"', '\'', '/', '\\', '[', ']' };

            List<string> textInput = Console.ReadLine()
                .Split(separators, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            Console.WriteLine("Lower-case: " + string.Join(", ", GetLowerCaseList(separators, textInput)));
            Console.WriteLine("Mixed-case: " + string.Join(", ", GetMixedCaseList(separators, textInput)));
            Console.WriteLine("Upper-case: " + string.Join(", ", GetUpperCaseList(separators,textInput)));
        }

        private static List<string> GetLowerCaseList(char[] separators, List<string> textInput)
        {
            List<string> lowerCaseWords = new List<string>();
            int lowerCases = 0;
            int upperCases = 0;

            foreach (var word in textInput)
            {
                lowerCases = 0;
                upperCases = 0;

                foreach (char letter in word)
                {
                    if (char.IsLower(letter))
                    {
                        lowerCases++;
                    }
                    else if (char.IsUpper(letter))
                    {
                        upperCases++;
                    }
                }

                if (lowerCases == word.Length)
                {
                    lowerCaseWords.Add(word);
                }
            }

            return lowerCaseWords;
        }

        private static List<string> GetUpperCaseList(char[] separators, List<string> textInput)
        {
            List<string> upperCaseWords = new List<string>();
            int lowerCases = 0;
            int upperCases = 0;

            foreach (var word in textInput)
            {
                lowerCases = 0;
                upperCases = 0;

                foreach (char letter in word)
                {
                    if (char.IsLower(letter))
                    {
                        lowerCases++;
                    }
                    else if (char.IsUpper(letter))
                    {
                        upperCases++;
                    }
                }

                if (upperCases == word.Length)
                {
                    upperCaseWords.Add(word);
                }
            }

            return upperCaseWords;
        }

        private static List<string> GetMixedCaseList(char[] separators, List<string> textInput)
        {
            List<string> mixedCaseWords = new List<string>();
            int lowerCases = 0;
            int upperCases = 0;

            foreach (var word in textInput)
            {
                lowerCases = 0;
                upperCases = 0;

                foreach (char letter in word)
                {
                    if (char.IsLower(letter))
                    {
                        lowerCases++;
                    }
                    else if (char.IsUpper(letter))
                    {
                        upperCases++;
                    }
                }

                if (upperCases != word.Length && lowerCases != word.Length)
                {
                    mixedCaseWords.Add(word);
                }
            }

            return mixedCaseWords;
        }
    }
}
