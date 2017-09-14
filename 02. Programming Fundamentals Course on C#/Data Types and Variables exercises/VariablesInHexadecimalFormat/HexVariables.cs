namespace VariablesInHexadecimalFormat
{
    using System;

    public class HexVariables
    {
        public static void Main()
        {
            string num = Console.ReadLine();

            Console.WriteLine(Convert.ToInt32(num, 16));
        }
    }
}
