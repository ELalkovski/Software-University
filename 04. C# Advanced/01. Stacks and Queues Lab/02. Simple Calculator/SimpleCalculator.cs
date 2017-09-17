namespace _02.Simple_Calculator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SimpleCalculator
    {
        public static void Main()
        {
            string[] input = Console.ReadLine()
                .Split(' ')
                .ToArray();
            Stack<string> stack = new Stack<string>(input.Reverse());

            while (stack.Count != 1)
            {
                int firstNumber = int.Parse(stack.Pop());
                string operatorSign = stack.Pop();
                int secondNumber = int.Parse(stack.Pop());

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
