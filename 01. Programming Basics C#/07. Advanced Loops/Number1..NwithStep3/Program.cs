using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number1._.NwithStep3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int nums = 1; nums <= n; nums += 3)
            {
                Console.WriteLine(nums);
            }
        }
    }
}
