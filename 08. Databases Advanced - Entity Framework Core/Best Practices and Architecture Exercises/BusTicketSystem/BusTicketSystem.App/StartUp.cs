namespace BusTicketSystem.App
{
    using BusTicketSystem.Data;
    using BusTicketSystem.Models;
    using BusTicketSystem.App.Core;
    using BusTicketSystem.Models.Enums;

    public class StartUp
    {
        public static void Main()
        {
            using (var db = new BusStationDbContext())
            {
                var engine = new Engine(db);
                engine.Run();
            }
           
        }

        private static void ResetDatabase(BusStationDbContext db)
        {
            db.Database.EnsureDeleted();
            db.Database.EnsureCreated();
            Seed(db);
        }

        private static void Seed(BusStationDbContext db)
        {
            BusCompany[] busCompanies = new BusCompany[]
            {
                new BusCompany("TransportLTD", "Bulgarian", 5.6m),
                new BusCompany("CrazyDrivers", "Egyptian", 3.3m),
                new BusCompany("DrivingMonsters", "British", 7.4m),
                new BusCompany("HellOnWheels", "Greek", 1.6m),
                new BusCompany("BusHobbits", "Bulgarian", 10.0m),
            };
            db.BusCompanies.AddRange(busCompanies);
            db.SaveChanges();

            Town[] towns = new Town[]
            {
                new Town("Sofia", "Bulgaria"),
                new Town("Burgas", "Bulgaria"),
                new Town("London", "England"),
                new Town("Paris", "France"),
                new Town("Berlin", "Germany"),
            };
            db.Towns.AddRange(towns);
            db.SaveChanges();

            Customer[] customers = new Customer[]
            {
                new Customer("Pesho", "Peshev", "01.01.1994", "Male", towns[0]),
                new Customer("Gosho", "Peshev", "11.08.1980", "Male", towns[0]),
                new Customer("Stamat", "Rashkov", "15.12.1991", "Male", towns[0]),
                new Customer("Gergana", "Ludneva", "01.01.1994", "Female", towns[0]),
                new Customer("Boko", "Borisov", "01.01.1994", "NotSpecified", towns[0]),
            };
            db.Customers.AddRange(customers);
            db.SaveChanges();

            BankAccount[] bankAccounts = new BankAccount[]
            {
                new BankAccount("1221453666", 2000.00m, customers[0]),
                new BankAccount("1223567365", 2500.00m, customers[1]),
                new BankAccount("4567453633", 3400.00m, customers[2]),
                new BankAccount("1445756907", 1500.00m, customers[3]),
                new BankAccount("1224365798", 3300.00m, customers[4]),
            };
            db.BankAccounts.AddRange(bankAccounts);
            db.SaveChanges();

            int index = 0;

            foreach (var customer in db.Customers)
            {
                customer.BankAccount = bankAccounts[index];
                customer.BankAccountId = bankAccounts[index].Id;
                index++;
            }

            db.SaveChanges();

            BusStation[] busStations = new BusStation[]
            {
                new BusStation("Централна Автогара", towns[0]),
                new BusStation("Автогара Юг", towns[1]),
                new BusStation("Central Bus Station", towns[2]),
                new BusStation("GoGo Station", towns[2]),
                new BusStation("Berliner AutoStation", towns[4]),
            };
            db.BusStations.AddRange(busStations);
            db.SaveChanges();

            Trip[] trips = new Trip[]
            {
                new Trip("11.05.2017 / 10:00", "11.05.2017 / 16:00", busStations[0], busStations[1], busCompanies[0]),
                new Trip("11.05.2017 / 09:00", "13.05.2017 / 13:00", busStations[0], busStations[4], busCompanies[0]),
                new Trip("11.05.2017 / 22:00", "12.05.2017 / 05:00", busStations[0], busStations[1], busCompanies[0]),
                new Trip("08.12.2017 / 10:00", "13.05.2017 / 16:00", busStations[2], busStations[0], busCompanies[2]),
                new Trip("01.01.2017 / 15:00", "02.01.2017 / 00:00", busStations[3], busStations[2], busCompanies[2]),
            };
            db.Trips.AddRange(trips);
            db.SaveChanges();

            foreach (var trip in db.Trips)
            {
                trip.Status = Status.Delayed;
            }

            db.SaveChanges();
        }
    }
}
