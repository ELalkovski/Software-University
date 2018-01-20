namespace PhotoShare.Client.Core.Commands
{
    using System;
    using System.Collections.Generic;
    using Microsoft.Extensions.DependencyInjection;
    using PhotoShare.Client.Core.Contracts;
    using PhotoShare.Services.Contracts;

    public class CreateAlbumCommand : ICommand
    {
        // CreateAlbum <username> <albumTitle> <BgColor> <tag1> <tag2>...<tagN>
        public string Execute(List<string> data, IServiceProvider serviceProvider)
        {
            IAlbumService albumService = serviceProvider.GetService<IAlbumService>();
            string username = data[0];
            string albumTitle = data[1];
            string color = data[2];

            data.RemoveAt(0);
            data.RemoveAt(0);
            data.RemoveAt(0);

            string[] tags = data.ToArray();

            string result = albumService.CreateAlbum(username, albumTitle, color, tags);

            return result;
        }
    }
}
