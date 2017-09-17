namespace _06.Reverse_and_exclude
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ReverseAndExclude
    {
        public static void Main()
        {
            List<int> inputNums = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            int divisibleNum = int.Parse(Console.ReadLine());

            Predicate<int> isDivisible = (a) => { return a % divisibleNum == 0; };

            inputNums.Reverse(0, inputNums.Count);
            inputNums.RemoveAll(isDivisible);

            Console.WriteLine(string.Join(" ", inputNums));
        }
    }
}
