using System;
using System.Collections.Generic;
using System.Linq;

namespace _4.Distance_Between_Points
{

    class Program
    {
        public static double CalculateDistance(Point p1, Point p2)
        {
            var sideA = p1.x - p2.x;
            var sideB = p1.y - p2.y;
            var distance = Math.Sqrt(Math.Pow(sideA, 2) + Math.Pow(sideB, 2));
            return distance;
        }

        public static void Main()
        {
            var firstPair = Console.ReadLine().Split(' ');
            var secondPair = Console.ReadLine().Split(' ');

            Point p1 = new Point()
            {
                x = double.Parse(firstPair[0]),
                y = double.Parse(firstPair[1])
            };

            Point p2 = new Point()
            {
                x = double.Parse(secondPair[0]),
                y = double.Parse(secondPair[1])
            };

            Console.WriteLine("{0:f3}",CalculateDistance(p1, p2));
        }
    }
}
