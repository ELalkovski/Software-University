namespace _04.Average_of_Doubles
{
    using System;
    using System.Linq;

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
