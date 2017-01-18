using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactor_Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int digit = 0;
            bool answer = false;
            for (int i = 1; i <= n; i++)
            {
                digit = i;
                while (digit > 0)
                {
                    sum += digit % 10;
                    digit = digit / 10;
                }
                answer = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine($"{i} -> {answer}");
                sum = 0;
                
            }

        }
    }
}
