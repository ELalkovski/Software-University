using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money_TEST1
{
    class Program
    {
        static void Main(string[] args)
        {
            var bitcoin = int.Parse(Console.ReadLine());
            var yuan = double.Parse(Console.ReadLine());
            var comission = double.Parse(Console.ReadLine());


            int bgn = 1;
            int bitcoinToBgn = 1168 * bgn;
            double YuanToUsd = 0.15;
            double Usd = 1.76 * bgn;
            double euro = 1.95 * bgn;
            double comissionTo = 0.01 * comission;

            int SUMbitcoins = (bitcoin * bitcoinToBgn);
            double SUMyuans = (yuan * YuanToUsd)* Usd;
            double ALL = (SUMbitcoins + SUMyuans) / euro;
            double Final = ALL - (ALL * comissionTo);

            Console.WriteLine(Final); 
            
            
            

        }
    }
}
