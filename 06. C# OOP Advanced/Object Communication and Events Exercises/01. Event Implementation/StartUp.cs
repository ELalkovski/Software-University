namespace _01.Event_Implementation
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            

            var input = Console.ReadLine();

            Dispatcher dispatcher = new Dispatcher();
            var handler = new Handler();
            dispatcher.NameChange += handler.OnDispatcherNameChange;

            while (input != "End")
            {
                dispatcher.Name = input;
                input = Console.ReadLine();
            }
        }
    }
}