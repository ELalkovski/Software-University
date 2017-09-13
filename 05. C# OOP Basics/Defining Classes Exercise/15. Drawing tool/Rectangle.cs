using System;

namespace _15.Drawing_tool
{
    public class Rectangle : CorDraw
    {
        private int height;

        public Rectangle(int width, int hegiht)
            : base(width)
        {
            this.height = hegiht;
        }

        public void Draw()
        {
            
            for (int i = 0; i < this.height; i++)
            {
                if (i == 0 || i == this.height - 1)
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
