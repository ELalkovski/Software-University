using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusScore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter score: ");
            var score = double.Parse(Console.ReadLine());
            var bonusScore = 0.0;

            if (score <= 100)
            {
                bonusScore += 5;
            }
            else if (score > 100)
            {
                bonusScore += 0.2 * score;
            }
            else if (score <= 1000) 
            {
                bonusScore += 0.2 * score;
            }
            if (score > 1000)
            {
                bonusScore = 0.1 * score;
            }
            if (score % 2 == 0)
            {
                bonusScore += 1;
            }
            else if (score % 10 == 5)
            {
                bonusScore += 2;
            }

            Console.WriteLine("Bonus Score: " +bonusScore);
            Console.WriteLine("Total score: " + (score + bonusScore ));
        }
    }
}
