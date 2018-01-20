namespace BusTicketSystem.Models
{
    using BusTicketSystem.Models.Enums;
    using System;
    using System.Collections.Generic;

    public class Customer
    {
        public Customer()
        {
        }

        public Customer(string firstName, string lastName, string birthDate, string gender, Town homeTown)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.BirthDate = DateTime.Parse(birthDate);
            this.Gender = (Gender)Enum.Parse(typeof(Gender), gender);
            this.HomeTown = homeTown;
            this.Reviews = new List<Review>();
            this.TicketsBought = new List<Ticket>();
        }

        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime BirthDate { get; set; }

        public Gender Gender { get; set; }

        public int HomeTownId { get; set; }
        public Town HomeTown { get; set; }

        public int? BankAccountId { get; set; }
        public BankAccount BankAccount { get; set; }

        public ICollection<Ticket> TicketsBought { get; set; }

        public ICollection<Review> Reviews { get; set; }
    }
}
