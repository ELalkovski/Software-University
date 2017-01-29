using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_an_Array_of_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbersCount = int.Parse(Console.ReadLine());

            var array = new int[numbersCount];

            for (int i = 0; i < numbersCount; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            for (int i = array.Length - 1; i >= 0; i--)
            {
                Console.Write("{0} ",array[i]);
            }

            Console.WriteLine();
        }
    }
}
