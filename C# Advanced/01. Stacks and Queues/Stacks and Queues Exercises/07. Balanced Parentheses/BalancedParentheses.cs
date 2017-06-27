namespace _07.Balanced_Parentheses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class BalancedParentheses
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var openingBracketsStack = new Stack<char>();
            var openSigns = new char[] { '(', '[', '{' };

            for (int i = 0; i < input.Length; i++)
            {
                if (openSigns.Contains(input[i]))
                {
                    openingBracketsStack.Push(input[i]);
                }
                else
                {
                    if (openingBracketsStack.Count == 0)
                    {
                        Console.WriteLine("NO");
                        return;
                    }
                    switch (input[i])
                    {
                        case ')':
                            if (openingBracketsStack.Pop() != '(')
                            {
                                Console.WriteLine("NO");
                                return;
                            }
                            break;
                        case ']':
                            if (openingBracketsStack.Pop() != '[')
                            {
                                Console.WriteLine("NO");
                                return;
                            }
                            break;
                        case '}':
                            if (openingBracketsStack.Pop() != '{')
                            {
                                Console.WriteLine("NO");
                                return;
                            }
                            break;
                    }
                }
            }

            Console.WriteLine("YES");
        }
    }
}
