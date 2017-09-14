namespace Reverse_an_Array_of_Integers
{
    using System;

    public class ReverseArrayOfIntegers
    {
        public static void Main()
        {
            int numbersCount = int.Parse(Console.ReadLine());

            int[] array = new int[numbersCount];

            for (int i = 0; i < numbersCount; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            for (int i = array.Length - 1; i >= 0; i--)
            {
                Console.Write("{0} ",array[i]);
            }

            Console.WriteLine();
        }
    }
}
