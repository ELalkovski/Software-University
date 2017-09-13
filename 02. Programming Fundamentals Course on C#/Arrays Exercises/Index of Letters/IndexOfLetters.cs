namespace Index_of_Letters
{
    using System;
    using System.Linq;

    public class IndexOfLetters
    {
        public static void Main()
        {
            string inputWord = Console.ReadLine();

            char [] arrayAplhabet = "abcdefghijklmnopqrstuvwxyz".ToArray();

            PrintInputLettersNumber(inputWord, arrayAplhabet);
        }

        public static void PrintInputLettersNumber(string inputWord, char[] arrayAplhabet)
        {
            for (int inputWordCurrLet = 0; inputWordCurrLet < inputWord.Length; inputWordCurrLet++)
            {
                for (int aplhabetCurrLet = 0; aplhabetCurrLet < arrayAplhabet.Length; aplhabetCurrLet++)
                {
                    if (inputWord[inputWordCurrLet] == arrayAplhabet[aplhabetCurrLet])
                    {
                        Console.WriteLine("{0} -> {1}", inputWord[inputWordCurrLet], aplhabetCurrLet);
                    }
                }
            }
        }
    }
}
