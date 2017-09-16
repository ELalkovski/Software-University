namespace Geometry_Calculator
{
    using System;

    public class GeometryCalculator
    {
        public static void Main()
        {
            string parameter = Console.ReadLine();
            double result = PrintResult(parameter);

            Console.WriteLine("{0:f2}",result);
        }

        private static double GetTriangleArea(double side, double height)
        {
            return (side * height) / 2;
        }

        private static double GetSquareArea(double side)
        {
            return Math.Pow(side, 2);
        }

        private static double GetRectangleArea(double width, double height)
        {
            return (width * height);
        }

        private static double GetCircleArea(double radius)
        {
            return (Math.PI * Math.Pow(radius, 2));
        }

        private static double PrintResult(string parameter)
        {
            double result = 0;

            if (parameter == "triangle")
            {
                double side = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                result = GetTriangleArea(side, height);
            }
            else if (parameter == "square")
            {
                double side = double.Parse(Console.ReadLine());
                result = GetSquareArea(side);
            }
            else if (parameter == "rectangle")
            {
                double width = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                result = GetRectangleArea(width, height);
            }
            else if (parameter == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                result = GetCircleArea(radius);
            }

            return result;
        }
    }
}
