using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Split_by_Word_Casing
{
    class Program
    {
        public static List<string> GetLowerCaseList (char [] separators, List<string> textInput)
        {
            var lowerCaseWords = new List<string>();
            var lowerCases = 0;
            var upperCases = 0;

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

        public static List<string> GetUpperCaseList(char[] separators, List<string> textInput)
        {
            var upperCaseWords = new List<string>();
            var lowerCases = 0;
            var upperCases = 0;

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

        public static List<string> GetMixedCaseList(char[] separators, List<string> textInput)
        {
            var mixedCaseWords = new List<string>();
            var lowerCases = 0;
            var upperCases = 0;

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

        static void Main(string[] args)
        {
            char[] separators = { ' ', ',', ';', ':', '.', '!', '(', ')', '"', '\'', '/', '\\', '[', ']' };

            var textInput = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries).ToList();

            Console.WriteLine("Lower-case: " + string.Join(", ", GetLowerCaseList(separators, textInput)));
            Console.WriteLine("Mixed-case: " + string.Join(", ", GetMixedCaseList(separators, textInput)));
            Console.WriteLine("Upper-case: " + string.Join(", ", GetUpperCaseList(separators,textInput)));
        }
    }
}
