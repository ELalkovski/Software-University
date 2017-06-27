namespace _03.Decimal_to_Binary_Converter
{
    using System;
    using System.Collections.Generic;

    public class Converter
    {
        public static void Main()
        {
            var input = int.Parse(Console.ReadLine());
            var stack = new Stack<int>();


            if (input == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                while (input != 0)
                {
                    var reminder = input % 2;
                    input /= 2;

                    stack.Push(reminder);
                }
            }
            var length = stack.Count;

            for (int i = 0; i < length; i++)
            {
                Console.Write(stack.Pop());
            }
            Console.WriteLine();
        }
    }
}
