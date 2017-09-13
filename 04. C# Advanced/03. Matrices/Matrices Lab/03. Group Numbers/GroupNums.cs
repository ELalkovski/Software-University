namespace _03.Group_Numbers
{
    using System;
    using System.Linq;

    public class GroupNums
    {
        public static void Main()
        {
            /*
             This program reads a set of numbers and groups them by their dividing remainder to 3 (0, 1 and 2).
             */

            var inputNums = Console.ReadLine()
                .Split(new []{", "}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse);

            var zeroRemainders = inputNums.Where(n => Math.Abs(n) % 3 == 0);
            var oneRemainders = inputNums.Where(n => Math.Abs(n) % 3 == 1);
            var twoRemainders = inputNums.Where(n => Math.Abs(n) % 3 == 2);

            Console.WriteLine(string.Join(" ", zeroRemainders));
            Console.WriteLine(string.Join(" ", oneRemainders));
            Console.WriteLine(string.Join(" ", twoRemainders));
        }
    }
}
