namespace NumberWithStep3
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            int nthNumber = int.Parse(Console.ReadLine());

            for (int nums = 1; nums <= nthNumber; nums += 3)
            {
                Console.WriteLine(nums);
            }
        }
    }
}
