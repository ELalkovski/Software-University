namespace _4.Distance_Between_Points
{
    using System;

    public class DistanceBetweenPoints
    {
        public static void Main()
        {
            string[] firstPair = Console.ReadLine().Split(' ');
            string[] secondPair = Console.ReadLine().Split(' ');

            Point p1 = new Point()
            {
                X = double.Parse(firstPair[0]),
                Y = double.Parse(firstPair[1])
            };

            Point p2 = new Point()
            {
                X = double.Parse(secondPair[0]),
                Y = double.Parse(secondPair[1])
            };

            Console.WriteLine("{0:f3}",CalculateDistance(p1, p2));
        }

        private static double CalculateDistance(Point p1, Point p2)
        {
            double sideA = p1.X - p2.X;
            double sideB = p1.Y - p2.Y;
            double distance = Math.Sqrt(Math.Pow(sideA, 2) + Math.Pow(sideB, 2));

            return distance;
        }
    }
}
