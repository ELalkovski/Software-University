namespace _05.Date_Modifier
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            string firstDate = Console.ReadLine();
            string secondDate = Console.ReadLine();

            DateModifier dateModifier = new DateModifier(firstDate, secondDate);

            Console.WriteLine(dateModifier.CalculateDays());
        }
    }
}
