using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace _2.Index_of_Letters
{
    class Program
    {
        public static void Main()
        {
            var alphabet = "abcdefghijklmnopqrstuvwxyz";

            var inputs = File.ReadAllLines("Inputs.txt");
            var firstInput = inputs[0];
            var secondInput = inputs[1];
            var output = new List<string>();

            for (int i = 0; i < firstInput.Length; i++)
            {
                for (int j = 0; j < alphabet.Length; j++)
                {
                    if (alphabet[j] == firstInput[i])
                    {
                        Console.WriteLine("{0} -> {1}", firstInput[i], j);
                    }
                }
            }

            Console.WriteLine();

            for (int i = 0; i < secondInput.Length; i++)
            {
                for (int j = 0; j < alphabet.Length; j++)
                {
                    if (alphabet[j] == secondInput[i])
                    {
                        Console.WriteLine("{0} -> {1}", secondInput[i], j);
                    }
                }
            }





        }
    }
}
