using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Longer_Line
{
    class Program
    {
        public static double LineLenght(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }

        public static double DistanceToCenter(double x, double y)
        {
            return Math.Sqrt(Math.Pow((0 - x), 2) + Math.Pow((0 - y), 2));
        }

        static void PrintClosestPointFirst(double x1, double y1, double x2, double y2)
        {
            if (DistanceToCenter(x1, y1) > DistanceToCenter(x2, y2))
            {
                Console.Write("(" + x2 + ", " + y2 + ")");
                Console.WriteLine("(" + x1 + ", " + y1 + ")");
            }
            else
            {
                Console.Write("(" + x1 + ", " + y1 + ")");
                Console.WriteLine("(" + x2 + ", " + y2 + ")");
            }
        }

        public static void PrintLongerLine(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
        {
            
            if (LineLenght(x1, y1, x2, y2) >= LineLenght(x3, y3, x4, y4))
            {
                 PrintClosestPointFirst(x1, y1, x2, y2);
            }
            else
            {
                PrintClosestPointFirst(x3, y3, x4, y4);
            }

        }

        private static double secondDistance(double arg1, double arg2, double arg3, double arg4)
        {
            throw new NotImplementedException();
        }

        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());

            PrintLongerLine(x1, y1, x2, y2, x3, y3, x4, y4);
        }
    }
}
