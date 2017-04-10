using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace integerToHexAndBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            string hexValue = Convert.ToString(num, 16).ToUpper();
            string binValue = Convert.ToString(num, 2);

            Console.WriteLine(hexValue);
            Console.WriteLine(binValue);
            

            
        }
    }
}
