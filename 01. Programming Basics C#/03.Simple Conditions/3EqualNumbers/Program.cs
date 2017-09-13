using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3EqualNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var number1 = int.Parse(Console.ReadLine());
            var number2 = int.Parse(Console.ReadLine());
            var number3 = int.Parse(Console.ReadLine());

            if (number1 == number2 && number2 == number3)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
