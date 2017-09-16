namespace _2.Index_of_Letters
{
    using System;
    using System.IO;

    public class IndexOfLetters
    {
        public static void Main()
        {
            string alphabet = "abcdefghijklmnopqrstuvwxyz";

            string[] inputs = File.ReadAllLines("Inputs.txt");
            string firstInput = inputs[0];
            string secondInput = inputs[1];

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
