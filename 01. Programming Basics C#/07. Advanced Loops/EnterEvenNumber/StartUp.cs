namespace EnterEvenNumber
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int number = 1;

            while (!(number % 2 == 0))
            {
                try
                {
                    Console.Write("Enter even number: ");
                    number = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Invalid number!"); ;
                }
            }

            Console.WriteLine("Even number entered: {0}", number);
        }
    }
}
