namespace PhotoShare.Services
{
    using System;
    using System.Linq;
    using PhotoShare.Data;
    using PhotoShare.Models;
    using PhotoShare.Services.Contracts;
    using PhotoShare.Services.IO;

    public class TownService : ITownService
    {
        private readonly PhotoShareContext db;

        public TownService()
        {
            
        }

        public TownService(PhotoShareContext db)
        {
            this.db = db;
        }

        public string AddTown(string townName, string countryName)
        {
            if (Session.LoggedUser == null)
            {
                throw new InvalidOperationException(Messages.InvalidCreditentials);
            }

            if (this.db.Towns.Any(t => t.Name.Equals(townName)))
            {
                throw new ArgumentException(string.Format(Messages.ExistingTown, townName));
            }

            Town town = new Town(townName, countryName);

            this.db.Towns.Add(town);
            this.db.SaveChanges();

            return string.Format(Messages.TownAddedSuccessfully, townName);
        }
    }
}
