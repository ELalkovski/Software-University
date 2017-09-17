namespace _03.Formatting_Numbers
{
    using System;

    public class FormattingNumbers
    {
        public static void Main()
        {
            string[] input = Console.ReadLine()
                .Split(new[] {' ', '\t'}, StringSplitOptions.RemoveEmptyEntries);

            int a = int.Parse(input[0]);
            double b = double.Parse(input[1]);
            double c = double.Parse(input[2]);

            string hexaResult = string.Format("{0, -10:X}", a);
            string binaryResult = Convert.ToString(a, 2);

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
