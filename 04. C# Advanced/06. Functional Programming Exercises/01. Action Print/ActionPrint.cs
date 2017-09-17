namespace _01.Action_Print
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ActionPrint
    {
        public static void Main()
        {
            List<string> inputNames = Console.ReadLine()
                .Split(new []{' '}, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            Action<string> print = s => Console.WriteLine(s);

            inputNames.ForEach(print);
        }
    }
}
