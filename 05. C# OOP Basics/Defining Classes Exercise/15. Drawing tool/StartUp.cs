namespace _15.Drawing_tool
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            string type = Console.ReadLine();
            int width = int.Parse(Console.ReadLine());

            switch (type)
            {
                case "Square": 
                    Square square = new Square(width);
                    square.Draw();

                    break;
                case "Rectangle":
                    int height = int.Parse(Console.ReadLine());
                    Rectangle rectangle = new Rectangle(width, height);
                    rectangle.Draw();

                    break;
            }
        }
    }
}
