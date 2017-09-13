namespace VowelsSum
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            int sum = 0;

            for (int userLetter = 0; userLetter < input.Length; userLetter++)
            {
                if (input[userLetter] == 'a')
                {
                    sum += 1;
                }
                else if (input[userLetter] == 'e')
                {
                    sum += 2;
                }
                else if (input[userLetter] == 'i')
                {
                    sum += 3;
                }
                else if (input[userLetter] == 'o')
                {
                    sum += 4;
                }
                else if (input[userLetter] == 'u')
                {
                    sum += 5;
                }
            }

            Console.WriteLine("Vowels sum = " + sum);
        }
    }
}
