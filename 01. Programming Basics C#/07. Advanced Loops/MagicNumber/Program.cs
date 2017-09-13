using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int a = 0; a <= 9 ; a++)
            {
                for (int b = 0; b <= 9 ; b++)
                {
                    for (int c = 0; c <= 9 ; c++)
                    {
                        for (int d = 0; d <= 9 ; d++)
                        {
                            for (int e = 0; e <= 9; e++)
                            {
                                for (int f = 0; f <= 9 ; f++)
                                {
                                    if (n == a * b * c * d * e * f)
                                    {
                                        Console.Write("{0}{1}{2}{3}{4}{5} ", a, b, c, d, e, f);
                                    }
                                }
                               
                            }
                        }
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
