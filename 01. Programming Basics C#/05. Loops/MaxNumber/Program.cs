using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int numbers = int.Parse(Console.ReadLine());
            int max = numbers;
            for (int i = 0; i< n-1; i++)
            {
                 numbers = int.Parse(Console.ReadLine());
                if (numbers > max)
                {
                    max = numbers;
                }
               
            }
            Console.WriteLine(max);
        }
    }
}
