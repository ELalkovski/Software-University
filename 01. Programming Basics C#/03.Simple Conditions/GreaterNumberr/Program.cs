using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreaterNumberr
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two integers:");
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());

            if (a > b)
            {
                Console.WriteLine("Greater Number: "+a);
            }
            else
            {
                Console.WriteLine("Greater Number: "+b);
            }
        }
    }
}
