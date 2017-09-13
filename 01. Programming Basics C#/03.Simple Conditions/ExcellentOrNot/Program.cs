using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcellentOrNot
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = double.Parse(Console.ReadLine());
            if (a >= 5.50)
            {
                Console.WriteLine("Excellent!");
            }
            else 
            {
                Console.WriteLine("Not Excellent.");
            }
        }
    }
}
