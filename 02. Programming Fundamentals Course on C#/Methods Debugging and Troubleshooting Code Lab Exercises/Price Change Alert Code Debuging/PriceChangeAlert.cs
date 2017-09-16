namespace Price_Change_Alert_Code_Debuging
{
    using System;

    public class PriceChangeAlert
    {
        public static void Main()
        {
            int linesCount = int.Parse(Console.ReadLine());
            double threshold = double.Parse(Console.ReadLine());
            double price = double.Parse(Console.ReadLine());

            for (int i = 0; i < linesCount - 1; i++)
            {
                double nextPrice = double.Parse(Console.ReadLine());
                double difference = Proc(price, nextPrice);

                bool isSignificantDifference = IsEnoughDiff(difference, threshold);
                string message = GetMessage(nextPrice, price, difference, isSignificantDifference);
                Console.WriteLine(message);
                price = nextPrice;
            }
        }

        private static string GetMessage(double nextPrice, double price, double difference, bool etherTrueOrFalse)
        {
            string changeMessage = "";

            if (difference == 0)
            {
                changeMessage = string.Format("NO CHANGE: {0}", nextPrice);
            }

            if (!etherTrueOrFalse)
            {
                changeMessage = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", price, nextPrice, difference * 100);
            }

            if (etherTrueOrFalse && (difference > 0))
            {
                changeMessage = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", price, nextPrice, difference * 100);
            }

            if (etherTrueOrFalse && (difference < 0))
            {
                changeMessage = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", price, nextPrice, difference * 100);
            }

            return changeMessage;
        }

        private static bool IsEnoughDiff(double threshold, double isDiff)
        {
            if (Math.Abs(threshold) >= isDiff)
            {
                return true;
            }

            return false;
        }

        private static double Proc(double price, double nextPrice)
        {
            double difference = (nextPrice - price) / price;

            return difference;
        }
    }
}
