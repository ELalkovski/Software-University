namespace PhotoShare.Client.Core.Commands
{
    using System;
    using System.Collections.Generic;
    using PhotoShare.Client.Core.Contracts;

    public class ExitCommand : ICommand
    {
        public string Execute(List<string> data, IServiceProvider serviceProvider)
        {
            Environment.Exit(0);
            return "Bye-bye!";
        }
    }
}
