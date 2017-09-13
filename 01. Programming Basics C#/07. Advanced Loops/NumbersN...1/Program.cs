using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersN._._._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int nums = n; nums >= 1; nums--)
            {
                Console.WriteLine(nums);
            }
        }
    }
}
