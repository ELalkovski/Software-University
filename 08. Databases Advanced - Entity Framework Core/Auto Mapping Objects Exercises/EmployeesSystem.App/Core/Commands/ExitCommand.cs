namespace EmployeesSystem.App.Core.Commands
{
    using EmployeesSystem.App.Core.Contracts;
    using System;
    using System.Collections.Generic;

    public class ExitCommand : ICommand
    {
        public string Execute(List<string> data, IServiceProvider serviceProvider)
        {
            Environment.Exit(0);
            return "Bye-bye!";
        }
    }
}
