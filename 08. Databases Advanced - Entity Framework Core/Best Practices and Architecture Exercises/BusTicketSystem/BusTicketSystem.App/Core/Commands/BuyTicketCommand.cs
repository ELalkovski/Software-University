namespace BusTicketSystem.App.Core.Commands
{
    using System.Collections.Generic;
    using BusTicketSystem.App.Core.Contracts;
    using BusTicketSystem.Data;
    using BusTicketSystem.Models;
    using System.Linq;
    using System;
    using Microsoft.EntityFrameworkCore;
    using System.Globalization;

    public class BuyTicketCommand : ICommand
    {
        public string Execute(BusStationDbContext db, List<string> data)
        {
            int customerId = int.Parse(data[0]);
            int tripId = int.Parse(data[1]);
            //var numberFormatInfo = new NumberFormatInfo { NumberDecimalSeparator = "," };
            decimal price = decimal.Parse(data[2]);
            int seat = int.Parse(data[3]);

            Customer customer = db.Customers
                .Include(c => c.BankAccount)
                .Include(c => c.TicketsBought)
                .FirstOrDefault(c => c.Id == customerId);

            Trip trip = db.Trips
                .FirstOrDefault(t => t.Id == tripId);

            if (customer == null)
            {
                throw new ArgumentException("Customer not found!");
            }

            if (trip == null)
            {
                throw new ArgumentException("Trip not found!");
            }

            if (customer.BankAccount.Balance < price)
            {
                throw new ArgumentException("Not enough money to buy this ticket!");
            }

            customer.BankAccount.Balance -= price;
            customer.TicketsBought.Add(new Ticket(price, seat, customer, trip));
            db.SaveChanges();

            return $"Customer {customer.FirstName + " " + customer.LastName} bought ticket for trip {trip.Id} for {price} on seat {seat}";
        }
    }
}
