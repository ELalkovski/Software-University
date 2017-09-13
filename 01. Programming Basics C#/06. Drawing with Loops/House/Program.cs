using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int dashes = 0;
            int stars = 0;
            
            

            if (n % 2 == 0)
            {
                dashes = n - 2;
                stars = 2;
            }
            else if (n % 2 == 1)
            {
                dashes = n - 1;
                stars = 1;
            }

            for (int roof = 1; roof <= (n + 1)/ 2; roof++)
            {
                Console.Write("{0}{1}{0}", new string('-', (n - stars)/2), new string('*',stars));
                Console.WriteLine();
                dashes--;
                stars += 2;
            }
            for (int house = 1; house <= n / 2 ; house++)
            {
                Console.Write("|{0}|", new string('*', n - 2));
                Console.WriteLine();
               
                
            }
        }
    }
}
