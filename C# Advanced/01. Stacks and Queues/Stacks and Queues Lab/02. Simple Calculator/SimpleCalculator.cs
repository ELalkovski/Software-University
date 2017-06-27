namespace _02.Simple_Calculator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SimpleCalculator
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(' ').ToArray();
            var stack = new Stack<string>(input.Reverse());

            while (stack.Count != 1)
            {
                var firstNumber = int.Parse(stack.Pop());
                var operatorSign = stack.Pop();
                var secondNumber = int.Parse(stack.Pop());

                if (operatorSign == "+")
                {
                    stack.Push((firstNumber + secondNumber).ToString());
                }

                else
                {
                    stack.Push((firstNumber - secondNumber).ToString());
                }
            }
            Console.WriteLine(stack.Pop());
        }
    }
}
