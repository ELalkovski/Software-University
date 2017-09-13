using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            var projection = Console.ReadLine().ToLower();
            var rows = int.Parse(Console.ReadLine());
            var seats = int.Parse(Console.ReadLine());
            var tickets = rows * seats;

            switch (projection)
            {
                case "premiere": Console.WriteLine("{0:f2} leva", 12 * tickets);break;
                case "normal": Console.WriteLine("{0:f2} leva", 7.50 * tickets); break;
                case "discount": Console.WriteLine("{0:f2} leva", 5 * tickets); break;
            }
        }
    }
}
