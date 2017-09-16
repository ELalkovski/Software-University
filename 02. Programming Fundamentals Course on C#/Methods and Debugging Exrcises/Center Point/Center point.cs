namespace Center_Point
{
    using System;

    public class CenterPoint
    {
        public static void Main()
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            PrintClosestPoint(x1, y1, x2, y2);
        }

        private static double FindDistance(double x, double y)
        {
            double distance = Math.Sqrt((x * x) + (y * y));

            return distance;
        }

        private static void PrintClosestPoint(double x1, double y1, double x2, double y2)
        {
            double firstDistance = FindDistance(x1, y1);
            double secondDistance = FindDistance(x2, y2);

            if (firstDistance <= secondDistance)
            {
                Console.WriteLine("({0}, {1})", x1, y1);
            }
            else
            {
                Console.WriteLine("({0}, {1})", x2, y2);
            }
        }
    }
}
  

