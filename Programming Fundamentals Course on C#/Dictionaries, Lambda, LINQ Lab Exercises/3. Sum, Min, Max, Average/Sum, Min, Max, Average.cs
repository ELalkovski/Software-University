


namespace _3.Sum__Min__Max__Average
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class SumMinMaxAv
    {
        public static void PrintResults (int n)
        {
            var inputNums = new List<int>();

            for (int i = 0; i < n; i++)
            {
                var currNum = int.Parse(Console.ReadLine());
                inputNums.Add(currNum);
            }

            Console.WriteLine("Sum = {0}", inputNums.Sum());
            Console.WriteLine("Min = {0}", inputNums.Min());
            Console.WriteLine("Max = {0}", inputNums.Max());
            Console.WriteLine("Average = {0}", inputNums.Average());
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintResults(n);


        }
    }
}
