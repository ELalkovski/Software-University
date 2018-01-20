namespace PhotoShare.Client.Core.Commands
{
    using System;
    using System.Collections.Generic;
    using Microsoft.Extensions.DependencyInjection;
    using PhotoShare.Client.Core.Contracts;
    using PhotoShare.Services.Contracts;

    public class UploadPictureCommand : ICommand
    {
        // UploadPicture <albumName> <pictureTitle> <pictureFilePath>
        public string Execute(List<string> data, IServiceProvider serviceProvider)
        {
            IAlbumService albumService = serviceProvider.GetService<IAlbumService>();
            string result = albumService.UploadPicture(data[0], data[1], data[2]);

            return result;
        }
    }
}
