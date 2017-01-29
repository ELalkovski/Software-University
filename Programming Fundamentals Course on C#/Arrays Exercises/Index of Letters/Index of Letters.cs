using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Index_of_Letters
{
    class Program
    {
        public static void PrintInputLettersNumber (string inputWord, char [] arrayAplhabet)
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

        static void Main(string[] args)
        {
            string inputWord = Console.ReadLine();

            char [] arrayAplhabet = "abcdefghijklmnopqrstuvwxyz".ToArray();

            PrintInputLettersNumber(inputWord, arrayAplhabet);


        }
    }
}
