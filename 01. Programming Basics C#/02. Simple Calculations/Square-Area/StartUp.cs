namespace Square_Area
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());
            int area = a * a;

            Console.Write("Square = ");
            Console.WriteLine(area);
        }
    }
}
