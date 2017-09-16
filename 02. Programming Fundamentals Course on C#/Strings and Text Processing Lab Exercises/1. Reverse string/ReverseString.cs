namespace _1.Reverse_string
{
    using System;

    public class ReverseString
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            string[] reversedString = new string[input.Length];
            int indexReversed = 0;

            for (int i = input.Length - 1; i >= 0; i--)
            {
                reversedString[indexReversed] = input[i].ToString();

                Console.Write(reversedString[indexReversed]);
                indexReversed++;
            }

            Console.WriteLine();
        }
    }
}
