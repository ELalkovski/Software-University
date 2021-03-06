﻿namespace _08.Custom_Comparator
{
    using System;
    using System.Linq;

    public class CustomComparator
    {
        public static void Main()
        {
            int[] inputNums = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            Array.Sort(inputNums, delegate(int i, int i1)
            {
                int a = (i1 % 2 == 0).CompareTo(i % 2 == 0);
                if (a == 0)
                {
                    return i.CompareTo(i1);
                }

                return a;
            });

            Console.WriteLine(string.Join(" ", inputNums));
        }
    }
}
