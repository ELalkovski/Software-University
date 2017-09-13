using System;
using System.Linq;

namespace _01.Action_Print
{
    public class ActionPrint
    {
        public static void Main()
        {
            var inputNames = Console.ReadLine()
                .Split(new []{' '}, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            Action<string> print = s => Console.WriteLine(s);

            inputNames.ForEach(print);

        }

        
    }
}
