﻿namespace TriangleOf555Stars
{
    using System;

    public class TriangleOfStars
    {
        public static void Main()
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write('*');
                }

                Console.WriteLine();
            }
        }
    }
}
