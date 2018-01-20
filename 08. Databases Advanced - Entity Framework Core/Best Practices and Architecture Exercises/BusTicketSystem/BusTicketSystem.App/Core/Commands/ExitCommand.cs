namespace BusTicketSystem.App.Core.Commands
{
    using System;
    using System.Collections.Generic;
    using BusTicketSystem.App.Core.Contracts;
    using BusTicketSystem.Data;

    public class ExitCommand : ICommand
    {
        public string Execute(BusStationDbContext db, List<string> data)
        {
            Environment.Exit(0);
            return "Bye-bye!";
        }
    }
}
