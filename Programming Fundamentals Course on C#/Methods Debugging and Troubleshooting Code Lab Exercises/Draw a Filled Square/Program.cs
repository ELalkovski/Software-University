using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draw_a_Filled_Square
{
    class Program
    {
        public static void PrintFirstAndLastRow(int n)
        {
            Console.WriteLine(new string('-', 2 * n));
        }

        public static void PrintCenterRow(int n)
        {
            Console.Write("-");

            for (int row = 1; row < n; row++)
            {
                Console.Write(@"\/");
            }

            Console.WriteLine("-");
        }

        public static void PrintAllCenterRows(int n)
        {
            for (int rows = 0; rows < n - 2; rows++)
            {
                PrintCenterRow(n);
            }
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintFirstAndLastRow(n);
            PrintAllCenterRows(n);
            PrintFirstAndLastRow(n);
        }
    }
}
