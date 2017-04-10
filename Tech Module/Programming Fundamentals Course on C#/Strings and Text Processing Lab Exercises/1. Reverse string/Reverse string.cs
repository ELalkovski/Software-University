namespace _1.Reverse_string
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class ReverseString
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            var reversedString = new string[input.Length];
            var indexReversed = 0;

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
