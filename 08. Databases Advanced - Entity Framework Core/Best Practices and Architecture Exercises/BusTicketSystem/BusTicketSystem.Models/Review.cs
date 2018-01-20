namespace BusTicketSystem.Models
{
    using System;

    public class Review
    {
        public Review()
        {
        }

        public Review(string content, decimal grade, BusCompany busCompany, Customer customer)
        {
            this.Content = content;
            this.Grade = grade;
            this.BusCompany = busCompany;
            this.Customer = customer;
            this.PublishingDate = DateTime.Now;
        }

        public int Id { get; set; }

        public string Content { get; set; }

        public decimal Grade { get; set; }

        public int BusCompanyId { get; set; }
        public BusCompany BusCompany { get; set; }

        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

        public DateTime PublishingDate { get; set; }
    }
}
