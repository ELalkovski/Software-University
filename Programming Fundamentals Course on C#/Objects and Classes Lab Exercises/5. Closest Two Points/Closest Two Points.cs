

namespace _5.Closest_Two_Points
{
    using System;
    using System.Collections.Generic;
    using System.Linq;


    class Program
    {
        public static double CalculateDistance(Point firstPoint, Point secondPoint)
        {
            var sideA = firstPoint.X - secondPoint.X;
            var sideB = firstPoint.Y - secondPoint.Y;
            var distance = Math.Sqrt(Math.Pow(sideA, 2) + Math.Pow(sideB, 2));
            return distance;
        }

        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var points = new List<Point>();

            for (int i = 0; i < n; i++)
            {
                var currPointParts = Console.ReadLine()
                    .Split(' ')
                    .Select(double.Parse)
                    .ToArray();

                points.Add(new Point
                {
                    X = currPointParts[0],
                    Y = currPointParts[1]
                });
                   
            }

            var currMinDistance = double.MaxValue;
            Point firstPointMin = null;
            Point secondPointMin = null;

            for (int i = 0; i < points.Count - 1; i++)
            {
                for (int j = i + 1; j < points.Count; j++)
                {
                    var firstPoint = points[i];
                    var secondPoint = points[j];

                    var currDistance = CalculateDistance(firstPoint, secondPoint);

                    if (currDistance < currMinDistance)
                    {
                        currMinDistance = currDistance;
                        firstPointMin = firstPoint;
                        secondPointMin = secondPoint;
                    }
                }
            }

            Console.WriteLine("{0:f3}", currMinDistance);
            Console.WriteLine("({0}, {1})",firstPointMin.X, firstPointMin.Y);
            Console.WriteLine("({0}, {1})", secondPointMin.X, secondPointMin.Y);
        }
    }
}
