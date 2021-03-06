﻿namespace _3.Intersection_of_Circles
{
    using System;
    using System.Linq;
    
    public class IntersectionOfCircles
    {
        public static void Main()
        {
            int[] firstData = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int[] secondData = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            Circle c1 = new Circle()
            {
                Center = new Point()
                {
                    X = firstData[0],
                    Y = firstData[1]
                },

                Radius = firstData[2]
            };

            Circle c2 = new Circle()
            {
                Center = new Point()
                {
                    X = secondData[0],
                    Y = secondData[1]
                },

                Radius = secondData[2]
            };

            int distance = Point.CalculateDistance(c1.Center, c2.Center);

            if (distance <= (c1.Radius + c2.Radius))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
