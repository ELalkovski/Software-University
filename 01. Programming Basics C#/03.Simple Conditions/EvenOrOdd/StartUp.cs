namespace EvenOrOdd
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            double number = double.Parse(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }  
        }
    }
}
