namespace Sign_of_Integer_Number
{
    using System;

    public class IntegerSign
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            PrintIntegerSign(number);
        }

        private static void PrintIntegerSign(int number)
        {
            if (number > 0)
            {
                Console.WriteLine("The number {0} is positive.", number);
            }
            else if (number < 0)
            {
                Console.WriteLine("The number {0} is negative.", number);
            }
            else
            {
                Console.WriteLine("The number {0} is zero.", number);
            }
        }
    }
}
