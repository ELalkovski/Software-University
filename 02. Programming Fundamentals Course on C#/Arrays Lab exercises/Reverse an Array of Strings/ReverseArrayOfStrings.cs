namespace Reverse_an_Array_of_Strings
{
    using System;

    public class ReverseArrayOfStrings
    {
        public static void Main()
        {
            string[] array = Console.ReadLine()
                .Split(' ');

            for (int i = array.Length - 1; i >= 0; i--)
            {
                Console.Write("{0} ",array[i]);
            }

            Console.WriteLine();
        }
    }
}
