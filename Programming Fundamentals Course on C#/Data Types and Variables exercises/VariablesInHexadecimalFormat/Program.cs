using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesInHexadecimalFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();
            

            Console.WriteLine(Convert.ToInt32(num, 16));
            
        }
    }
}
