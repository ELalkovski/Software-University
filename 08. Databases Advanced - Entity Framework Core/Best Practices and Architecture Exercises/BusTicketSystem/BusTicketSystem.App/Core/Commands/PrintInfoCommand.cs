namespace BusTicketSystem.App.Core.Commands
{
    using System.Collections.Generic;
    using BusTicketSystem.App.Core.Contracts;
    using BusTicketSystem.Data;
    using System.Linq;
    using System.Text;
    using Microsoft.EntityFrameworkCore;

    public class PrintInfoCommand : ICommand
    {
        public string Execute(BusStationDbContext db, List<string> data)
        {
            int id = int.Parse(data[0]);

            var busStation = db.BusStations
                .Include(bs => bs.Arrivals)
                .ThenInclude(a => a.OriginBusStation)
                .Include(bs => bs.Departures)
                .ThenInclude(a => a.DestinationBusStation)
                .Include(bs => bs.Town)
                .FirstOrDefault(bs => bs.Id == id);

            var sb = new StringBuilder();

            sb.AppendLine($"{busStation.Name}, {busStation.Town.Name}");
            sb.AppendLine("Arrivals:");

            foreach (var arrival in busStation.Arrivals)
            {
                sb.AppendLine($"From {arrival.OriginBusStation.Name} | Arrive at: {arrival.ArrivalTime} | Status: {arrival.Status}");
            }

            sb.AppendLine("Departures:");

            foreach (var departure in busStation.Departures)
            {
                sb.AppendLine($"To {departure.DestinationBusStation.Name} | Depart at: {departure.DepartureTime} | Status: {departure.Status}");
            }

            return sb.ToString().Trim();
        }
    }
}
