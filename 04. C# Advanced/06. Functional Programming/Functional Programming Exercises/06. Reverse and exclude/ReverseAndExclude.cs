using System;
using System.Linq;

namespace _06.Reverse_and_exclude
{
    public class ReverseAndExclude
    {
        public static void Main()
        {
            var inputNums = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            var divisibleNum = int.Parse(Console.ReadLine());

            Predicate<int> isDivisible = (a) => { return a % divisibleNum == 0; };

            inputNums.Reverse(0, inputNums.Count);
            inputNums.RemoveAll(isDivisible);


            Console.WriteLine(string.Join(" ", inputNums));
        }
    }
}
