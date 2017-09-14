namespace Refactor_Volume_of_Pyramid
{
    using System;

    public class PyramidVolume
    {
        public static void Main()
        {
            Console.Write("Length: ");
            double lenght = double.Parse(Console.ReadLine());

            Console.Write("Width: ");
            double width = double.Parse(Console.ReadLine());

            Console.Write("Height: ");
            double height = double.Parse(Console.ReadLine());

            double volumePyramid = (lenght * width * height) / 3;

            Console.WriteLine("Pyramid Volume: {0:F2}", volumePyramid);
        }
    }
}
