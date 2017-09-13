namespace Voleyball
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            string year = Console.ReadLine().ToLower();
            int privateGames = int.Parse(Console.ReadLine());
            int holidays = int.Parse(Console.ReadLine());
            int weekendsSofia = 48 - holidays;
            double gamesInSofia = weekendsSofia * (3.0 / 4);
            double gamesInHoliday = privateGames * (2.0 / 3);
            double totalGames = holidays + gamesInSofia + gamesInHoliday;

            switch (year)
            {
                case "leap": Console.WriteLine(Math.Truncate((totalGames * 0.15) + totalGames)); break;
                case "normal": Console.WriteLine(Math.Truncate(totalGames)); break;
            }
        }
    }
}
