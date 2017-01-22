using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rectangleProperties
{
    class Program
    {
        static void Main(string[] args)
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
