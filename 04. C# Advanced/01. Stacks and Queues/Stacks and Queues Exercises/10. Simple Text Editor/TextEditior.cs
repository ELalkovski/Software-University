namespace _10.Simple_Text_Editor
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class TextEditior
    {
        public static void Main()
        {
            /*
             •	1 someString - appends someString to the end of the text    
             •	2 count - erases the last count elements from the text
             •	3 index - returns the element at position index from the text
             •	4 - undoes the last not undone command of type 1 / 2 and returns the text to the state before that operation

            Input format: 
            The first line contains n, the number of operations. 
            Each of the following n lines contains the name of the operation followed by the command argument, 
            if any, separated by space in the following format CommandName Argument. 


             */

            var operationsCount = int.Parse(Console.ReadLine());
            string text = "";
            var previousStateOfText = new Stack<string>();

            for (int i = 0; i < operationsCount; i++)
            {
                var inputTokens = Console.ReadLine()
                    .Split()
                    .ToArray();

                string currOperation = inputTokens[0];

                switch (currOperation)
                {
                    case "1":
                        string currText = inputTokens[1].Trim();
                        previousStateOfText.Push(text);

                        for (int index = 0; index < currText.Length; index++)
                        {
                            text += currText[index];
                        }
                        
                        
                        break;

                    case "2":
                        var countOfLastElements = int.Parse(inputTokens[1]);
                        previousStateOfText.Push(text);

                        if (countOfLastElements >= 0 && countOfLastElements <= text.Length)
                        {
                            var indexToStop = text.Length - countOfLastElements;
                            for (int j = text.Length - 1; j >= indexToStop; j--)
                            {
                                text = text.Remove(j, 1);
                            }
                            
                        }
                        break;

                    case "3":
                        var indexToPrint = int.Parse(inputTokens[1]);
                        for (int j = 0; j < indexToPrint; j++)
                        {
                            if (j == indexToPrint - 1)
                            {
                                Console.WriteLine(text[j]);
                            }
                        }              
                        break;

                    case "4":
                        text = previousStateOfText.Pop();
                        break;
                }
            }
        }
    }
}
