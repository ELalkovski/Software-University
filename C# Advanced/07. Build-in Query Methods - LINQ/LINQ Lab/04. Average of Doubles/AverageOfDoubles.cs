using System;
using System.Linq;

namespace _04.Average_of_Doubles
{
    public class AverageOfDoubles
    {
        public static void Main()
        {
            Console.WriteLine("{0:f2}", Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToList()
                .Average());
        }
    }
}
