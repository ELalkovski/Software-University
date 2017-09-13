using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tripple_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();

            string[] strArray = new string[n.Length];

            var array = n.Split(' ').Select(int.Parse).ToArray();

            bool isSum = false;

            for (int i = 0; i < array.Length; i++)
            {
                for (int a = i + 1; a <= array.Length - 1; a++)
                {
                    for (int b = 0; b <= array.Length - 1; b++)
                    {
                        if (array[i] + array[a] == array[b])
                        {
                            Console.WriteLine("{0} + {1} == {2}", array[i], array[a], array[b]);
                            isSum = true;
                            break;
                        }
                    }
                }
            }

            if (!isSum)
            {
                Console.WriteLine("No");
            }
        }
    }
}
