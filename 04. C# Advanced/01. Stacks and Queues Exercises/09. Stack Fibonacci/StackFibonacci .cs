using System.Diagnostics.Eventing.Reader;

namespace _09.Stack_Fibonacci
{
    using System;
    using System.Collections.Generic;

    public class StackFibonacci
    {
        public static void Main()
        {
            /*
             Prints Nth Fibonacci number using stack collection.
             */

            var nthNumber = int.Parse(Console.ReadLine());  
            var fibonacciStack = new Stack<long>();
            fibonacciStack.Push(0);
            fibonacciStack.Push(1);
            fibonacciStack.Push(1);

            var firstNum = fibonacciStack.Peek();
            var secondNum = fibonacciStack.Peek();

            for (int i = 3; i <= nthNumber; i++)
            {
                var currFibNum = firstNum + secondNum;
                firstNum = fibonacciStack.Pop();
                fibonacciStack.Push(currFibNum);
                secondNum = fibonacciStack.Peek();
            }
            Console.WriteLine(fibonacciStack.Peek());
        }
    }
}
