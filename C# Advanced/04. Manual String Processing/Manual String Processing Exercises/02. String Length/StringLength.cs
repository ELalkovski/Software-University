using System;

namespace _02.String_Length
{
    public class StringLength
    {
        public static void Main()
        {
            var input = Console.ReadLine();

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
