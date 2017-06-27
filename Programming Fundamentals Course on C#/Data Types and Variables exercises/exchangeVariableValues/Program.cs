using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exchangeVariableValues
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;
            int temp = 0;

            Console.WriteLine("Before:");
            Console.WriteLine("a = {0}",a);
            Console.WriteLine("b = {0}",b);

            temp = a;
            a = b;
            Console.WriteLine("After:");
            Console.WriteLine("a = {0}",a);
            b = temp;
            Console.WriteLine("b = {0}",b);


        }
    }
}
