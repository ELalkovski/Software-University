namespace Exchange_Variable_Values
{
    using System;

    public class ExchangeValues
    {
        public static void Main()
        {
            int a = 5;
            int b = 10;
            int temp;

            Console.WriteLine("Before:");
            Console.WriteLine("a = {0}",a);
            Console.WriteLine("b = {0}",b);

            temp = a;
            a = b;

            Console.WriteLine("After:");
            Console.WriteLine("a = {0}",a);

            b = temp;

            Console.WriteLine("b = {0}",b);
        }
    }
}
