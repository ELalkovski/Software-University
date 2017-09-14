namespace TheaTheFotographer
{
    using System;

    public class TheaPhotographer
    {
        public static void Main()
        {
            long picsAmount = long.Parse(Console.ReadLine());
            long secondsRequired = long.Parse(Console.ReadLine());
            long filterFactor = long.Parse(Console.ReadLine());
            long timeNeededForUpload = long.Parse(Console.ReadLine());

            double usefullPics = Math.Ceiling(((double)filterFactor / 100) * picsAmount);
            double filteringTime = secondsRequired * picsAmount;
            double uploadingTime = timeNeededForUpload * usefullPics;
            double fullTimeInSecs = filteringTime + uploadingTime;

            TimeSpan time = TimeSpan.FromSeconds(fullTimeInSecs);
            string answer = time.ToString(@"d\:hh\:mm\:ss");

            Console.WriteLine(answer);
        }
    }
}
