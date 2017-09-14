namespace Boolean_Variable
{
    using System;

    public class BoolVariable
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            bool isTrue = bool.Parse(input);
            
            if (isTrue)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
