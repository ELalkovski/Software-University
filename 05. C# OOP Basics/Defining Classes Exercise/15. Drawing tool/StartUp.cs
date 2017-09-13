using System;

namespace _15.Drawing_tool
{
    public class StartUp
    {
        public static void Main()
        {
            var type = Console.ReadLine();
            var width = int.Parse(Console.ReadLine());

            switch (type)
            {
                case "Square": 
                    var square = new Square(width);
                    square.Draw();
                    break;
                case "Rectangle":
                    var height = int.Parse(Console.ReadLine());
                    var rectangle = new Rectangle(width, height);
                    rectangle.Draw();
                    break;
            }
        }
    }
}
