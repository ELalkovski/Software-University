using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StupidPasswordGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());

            for (int firstNum = 1; firstNum <= n; firstNum++)
            {
                for (int secondNum = 1; secondNum <= n; secondNum++)
                {
                    for (char firstLet = 'a'; firstLet < 'a' + l; firstLet++)
                    {
                        for (char secondLet = 'a'; secondLet < 'a' + l; secondLet++)
                        {
                            for (int lastNum = Math.Max(firstNum,secondNum) + 1; lastNum <= n; lastNum++)
                            {
                                Console.Write("{0}{1}{2}{3}{4} ", firstNum, secondNum, firstLet, secondLet, lastNum);
                            }
                        }
                    }
                    
                }
               
            }
            Console.WriteLine();
        }
    }
}
