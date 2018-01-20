namespace BusTicketSystem.App.Core.Commands
{
    using System.Collections.Generic;
    using BusTicketSystem.App.Core.Contracts;
    using BusTicketSystem.Data;
    using BusTicketSystem.Models;
    using Microsoft.EntityFrameworkCore;
    using System.Linq;
    using System;
    using System.Text;

    public class PrintReviewsCommand : ICommand
    {
        public string Execute(BusStationDbContext db, List<string> data)
        {
            int companyId = int.Parse(data[0]);

            BusCompany company = db.BusCompanies
                .Include(bc => bc.Reviews)
                .ThenInclude(r => r.Customer)
                .FirstOrDefault(bc => bc.Id == companyId);

            if (company == null)
            {
                throw new ArgumentException("Company not found!");
            }

            StringBuilder sb = new StringBuilder();

            foreach (var review in company.Reviews)
            {
                sb.AppendLine($"{review.Id} {review.Grade} {review.PublishingDate}");
                sb.AppendLine($"{review.Customer.FirstName + " " + review.Customer.LastName}");
                sb.AppendLine($"{review.Content}");
            }

            return sb.ToString().Trim();
        }
    }
}
