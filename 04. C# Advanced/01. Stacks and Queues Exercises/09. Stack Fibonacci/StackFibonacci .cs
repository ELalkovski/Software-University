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

            int nthNumber = int.Parse(Console.ReadLine());  
            Stack<long> fibonacciStack = new Stack<long>();
            fibonacciStack.Push(0);
            fibonacciStack.Push(1);
            fibonacciStack.Push(1);

            long firstNum = fibonacciStack.Peek();
            long secondNum = fibonacciStack.Peek();

            for (int i = 3; i <= nthNumber; i++)
            {
                long currFibNum = firstNum + secondNum;
                firstNum = fibonacciStack.Pop();
                fibonacciStack.Push(currFibNum);
                secondNum = fibonacciStack.Peek();
            }

            Console.WriteLine(fibonacciStack.Peek());
        }
    }
}
