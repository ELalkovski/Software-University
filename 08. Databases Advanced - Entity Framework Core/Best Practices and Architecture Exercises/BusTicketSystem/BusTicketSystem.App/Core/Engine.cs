namespace BusTicketSystem.App.Core
{
    using BusTicketSystem.App.Core.Contracts;
    using BusTicketSystem.Data;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;

    public class Engine
    {
        private const string CommandSuffix = "Command";

        private readonly BusStationDbContext db;

        public Engine()
        {
        }

        public Engine(BusStationDbContext db)
        {
            this.db = db;
        }

        public void Run()
        {
            while (true)
            {
                List<string> commandTokens = Console.ReadLine()
                .Split()
                .ToList();

                string commandName = commandTokens[0];
                commandTokens.RemoveAt(0);
                ICommand command = this.ParseCommand(commandName);

                try
                {
                    string result = command.Execute(db, commandTokens);
                    Console.WriteLine(result);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }             
            }            
        }

        private ICommand ParseCommand(string commandName)
        {
            Type commandType = Assembly
                .GetExecutingAssembly()
                .GetTypes()
                .FirstOrDefault(t => t.Name.Equals(commandName + CommandSuffix));

            ICommand command = (ICommand)Activator.CreateInstance(commandType, new object[] { });

            return command;
        }
    }
}
