namespace EmployeesSystem.App.Core
{
    using EmployeesSystem.App.Core.Contracts;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;

    public class Engine : IEngine
    {
        private const string CommandSuffix = "Command";

        private readonly IServiceProvider serviceProvider;

        public Engine()
        {
        }

        public Engine(IServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;
        }

        public void Run()
        {
            while (true)
            {
                try
                {
                    List<string> data = Console.ReadLine()
                    .Split(' ')
                    .ToList();

                    string commandName = data[0];
                    data.RemoveAt(0);

                    ICommand command = this.ParseCommand(commandName);

                    Console.WriteLine(command.Execute(data, this.serviceProvider));
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
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
