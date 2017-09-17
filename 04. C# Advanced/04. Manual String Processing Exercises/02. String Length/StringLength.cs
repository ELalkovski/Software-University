namespace _02.String_Length
{
    using System;

    public class StringLength
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            if (input.Length < 20)
            {
                Console.WriteLine(input.PadRight(20, '*'));
            }
            else
            {
                for (int i = 0; i < 20; i++)
                {
                    Console.Write(input[i]);
                }

                Console.WriteLine();
            }
        }
    }
}
