using System;

public class Circle : IDrawable
{
    private int radius;

    public Circle(int radius)
    {
        this.Radius = radius;
    }

    public int Radius
    {
        get { return this.radius; }
        private set { this.radius = value; }
    }

    public void Draw()
    {
        double r_in = this.radius - 0.4;
        double r_out = this.radius + 0.4;

        for (double y = this.radius; y >= -this.radius; --y)
        {
            for (double x = -this.radius; x < r_out; x += 0.5)
            {
                double value = x * x * y * y;

                if (value >= r_in * r_in && value <= r_out * r_out)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(" ");
                }
            }

            Console.WriteLine();
        }
    }
}
