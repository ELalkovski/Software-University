namespace _03.Group_Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class GroupNums
    {
        public static void Main()
        {
            /*
             This program reads a set of numbers and groups them by their dividing remainder to 3 (0, 1 and 2).
             */

            int[] inputNums = Console.ReadLine()
                .Split(new []{", "}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            IEnumerable<int> zeroRemainders = inputNums.Where(n => Math.Abs(n) % 3 == 0);
            IEnumerable<int> oneRemainders = inputNums.Where(n => Math.Abs(n) % 3 == 1);
            IEnumerable<int> twoRemainders = inputNums.Where(n => Math.Abs(n) % 3 == 2);

            Console.WriteLine(string.Join(" ", zeroRemainders));
            Console.WriteLine(string.Join(" ", oneRemainders));
            Console.WriteLine(string.Join(" ", twoRemainders));
        }
    }
}
