using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_an_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            var strArray = new string[input.Length];
            var array = input.Split(' ').ToArray();

            for (int i = array.Length - 1; i >= 0; i--)
            {
                Console.Write("{0} ",array[i]);
            }

            Console.WriteLine();
        }
    }
}
