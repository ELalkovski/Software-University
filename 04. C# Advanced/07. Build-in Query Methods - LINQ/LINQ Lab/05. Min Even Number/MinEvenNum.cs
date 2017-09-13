using System;
using System.Linq;

namespace _05.Min_Even_Number
{
    public class MinEvenNum
    {
        public static void Main()
        {
            try
            {
                Console.WriteLine("{0:f2}",
                                Console.ReadLine()
                                .Split(new []{' '}, StringSplitOptions.RemoveEmptyEntries)
                                .Select(double.Parse)
                                .ToList()
                                .FindAll(n => n % 2 == 0)
                                .Min());
            }
            catch (Exception)
            {
                Console.WriteLine("No match");
            }
            
        }
    }
}
