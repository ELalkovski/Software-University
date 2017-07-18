using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Date_Modifier
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var firstDate = Console.ReadLine();
            var secondDate = Console.ReadLine();
            var dateModifier = new DateModifier(firstDate, secondDate);

            Console.WriteLine(dateModifier.CalculateDays());
        }
    }
}
