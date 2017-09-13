using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointintheFigure
{
    class Program
    {
        static void Main(string[] args)
        {
            var h = int.Parse(Console.ReadLine());
            var x = int.Parse(Console.ReadLine());
            var y = int.Parse(Console.ReadLine());

           
            var inside = ((x > 0) && (x < (3 * h))) && ((y > 0) && (y < h)) ||
                ((x > h) && (x < (2 * h))) && ((y > 0) && (y < (4 * h))) || 
                ((x > (2 * h)) && (x < (3*h))) && ((y > 0) && (y < h));

            var outside = !inside;

            var border = ((x >= 0) && (x <= (3 * h))) && ((y >= 0) && (y <= h)) ||
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
