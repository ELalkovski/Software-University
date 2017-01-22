using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheaTheFotographer
{
    class Program
    {
        static void Main(string[] args)
        {
            //long picsAmount = long.Parse(Console.ReadLine());
            //long secondsRequired = long.Parse(Console.ReadLine());
            //long filterFactor = long.Parse(Console.ReadLine());
            //long timeNeededForUpload = long.Parse(Console.ReadLine());

            //double usefullPics = Math.Ceiling(((double)filterFactor / 100) * picsAmount);
            //double filteringTime = secondsRequired * picsAmount;
            //double uploadingTime = timeNeededForUpload * usefullPics;
            //double fullTimeInSecs = filteringTime + uploadingTime;

            //double timeInDays = Math.Truncate((fullTimeInSecs / (24 * 3600)));
            //double timeInHours = Math.Truncate((fullTimeInSecs % (24 * 3600)) / 3600);
            //double timeInMins = Math.Truncate((fullTimeInSecs % 3600) / 60);
            //double timeInSecs = Math.Truncate((fullTimeInSecs % 3600) % 60);

            //if (timeInDays < 10 || timeInHours < 10 || timeInMins < 10 || timeInSecs < 10)
            //{
            //    Console.Write("{0}:", timeInDays);
            //    if (timeInHours < 10) Console.Write("0{0}:", timeInHours);
            //    if (timeInHours > 10) Console.WriteLine("{0}:", timeInHours);
            //    if (timeInMins < 10) Console.Write("0{0}:", timeInMins);
            //    if (timeInMins > 10) Console.Write("{0}:", timeInMins);
            //    if (timeInSecs < 10) Console.Write("0{0}", timeInSecs);
            //    if (timeInSecs > 10) Console.Write("{0}", timeInSecs);
            //    Console.WriteLine();
            //}
            //else
            //{
            //    Console.WriteLine("{0}:{1}:{2}:{3}", timeInDays, timeInHours, timeInMins, timeInSecs);
            //}
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
