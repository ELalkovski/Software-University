namespace BusTicketSystem.Models
{
    using System.Collections.Generic;

    public class Town
    {
        public Town()
        {
        }

        public Town(string name, string country)
        {
            this.Name = name;
            this.Country = country;
            this.BusStations = new List<BusStation>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public string Country { get; set; }

        public ICollection<BusStation> BusStations { get; set; }
    }
}
