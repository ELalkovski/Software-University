namespace SumSeconds
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int sec1 = int.Parse(Console.ReadLine());
            int sec2 = int.Parse(Console.ReadLine());
            int sec3 = int.Parse(Console.ReadLine());

            int totalSecond = sec1 + sec2 + sec3;
            
            int minutes = totalSecond / 60;
            int seconds = totalSecond % 60;

            if (seconds >= 10)
            {
                Console.WriteLine(minutes + ":" + seconds);
            }
            else
            {
                Console.WriteLine(minutes + ":0" + seconds);
            }
        }
    }
}
