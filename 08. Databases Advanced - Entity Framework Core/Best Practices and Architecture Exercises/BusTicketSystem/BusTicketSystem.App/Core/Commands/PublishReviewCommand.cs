namespace BusTicketSystem.App.Core.Commands
{
    using System.Collections.Generic;
    using BusTicketSystem.App.Core.Contracts;
    using BusTicketSystem.Data;
    using BusTicketSystem.Models;
    using Microsoft.EntityFrameworkCore;
    using System.Linq;
    using System;

    public class PublishReviewCommand : ICommand
    {
        public string Execute(BusStationDbContext db, List<string> data)
        {
            int customerId = int.Parse(data[0]);
            decimal grade = decimal.Parse(data[1]);
            string busCompanyName = data[2];
            string content = data[3];

            Customer customer = db.Customers
                .Include(c => c.Reviews)
                .FirstOrDefault(c => c.Id == customerId);

            BusCompany company = db.BusCompanies
                .Include(bc => bc.Reviews)
                .FirstOrDefault(bc => bc.Name.Equals(busCompanyName));

            if (customer == null)
            {
                throw new ArgumentException("Customer not found!");
            }

            if (company == null)
            {
                throw new ArgumentException("Company not found!");
            }

            if (grade < 1 || grade > 10)
            {
                throw new ArgumentException("Invalid grade, must be between 1 and 10");
            }

            company.Reviews.Add(new Review(content, grade, company, customer));
            customer.Reviews.Add(new Review(content, grade, company, customer));
            db.SaveChanges();

            return $"Customer {customer.FirstName + " " + customer.LastName} published review for company {company.Name}";
        }
    }
}
