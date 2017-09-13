namespace PointintheFigure
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int h = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

           
            bool inside = ((x > 0) && (x < (3 * h))) && ((y > 0) && (y < h)) ||
                ((x > h) && (x < (2 * h))) && ((y > 0) && (y < (4 * h))) || 
                ((x > (2 * h)) && (x < (3*h))) && ((y > 0) && (y < h));

            bool outside = !inside;

            bool border = ((x >= 0) && (x <= (3 * h))) && ((y >= 0) && (y <= h)) ||
                ((x >= h) && (x <= (2 * h))) && ((y >= 0) && (y <= (4 * h))) ||
                ((x >= (2 * h)) && (x <= (3 * h))) && ((y >= 0) && (y <= h));


            if (inside)
            {
                Console.WriteLine("inside");
            }

            else if (border)
            {
                Console.WriteLine("border");
            }

            else
            {
                Console.WriteLine("outside");
            }
        }
    }
}
