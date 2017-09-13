using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal MoneyString = decimal.Parse(Console.ReadLine());
            string currencyIN = (Console.ReadLine());
            string currencyOUT = (Console.ReadLine());
            decimal firstRate = 0.0m;
            decimal seondRate = 0.0m;


            if (currencyIN == "BGN")
            {
                firstRate = 1;
            }

            else if (currencyIN == "USD")

            {

                firstRate = 1.79549m;

            }

            else if (currencyIN == "EUR")

            {

                firstRate = 1.95583m;

            }

            else if (currencyIN == "GBP")

            {

                firstRate = 2.53405m;

            }

            if (currencyOUT == "BGN")

            {
                seondRate = 1m;
            }
            else if (currencyOUT == "USD")
            {
                seondRate = 1.79549m;

            }
            else if (currencyOUT == "EUR")
            {
                seondRate = 1.95583m;
            }
            else if (currencyOUT == "GBP")
            {
                seondRate = 2.53405m;
            }
            decimal result = MoneyString * (firstRate / seondRate);
            Console.WriteLine("{0} {1}", Math.Round(result, 2), currencyOUT);

        }
    }
}
