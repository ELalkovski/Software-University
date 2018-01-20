namespace PhotoShare.Services
{
    using System;
    using System.Linq;
    using PhotoShare.Data;
    using PhotoShare.Models;
    using PhotoShare.Services.Contracts;
    using PhotoShare.Services.IO;

    public class UserService : IUserService
    {
        private readonly PhotoShareContext db;

        public UserService()
        {
            
        }

        public UserService(PhotoShareContext db)
        {
            this.db = db;
        }

        public string Login(string username, string password)
        {
            User user = this.db.Users
                .FirstOrDefault(u => u.Username.Equals(username));

            if (user == null || user.Password != password)
            {
                throw new ArgumentException(Messages.InvalidLoginCreditentials);
            }

            if (Session.LoggedUser != null)
            {
                throw new ArgumentException(Messages.AlreadyLogedIn);
            }

            Session.LoggedUser = user;

            return string.Format(Messages.SuccessfullLogin, username);
        }

        public string Logout()
        {
            if (Session.LoggedUser == null)
            {
                throw new ArgumentException(Messages.NotLoggedin);
            }

            string username = Session.LoggedUser.Username;
            Session.LoggedUser = null;

            return string.Format(Messages.SuccessfullLogout, username);
        }

        public string RegisterUser(string username, string password, string repeatPassword, string email)
        {
            if (this.db.Users.Any(u => u.Username.Equals(username)))
            {
                throw new ArgumentException(string.Format(Messages.ExistingUsername, username));
            }

            if (password != repeatPassword)
            {
                throw new ArgumentException(Messages.WrongPassword);
            }

            User user = new User (username, password, email);

            this.db.Users.Add(user);
            this.db.SaveChanges();

            string result = string.Format(Messages.UserAddedSuccessfully, username);

            return result;
        }

        public string ModifyUser(string username, string propertyName, string newPropertyValue)
        {
            if (Session.LoggedUser == null)
            {
                throw new InvalidOperationException(Messages.InvalidCreditentials);
            }

            if (!Session.LoggedUser.Username.Equals(username))
            {
                throw new InvalidOperationException(Messages.InvalidCreditentials);
            }

            if (!this.db.Users.Any(u => u.Username.Equals(username)))
            {
                throw new ArgumentException(string.Format(Messages.UsernameNotFound, username));
            }

            switch (propertyName)
            {
                case "Password":
                    this.db.Users
                        .FirstOrDefault(u => u.Username.Equals(username))
                        .Password = newPropertyValue;
                    break;
                case "BornTown":
                    if (!this.db.Towns.Any(t => t.Name.Equals(newPropertyValue)))
                    {
                        throw new ArgumentException(string.Format(Messages.TownNotFound, newPropertyValue));
                    }

                    this.db.Users
                        .FirstOrDefault(u => u.Username.Equals(username))
                        .BornTown = new Town {Name = newPropertyValue};
                    break;
                case "CurrentTown":
                    if (!this.db.Towns.Any(t => t.Name.Equals(newPropertyValue)))
                    {
                        throw new ArgumentException(string.Format(Messages.TownNotFound, newPropertyValue));
                    }

                    this.db.Users
                        .FirstOrDefault(u => u.Username.Equals(username))
                        .CurrentTown = new Town { Name = newPropertyValue};
                    break;

                default:
                    throw new ArgumentException(string.Format(Messages.PropertyNotSupported, propertyName));
            }

            this.db.SaveChanges();

            return string.Format(Messages.UserModifiedSuccessfully, username, propertyName, newPropertyValue);
        }

        public string DeleteUser(string username)
        {
            if (Session.LoggedUser == null)
            {
                throw new InvalidOperationException(Messages.InvalidCreditentials);
            }

            if (!Session.LoggedUser.Username.Equals(username))
            {
                throw new InvalidOperationException(Messages.InvalidCreditentials);
            }

            User user = this.db
                .Users
                .FirstOrDefault(u => u.Username.Equals(username));

            if (user == null)
            {
                throw new ArgumentException(string.Format(Messages.UsernameNotFound, username));
            }

            if (user.IsDeleted.Value)
            {
                throw new InvalidOperationException(string.Format(Messages.UserAlreadyDeleted, username));
            }

            user.IsDeleted = true;
            this.db.SaveChanges();

            return string.Format(Messages.UserDeleted, username);
        }

    }
}
