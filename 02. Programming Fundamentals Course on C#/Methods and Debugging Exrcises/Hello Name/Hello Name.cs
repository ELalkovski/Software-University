namespace Hello_Name
{
    using System;

    public class HelloName
    {
        public static void Main()
        {
            string name = Console.ReadLine();

            PrintName(name);
        }

        private static void PrintName(string name)
        {
            Console.WriteLine("Hello, {0}!", name);
        }
    }
}
