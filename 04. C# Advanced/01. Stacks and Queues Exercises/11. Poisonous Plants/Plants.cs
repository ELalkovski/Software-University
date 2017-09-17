namespace _11.Poisonous_Plants
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Plants
    {
        public static void Main()
        {
            int plantsQuantity = int.Parse(Console.ReadLine());
            int[] plants = Console.ReadLine()
                .Trim()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int[] days = new int[plantsQuantity];
            Stack<int> plantsIndices = new Stack<int>();

            plantsIndices.Push(0);

            for (int i = 1; i < plants.Length; i++)
            {
                int maxDays = 0;

                while (plantsIndices.Count > 0 && plants[plantsIndices.Peek()] >= plants[i])
                {
                    maxDays = Math.Max(maxDays, days[plantsIndices.Pop()]);
                }

                if (plantsIndices.Count > 0)
                {
                    days[i] = maxDays + 1;
                }

                plantsIndices.Push(i);
            }

            Console.WriteLine(days.Max());
        }
    }
}
