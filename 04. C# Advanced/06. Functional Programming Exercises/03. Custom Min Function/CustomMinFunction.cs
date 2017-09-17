namespace _03.Custom_Min_Function
{
    using System;
    using System.Linq;

    public class CustomMinFunction
    {
        public static void Main()
        {
            Console.WriteLine(Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray()
                .OrderBy(n => n)
                .First(n => n < n));
        }
    }
}
