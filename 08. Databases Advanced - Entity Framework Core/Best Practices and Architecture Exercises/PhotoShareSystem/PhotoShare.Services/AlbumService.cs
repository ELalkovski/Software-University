namespace PhotoShare.Services
{
    using System;
    using System.Linq;
    using PhotoShare.Data;
    using PhotoShare.Models;
    using PhotoShare.Services.Contracts;
    using PhotoShare.Services.IO;

    public class AlbumService : IAlbumService
    {
        private readonly PhotoShareContext db;
        private readonly ITagService tagService;

        public AlbumService()
        {
            
        }

        public AlbumService(PhotoShareContext db, ITagService tagService)
        {
            this.db = db;
            this.tagService = tagService;
        }

        public string CreateAlbum(string username, string albumTitle, string color, params string[] tags)
        {
            if (Session.LoggedUser == null)
            {
                throw new InvalidOperationException(Messages.InvalidCreditentials);
            }

            if (Session.LoggedUser.Username != username)
            {
                throw new InvalidOperationException(Messages.InvalidCreditentials);
            }

            if (!this.db.Users.Any(u => u.Username.Equals(username)))
            {
                throw new ArgumentException(string.Format(Messages.UsernameNotFound, username));
            }

            if (this.db.Albums.Any(a => a.Name.Equals(albumTitle)))
            {
                throw new ArgumentException(string.Format(Messages.ExistingAlbum, albumTitle));
            }

            if (!this.db.Tags.Any(t => tags.Contains(t.Name)))
            {
                throw new ArgumentException(string.Format(Messages.UnexistingTag));
            }

            Color currentColor;

            if (!Color.TryParse(color, true, out currentColor))
            {
                throw new ArgumentException(string.Format(Messages.UnexistingColor, color));
            }

            Album album = new Album(albumTitle);
            album.BackgroundColor = currentColor;
            this.db.Albums.Add(album);
            this.db.SaveChanges();

            foreach (var tag in tags)
            {
                this.tagService.AddTagTo(albumTitle, tag);
            }

            this.db.SaveChanges();

            return string.Format(Messages.AlbumAddedSuccessfully, albumTitle);
        }

        public string UploadPicture(string albumName, string pictureTitle, string pictureFilePath)
        {
            if (Session.LoggedUser == null)
            {
                throw new InvalidOperationException(Messages.InvalidCreditentials);
            }

            if (!Session.LoggedUser.AlbumRoles.Any(ar => ar.Album.Name.Equals(albumName)))
            {
                throw new InvalidOperationException(Messages.InvalidCreditentials);
            }

            if (!this.db.Albums.Any(a => a.Name.Equals(albumName)))
            {
                throw new ArgumentException(string.Format(Messages.UnexistingAlbum, albumName));
            }

            Picture picture = new Picture(pictureTitle, pictureFilePath);

            this.db.Albums
                .FirstOrDefault(a => a.Name.Equals(albumName))
                .Pictures
                .Add(picture);

            this.db.SaveChanges();

            return string.Format(Messages.PictureAddedSuccessfully, pictureTitle, albumName);
        }

        public string ShareAlbum(int albumId, string username, string permission)
        {
            if (Session.LoggedUser == null)
            {
                throw new InvalidOperationException(Messages.InvalidCreditentials);
            }

            if (Session.LoggedUser.AlbumRoles.All(ar => ar.Album.Id != albumId))
            {
                throw new InvalidOperationException(Messages.InvalidCreditentials);
            }

            if (!this.db.Users.Any(u => u.Username.Equals(username)))
            {
                throw new ArgumentException(string.Format(Messages.UsernameNotFound, username));
            }

            if (!this.db.Albums.Any(a => a.Id == albumId))
            {
                throw new ArgumentException(Messages.UnexistingAlbum, albumId.ToString());
            }

            if (!permission.Equals("Owner") || !permission.Equals("Viewer"))
            {
                throw new ArgumentException(Messages.WrongPermission);
            }

            return string.Format(Messages.AlbumShared, username, albumId, permission);
        }
    }
}
