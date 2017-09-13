using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int numbers = int.Parse(Console.ReadLine());
            int min = numbers;

            for (int i = 0; i < n-1 ; i++)
            {
               numbers = int.Parse(Console.ReadLine());
                
                if (min > numbers)
                {
                    min = numbers;
                }

            }
            Console.WriteLine(min);
        }
    }
}
