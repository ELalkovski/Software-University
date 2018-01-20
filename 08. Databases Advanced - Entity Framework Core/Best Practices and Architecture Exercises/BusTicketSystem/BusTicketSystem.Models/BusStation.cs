namespace BusTicketSystem.Models
{
    using System.Collections.Generic;

    public class BusStation
    {
        public BusStation()
        {
        }

        public BusStation(string name, Town town)
        {
            this.Name = name;
            this.Town = town;
            this.Arrivals = new List<Trip>();
            this.Departures = new List<Trip>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public int TownId { get; set; }
        public Town Town { get; set; }

        public ICollection<Trip> Arrivals { get; set; }

        public ICollection<Trip> Departures { get; set; }
    }
}
