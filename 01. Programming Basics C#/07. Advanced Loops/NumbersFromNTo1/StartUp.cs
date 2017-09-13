namespace NumbersFromNTo1
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int nthNumber = int.Parse(Console.ReadLine());

            for (int nums = nthNumber; nums >= 1; nums--)
            {
                Console.WriteLine(nums);
            }
        }
    }
}
