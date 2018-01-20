namespace PhotoShare.Services
{
    using System;
    using System.Linq;
    using Microsoft.EntityFrameworkCore;
    using PhotoShare.Data;
    using PhotoShare.Models;
    using PhotoShare.Services.Contracts;
    using PhotoShare.Services.IO;

    public class TagService : ITagService
    {
        private readonly PhotoShareContext db;

        public TagService()
        {
            
        }

        public TagService(PhotoShareContext db)
        {
            this.db = db;
        }

        public string AddTag(string tag)
        {
            if (Session.LoggedUser == null)
            {
                throw new InvalidOperationException(Messages.InvalidCreditentials);
            }

            if (this.db.Tags.Any(t => t.Name.Equals(tag)))
            {
                throw new ArgumentException(string.Format(Messages.ExistingTag, tag));
            }

            Tag currentTag = new Tag(tag);

            this.db.Tags.Add(currentTag);
            this.db.SaveChanges();

            return string.Format(Messages.TagAddedSuccessfully, tag);
        }

        public string AddTagTo(string albumTitle, string tag)
        {
            if (Session.LoggedUser == null)
            {
                throw new InvalidOperationException(Messages.InvalidCreditentials);
            }

            if (!this.db.Albums.Any(a => a.Name.Equals(albumTitle)) ||
                !this.db.Tags.Any(t => t.Name.Equals(tag)))
            {
                throw new ArgumentException(Messages.UnexistingTagOrAlbum);
            }

            Album currAlbum = this.db
                .Albums
                .Include(a => a.AlbumTags)
                .FirstOrDefault(a => a.Name.Equals(albumTitle));

            Tag currTag = this.db
                .Tags
                .FirstOrDefault(t => t.Name.Equals(tag));

            AlbumTag albumTag = new AlbumTag(currAlbum, currTag);

            currAlbum
                .AlbumTags
                .Add(albumTag);
            this.db.SaveChanges();

            return string.Format(Messages.AlbumTagAddedSuccessfully, tag, albumTitle);
        }
    }
}
