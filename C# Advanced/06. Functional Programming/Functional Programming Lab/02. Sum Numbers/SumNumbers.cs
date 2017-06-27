﻿using System;
using System.Linq;

namespace _02.Sum_Numbers
{
    public class SumNumbers
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(new []{", "}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Console.WriteLine(numbers.Length);
            Console.WriteLine(numbers.Sum());
        }
    }
}
