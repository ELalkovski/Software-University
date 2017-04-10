using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Remove_Negatives_and_Reverse
{
    class Program
    {
        public static void PrintTreatedList(List<int> list)
        {
            list.RemoveAll(x => x < 0);
            list.Reverse();

            if (list.Count > 0)
            {
                foreach (var currNum in list)
                {
                    Console.Write("{0} ", currNum);
                }
            }
            else
            {
                Console.WriteLine("empty");
            }
        }

        static void Main(string[] args)
        {
            var list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            PrintTreatedList(list);
        }
    }
}
