namespace PhotoShare.Client.Core
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using PhotoShare.Client.Core.Contracts;
    using PhotoShare.Services.IO;

    public class CommandDispatcher : ICommandDispatcher
    {
        private const string CommandPrefix = "Command";

        public string DispatchCommand(string[] commandParameters, IServiceProvider serviceProvider)
        {
            List<string> commandParamsToList = commandParameters.ToList();

            string commandName = commandParamsToList[0];
            commandParamsToList.RemoveAt(0);

            Type commandType = Assembly
                .GetExecutingAssembly()
                .GetTypes()
                .FirstOrDefault(t => t.Name.Equals(commandName + CommandPrefix));

            if (commandType == null)
            {
                throw new InvalidOperationException(string.Format(Messages.UnexistingCommand, commandName));
            }

            ICommand command = (ICommand) Activator.CreateInstance(commandType, new object[]{});

            string result = command.Execute(commandParamsToList, serviceProvider);

            return result;
        }
    }
}
