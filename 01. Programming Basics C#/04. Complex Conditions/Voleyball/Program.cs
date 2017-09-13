using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            var year = Console.ReadLine().ToLower();
            var p = int.Parse(Console.ReadLine());
            var h = int.Parse(Console.ReadLine());
            var weekendsSofia = 48 - h;
            var gamesInSofia = weekendsSofia * (3.0 / 4);
            var gamesInHoliday = p * (2.0 / 3);
            var totalGames = h + gamesInSofia + gamesInHoliday;

            switch (year)
            {
                case "leap": Console.WriteLine(Math.Truncate((totalGames * 0.15) + totalGames)); break;
                case "normal": Console.WriteLine(Math.Truncate(totalGames)); break;
            }

        }
    }
}
