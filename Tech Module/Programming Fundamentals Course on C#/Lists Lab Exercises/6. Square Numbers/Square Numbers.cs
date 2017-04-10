using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Square_Numbers
{
    class Program
    {
        public static List<double> GetSquareRootNums(List<double> inputNums)
        {
            var squareNums = new List<double>();

            foreach (var currNum in inputNums)
            {
                if (Math.Sqrt(currNum) == (int)Math.Sqrt(currNum))
                {
                    squareNums.Add(currNum);
                }
            }

            squareNums.Sort((a, b) => b.CompareTo(a));

            return squareNums;
        }

        static void Main(string[] args)
        {
            var inputNums = Console.ReadLine().Split(' ').Select(double.Parse).ToList();

            Console.WriteLine(string.Join(" ", GetSquareRootNums(inputNums)));
        }
    }
}
