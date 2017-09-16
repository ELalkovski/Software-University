namespace Blank_Receipt
{
    using System;
    using System.Text;

    public class BlankReceipt
    {
        public static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            PrintReceipt();
        }

        private static void PrintReceiptHeader()
        {
            Console.WriteLine("CASH RECEIPT");
            Console.WriteLine("------------------------------");
        }

        private static void PrintReceiptBody()
        {
            Console.WriteLine("Charged to____________________");
            Console.WriteLine("Received by___________________");
        }

        private static void PrintReceiptFooter()
        {
            Console.WriteLine("------------------------------");
            string symbol = "\u00A9";

            Console.WriteLine(symbol + " SoftUni");
        }

        private static void PrintReceipt()
        {
            PrintReceiptHeader();
            PrintReceiptBody();
            PrintReceiptFooter();
        }
    }
}
