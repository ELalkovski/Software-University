using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int num = 0; num <= n; num++)
            {
                 int sum = 0;
                int digits = num;

                while (digits > 0)
                {
                    sum += digits % 10;
                    digits = digits / 10;
                }

                bool answer = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine("{0} -> {1}",num, answer);

            }
        }
    }
}
