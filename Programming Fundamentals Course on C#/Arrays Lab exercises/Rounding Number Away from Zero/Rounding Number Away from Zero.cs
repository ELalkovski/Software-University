using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rounding_Number_Away_from_Zero
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            var array = input.Split(' ').Select(double.Parse).ToArray();

            for (int i = 0; i < array.Length; i++)
            {
                var currNum = array[i];
                

                if (currNum != 0)
                {
                    Console.WriteLine("{0} => {1}", currNum, Math.Round(currNum,MidpointRounding.AwayFromZero));
                }
                else
                {
                    Console.WriteLine("0 => 0");
                }
            }
        }
    }
}
