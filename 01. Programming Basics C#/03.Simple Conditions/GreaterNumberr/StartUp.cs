namespace GreaterNumberr
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            Console.WriteLine("Enter two integers:");
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            if (firstNumber > secondNumber)
            {
                Console.WriteLine("Greater Number: " + firstNumber);
            }
            else
            {
                Console.WriteLine("Greater Number: " + secondNumber);
            }
        }
    }
}
