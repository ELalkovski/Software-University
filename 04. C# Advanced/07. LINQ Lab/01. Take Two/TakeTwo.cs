using System;
using System.Linq;

namespace _1.Take_Two
{
    public class TakeTwo
    {
        public static void Main()
        {

            Console.WriteLine(string.Join(" ", Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList()
                .FindAll(n => n >= 10 && n <= 20)
                .Distinct()
                .Take(2)));


        }
    }
}
