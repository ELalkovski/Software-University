namespace _06.Find_and_Sum_Integers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class FindAndSum
    {
        public static void Main()
        {
            List<long> input = Console.ReadLine()
                .Split(' ')
                .Select(n =>
                {
                    long value;
                    bool success = long.TryParse(n, out value);
                    return new {value, success};
                })
                .Where(b => b.success)
                .Select(x => x.value)
                .ToList();

            if (input.Count != 0)
            {
                Console.WriteLine(input.Sum());
            }
            else
            {
                Console.WriteLine("No match");
            }
        }
    }
}
