using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condense_Array_to_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] mainArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            
            while (mainArr.Length > 1)
            {
                int[] condensedArr = new int[mainArr.Length - 1];

                for (int i = 0; i < condensedArr.Length; i++)
                {
                    condensedArr[i] = mainArr[i] + mainArr[i + 1];
                }
                mainArr = condensedArr;
            }

            Console.WriteLine(String.Join(" ", mainArr));
           
        }
    }
}
