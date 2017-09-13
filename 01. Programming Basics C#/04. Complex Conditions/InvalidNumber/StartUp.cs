namespace InvalidNumber
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            bool inRange = (number >= 100 && number <= 200 || number == 0);

            if (!inRange)
            {
                Console.WriteLine("invalid");
            }
        }
    }
}
