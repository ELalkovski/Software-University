namespace PhotoShare.Services
{
    using System;
    using System.Linq;
    using System.Text;
    using Microsoft.EntityFrameworkCore;
    using PhotoShare.Data;
    using PhotoShare.Models;
    using PhotoShare.Services.Contracts;
    using PhotoShare.Services.IO;

    public class FriendService : IFriendService
    {
        private readonly PhotoShareContext db;

        public FriendService()
        {
            
        }

        public FriendService(PhotoShareContext db)
        {
            this.db = db;
        }

        public string AddFriend(string firstUsername, string secondUsername)
        {
            if (Session.LoggedUser == null)
            {
                throw new InvalidOperationException(Messages.InvalidCreditentials);
            }

            if (Session.LoggedUser.Username != firstUsername)
            {
                throw new InvalidOperationException(Messages.InvalidCreditentials);
            }

            if (!this.db.Users.Any(u => u.Username.Equals(firstUsername)))
            {
                throw new ArgumentException(string.Format(Messages.UsernameNotFound, firstUsername));
            }

            if (!this.db.Users.Any(u => u.Username.Equals(secondUsername)))
            {
                throw new ArgumentException(string.Format(Messages.UsernameNotFound, secondUsername));
            }

            User firstUser = this.db
                .Users
                .Include(u => u.FriendsAdded)
                .ThenInclude(fa => fa.Friend)
                .FirstOrDefault(u => u.Username.Equals(firstUsername));

            User secondUser = this.db
                .Users
                .Include(u => u.FriendsAdded)
                .ThenInclude(fa => fa.Friend)
                .FirstOrDefault(u => u.Username.Equals(secondUsername));
            
            bool alreadyAdded = firstUser
                .FriendsAdded
                .Any(u => u.Friend.Username.Equals(secondUsername));

            bool accepted = secondUser
                .FriendsAdded
                .Any(u => u.Friend.Username.Equals(firstUsername));


            if (alreadyAdded && !accepted)
            {
                throw new InvalidOperationException(Messages.RequestSent);
            }

            if (alreadyAdded && accepted)
            {
                throw new InvalidOperationException(string.Format(Messages.ExistingFriend, secondUsername, firstUsername));
            }

            firstUser.FriendsAdded.Add(new Friendship
            {
                User = firstUser,
                Friend = secondUser
            });

            this.db.SaveChanges();

            return string.Format(Messages.FriendAddedSuccessfully, secondUsername, firstUsername);
        }

        public string AcceptFriend(string firstUsername, string secondUsername)
        {
            if (Session.LoggedUser == null)
            {
                throw new InvalidOperationException(Messages.InvalidCreditentials);
            }

            if (Session.LoggedUser.Username != firstUsername)
            {
                throw new InvalidOperationException(Messages.InvalidCreditentials);
            }

            if (!this.db.Users.Any(u => u.Username.Equals(firstUsername)))
            {
                throw new ArgumentException(string.Format(Messages.UsernameNotFound, firstUsername));
            }

            if (!this.db.Users.Any(u => u.Username.Equals(secondUsername)))
            {
                throw new ArgumentException(string.Format(Messages.UsernameNotFound, secondUsername));
            }

            User firstUser = this.db
                .Users
                .Include(u => u.FriendsAdded)
                .ThenInclude(fa => fa.Friend)
                .FirstOrDefault(u => u.Username.Equals(firstUsername));

            User secondUser = this.db
                .Users
                .Include(u => u.FriendsAdded)
                .ThenInclude(fa => fa.Friend)
                .FirstOrDefault(u => u.Username.Equals(secondUsername));

            bool alreadyAdded = secondUser
                .FriendsAdded
                .Any(u => u.Friend.Username.Equals(firstUsername));

            bool accepted = firstUser
                .FriendsAdded
                .Any(u => u.Friend.Username.Equals(secondUsername));

            if (alreadyAdded && accepted)
            {
                throw new InvalidOperationException(string.Format(Messages.ExistingFriend, secondUsername, firstUsername));
            }

            if (!alreadyAdded)
            {
                throw new InvalidOperationException(string.Format(Messages.NoRequest, secondUsername, firstUsername));
            }

            firstUser.FriendsAdded.Add(new Friendship
            {
                User = firstUser,
                Friend = secondUser
            });

            this.db.SaveChanges();

            return string.Format(Messages.FriendshipAccepted, firstUsername, secondUsername);
        }

        public string ListFriends(string username)
        {
            User user = this.db
                .Users
                .Include(u => u.FriendsAdded)
                .ThenInclude(fa => fa.Friend)
                .FirstOrDefault(u => u.Username.Equals(username));

            if (!this.db.Users.Any(u => u.Username.Equals(username)))
            {
                throw new ArgumentException(string.Format(Messages.UsernameNotFound, username));
            }

            if (user.FriendsAdded.Count == 0)
            {
                throw new ArgumentException(Messages.NoFriends);
            }

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Friends:");

            foreach (var friend in user.FriendsAdded)
            {
                sb.AppendLine($"-{friend.Friend.Username}");
            }

            return sb.ToString().Trim();
        }
    }
}
