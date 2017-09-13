using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int midDashes = 0;
            int oddMidDashes = 1;
            int leftRightDashes = (n - 2) / 2;
            int oddleftRightDashes = (n - 3) / 2;

            if (n <= 2)
            {
                Console.Write("{0}", new string('*', n));
                Console.WriteLine();
            }
            else
            {
                if (n % 2 == 0)
                {
                    
                    for (int uprows = 1; uprows <= n/2; uprows++)
                    {
                        Console.Write("{0}*{1}*{0}", new string('-', leftRightDashes), new string('-',midDashes));
                        Console.WriteLine();
                        midDashes += 2;
                        leftRightDashes--;

                    }
                    leftRightDashes = 1;
                    midDashes = n - 2 - 2;
                    for (int drows = 1; drows <= (n / 2) - 1; drows++)
                    {
                        Console.Write("{0}*{1}*{0}", new string('-', leftRightDashes), new string('-', midDashes));
                        Console.WriteLine();
                        midDashes -= 2;
                        leftRightDashes++;

                    }
                }
                else if (n % 2 == 1)
                {
                    for (int uprows = 1; uprows <= (n / 2) + 1; uprows++)
                    {
                        if (uprows == 1)
                        {
                            Console.Write("{0}*{0}", new string('-', (n - 1)/ 2));
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.Write("{0}*{1}*{0}", new string('-', oddleftRightDashes), new string('-', oddMidDashes));
                            Console.WriteLine();
                            oddMidDashes += 2;
                            oddleftRightDashes--;
                        }

                    }
                    oddleftRightDashes = 1;
                    oddMidDashes = n - 2 - 2;
                    for (int uprows = 1; uprows <= n / 2; uprows++)
                    {
                        if (uprows == (n / 2))
                        {
                            Console.Write("{0}*{0}", new string('-', (n - 1) / 2));
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.Write("{0}*{1}*{0}", new string('-', oddleftRightDashes), new string('-', oddMidDashes));
                            Console.WriteLine();
                            oddMidDashes -= 2;
                            oddleftRightDashes++;
                        }

                    }

                }
            }
        }
    }
}
