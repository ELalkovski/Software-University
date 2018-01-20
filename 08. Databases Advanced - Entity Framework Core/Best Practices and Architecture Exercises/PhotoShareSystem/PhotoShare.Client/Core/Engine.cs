namespace PhotoShare.Client.Core
{
    using System;

    public class Engine
    {
        private readonly CommandDispatcher commandDispatcher;
        private readonly IServiceProvider serviceProvider;

        public Engine(CommandDispatcher commandDispatcher, IServiceProvider serviceProvider)
        {
            this.commandDispatcher = commandDispatcher;
            this.serviceProvider = serviceProvider;
        }

        public void Run()
        {
            while (true)
            {
                try
                {
                    string input = Console.ReadLine().Trim();
                    string[] data = input.Split(' ');
                    string result = this.commandDispatcher.DispatchCommand(data, this.serviceProvider);

                    Console.WriteLine(result);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
