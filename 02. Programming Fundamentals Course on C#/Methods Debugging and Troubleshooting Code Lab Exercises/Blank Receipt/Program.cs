using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blank_Receipt
{
    class Program
    {
        public static void PrintReceiptHeader()
        {
            Console.WriteLine("CASH RECEIPT");
            Console.WriteLine("------------------------------");
        }

        public static void PrintReceiptBody()
        {
            Console.WriteLine("Charged to____________________");
            Console.WriteLine("Received by___________________");
        }

        public static void PrintReceiptFooter()
        {
            Console.WriteLine("------------------------------");
            string symbol = "\u00A9";

            Console.WriteLine(symbol + " SoftUni");
        }

        public static void PrintReceipt()
        {
            PrintReceiptHeader();
            PrintReceiptBody();
            PrintReceiptFooter();
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            PrintReceipt();
        }
    }
}
