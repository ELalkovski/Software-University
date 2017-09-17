using System;

public class Rectangle : IDrawable
{
    private int height;
    private int width;
    
    public Rectangle(int height, int width)
    {
        this.Height = height;
        this.Width = width;
    }

    public int Height
    {
        get { return this.height; }
        private set { this.height = value; }
    }

    public int Width
    {
        get { return this.width; }
        private set { this.width = value; }
    }

    public void Draw()
    {
        Console.WriteLine(new string('*', this.width));

        for (int i = 0; i < this.height - 2; i++)
        {
            Console.Write('*');
            Console.Write(new string(' ', this.width - 2));
            Console.Write('*');
            Console.WriteLine();
        }

        Console.WriteLine(new string('*', this.width));
    }
}
