using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumSeconds
{
    class Program
    {
        static void Main(string[] args)
        {
            var sec1 = int.Parse(Console.ReadLine());
            var sec2 = int.Parse(Console.ReadLine());
            var sec3 = int.Parse(Console.ReadLine());

            var totalSecond = sec1 + sec2 + sec3;

            var minutes = totalSecond / 60;
            var seconds = totalSecond % 60;

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
