namespace BusTicketSystem.App.Core.Contracts
{
    using BusTicketSystem.Data;
    using System.Collections.Generic;

    public interface ICommand
    {
        string Execute(BusStationDbContext db, List<string> data);
    }
}
