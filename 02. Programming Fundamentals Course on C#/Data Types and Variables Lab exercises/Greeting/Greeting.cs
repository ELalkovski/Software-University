namespace Greeting
{
    using System;

    public class Greeting
    {
        public static void Main()
        {
            string firstName = Console.ReadLine();
            string secondName = Console.ReadLine();
            string ageStr = Console.ReadLine();
            int age = int.Parse(ageStr);

            Console.WriteLine($"Hello, {firstName} {secondName}. You are {age} years old.");
        }
    }
}
