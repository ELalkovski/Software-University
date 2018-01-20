namespace PhotoShare.Client.Core.Commands
{
    using System;
    using System.Collections.Generic;
    using Microsoft.Extensions.DependencyInjection;
    using PhotoShare.Client.Core.Contracts;
    using PhotoShare.Services.Contracts;

    public class ShareAlbumCommand : ICommand
    {
        // ShareAlbum <albumId> <username> <permission>
        // For example:
        // ShareAlbum 4 dragon321 Owner
        // ShareAlbum 4 dragon11 Viewer
        public string Execute(List<string> data, IServiceProvider serviceProvider)
        {
            IAlbumService albumService = serviceProvider.GetService<IAlbumService>();
            string result = albumService.ShareAlbum(int.Parse(data[0]), data[1], data[2]);

            return result;
        }
    }
}
