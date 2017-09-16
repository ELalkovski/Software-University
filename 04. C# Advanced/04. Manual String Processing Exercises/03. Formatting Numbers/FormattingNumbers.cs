using System;

namespace _03.Formatting_Numbers
{
    public class FormattingNumbers
    {
        public static void Main()
        {
            var input = Console.ReadLine()
                .Split(new[] {' ', '\t'}, StringSplitOptions.RemoveEmptyEntries);

            var a = int.Parse(input[0]);
            var b = double.Parse(input[1]);
            var c = double.Parse(input[2]);

            var hexaResult = string.Format("{0, -10:X}", a);
            var binaryResult = Convert.ToString(a, 2);
            if (binaryResult.Length > 10)
            {
                binaryResult = binaryResult.Substring(0, 10);
            }

            Console.Write("|{0}|", hexaResult);
            Console.Write("{0}|", binaryResult.PadLeft(10, '0'));
            Console.Write("{0, 10:f2}|", b);
            Console.Write("{0, -10:f3}|", c);
            Console.WriteLine();
        }
    }
}
