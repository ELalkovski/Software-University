using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print_Part_of_The_ACII_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            for (int asciiNums = start; asciiNums <= end; asciiNums++)
            {
                Console.Write("{0} ",Convert.ToChar(asciiNums));
            }
            Console.WriteLine();
        }
    }
}
