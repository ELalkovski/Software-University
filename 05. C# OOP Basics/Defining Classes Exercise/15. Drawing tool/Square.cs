using System;

namespace _15.Drawing_tool
{
    public class Square : CorDraw
    {
        public Square(int width)
            : base(width)
        { }

        public void Draw()
        {
            for (int i = 0; i < this.width; i++)
            {
                if (i == 0 || i == this.width - 1)
                {
                    Console.WriteLine($"|{string.Join(" ", new string('-', this.width))}|");
                }
                else
                {
                    Console.WriteLine($"|{string.Join(" ", new string(' ', this.width))}|");
                }
            }
        }
    }
}
