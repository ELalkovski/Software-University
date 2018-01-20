namespace BusTicketSystem.Models
{
    using System.Collections.Generic;

    public class BusCompany
    {
        public BusCompany()
        {
        }

        public BusCompany(string name, string nationality, decimal rating)
        {
            this.Name = name;
            this.Nationality = nationality;
            this.Rating = rating;
            this.Trips = new List<Trip>();
            this.Reviews = new List<Review>();            
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public string Nationality { get; set; }

        public decimal Rating { get; set; }

        public ICollection<Trip> Trips { get; set; }

        public ICollection<Review> Reviews { get; set; }        
    }
}
