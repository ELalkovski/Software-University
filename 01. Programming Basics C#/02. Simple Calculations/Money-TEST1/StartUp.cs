namespace Money_TEST1
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int bitcoin = int.Parse(Console.ReadLine());
            double yuan = double.Parse(Console.ReadLine());
            double comission = double.Parse(Console.ReadLine());

            int bgn = 1;
            int bitcoinToBgn = 1168 * bgn;
            double yuanToUsd = 0.15;
            double usd = 1.76 * bgn;
            double euro = 1.95 * bgn;
            double comissionTo = 0.01 * comission;

            int sumBitcoins = (bitcoin * bitcoinToBgn);
            double sumYuans = (yuan * yuanToUsd)* usd;
            double finalSum = (sumBitcoins + sumYuans) / euro;
            double result = finalSum - (finalSum * comissionTo);

            Console.WriteLine(result); 
        }
    }
}
