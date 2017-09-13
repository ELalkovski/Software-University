namespace AreaOfFigures
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            string figureType = Console.ReadLine();

            if (figureType == "square")
            {
                double a = double.Parse(Console.ReadLine());

                Console.WriteLine(Math.Round(a * a, 3));
            }
            else if (figureType == "rectangle")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());

                Console.WriteLine(Math.Round(a * b, 3));
            }
            else if (figureType == "circle")
            {
                double r = double.Parse(Console.ReadLine());

                Console.WriteLine(Math.Round(Math.PI * r * r, 3));
            }
            else if (figureType == "triangle")
            {
                double a = double.Parse(Console.ReadLine());
                double h = double.Parse(Console.ReadLine());

                Console.WriteLine(Math.Round((a * h)/2, 3));
            }
        }
    }
}
