namespace NumberInRange_1_to_100_
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            Console.Write("Enter a number in range [1...100]: ");
            int number = int.Parse(Console.ReadLine());

            while (number < 1 || number > 100)
            {
                Console.WriteLine("Invalid number!");
                number = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("The number is: {0}", number);
        }
    }
}
