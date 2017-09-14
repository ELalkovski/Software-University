namespace Integer_to_Hex_and_Binary
{
    using System;

    public class IntConverter
    {
        public static void Main()
        {
            int num = int.Parse(Console.ReadLine());

            string hexValue = Convert.ToString(num, 16).ToUpper();
            string binValue = Convert.ToString(num, 2);

            Console.WriteLine(hexValue);
            Console.WriteLine(binValue);
        }
    }
}
