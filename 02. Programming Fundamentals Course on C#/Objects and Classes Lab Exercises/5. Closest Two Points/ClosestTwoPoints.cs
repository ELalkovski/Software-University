namespace _5.Closest_Two_Points
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ClosestTwoPoints
    {
        public static void Main()
        {
            int linesCount = int.Parse(Console.ReadLine());
            List<Point> points = new List<Point>();

            for (int i = 0; i < linesCount; i++)
            {
                double[] currPointParts = Console.ReadLine()
                    .Split(' ')
                    .Select(double.Parse)
                    .ToArray();

                points.Add(new Point
                {
                    X = currPointParts[0],
                    Y = currPointParts[1]
                });
            }

            double currMinDistance = double.MaxValue;
            Point firstPointMin = null;
            Point secondPointMin = null;

            for (int i = 0; i < points.Count - 1; i++)
            {
                for (int j = i + 1; j < points.Count; j++)
                {
                    Point firstPoint = points[i];
                    Point secondPoint = points[j];

                    double currDistance = CalculateDistance(firstPoint, secondPoint);

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

        private static double CalculateDistance(Point firstPoint, Point secondPoint)
        {
            double sideA = firstPoint.X - secondPoint.X;
            double sideB = firstPoint.Y - secondPoint.Y;
            double distance = Math.Sqrt(Math.Pow(sideA, 2) + Math.Pow(sideB, 2));

            return distance;
        }
    }
}
