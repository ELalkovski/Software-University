namespace Numbers_in_Reversed_Order
{
    using System;

    public class NumsInRevOrder
    {
        public static void Main()
        {
            string number = Console.ReadLine();

            ReverseNumbers(number);
        }

        private static void ReverseNumbers(string number)
        {
            for (int i = number.Length - 1; i >= 0; i--)
            {
                Console.Write(number[i]);
            }

            Console.WriteLine();
        }
    }
}
