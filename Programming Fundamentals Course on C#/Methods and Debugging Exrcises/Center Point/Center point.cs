using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Center_Point
{
    class CenterPoint
    {
        public static double FindDistance(double x, double y)
        {
            double distance = Math.Sqrt((x * x) + (y * y));
            return distance;
        }

        public static void PrintClosestPoint(double x1, double y1, double x2, double y2)
        {
            double firstDistance = FindDistance(x1, y1);
            double secondDistance = FindDistance(x2, y2);

            if (firstDistance <= secondDistance)
            {
                Console.WriteLine("({0}, {1})", x1, y1);
            }
            else if (firstDistance > secondDistance)
            {
                Console.WriteLine("({0}, {1})", x2, y2);
            }

        }

        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            PrintClosestPoint(x1, y1, x2, y2);
        }
    }
}
  

