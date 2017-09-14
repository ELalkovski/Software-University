namespace Rectangle_Properties
{
    using System;

    public class RectangleProperties
    {
        public static void Main()
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double rectArea = width * height;
            double rectPerimeter = 2 * (width + height);
            double rectDiagonal = Math.Sqrt((width * width) + (height * height));

            Console.WriteLine(rectPerimeter);
            Console.WriteLine(rectArea);
            Console.WriteLine(rectDiagonal);
        }
    }
}
