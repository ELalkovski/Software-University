namespace PhotoShare.Client.Core.Commands
{
    using System;
    using System.Collections.Generic;
    using Microsoft.Extensions.DependencyInjection;
    using PhotoShare.Client.Core.Contracts;
    using PhotoShare.Services.Contracts;

    public class AddTagToCommand : ICommand
    {
        // AddTagTo <albumName> <tag>

        public string Execute(List<string> data, IServiceProvider serviceProvider)
        {
            ITagService tagService = serviceProvider.GetService<ITagService>();
            string result = tagService.AddTagTo(data[0], data[1]);

            return result;
        }
    }
}
