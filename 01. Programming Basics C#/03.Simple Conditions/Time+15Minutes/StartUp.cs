namespace Time_15Minutes
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine()) + 15;
            string zero = "";

            if (minutes > 59)
            {
                hours += 1;
                minutes -= 60;
            }

            if (minutes < 10)
            {
                zero = "0";
            }

            Console.WriteLine("{0}:{1}{2}", hours % 24, zero, minutes % 60);
        }
    }
}
