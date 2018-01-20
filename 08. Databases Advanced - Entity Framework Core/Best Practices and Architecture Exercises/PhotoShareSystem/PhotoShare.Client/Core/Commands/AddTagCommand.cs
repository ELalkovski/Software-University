namespace PhotoShare.Client.Core.Commands
{
    using System;
    using System.Collections.Generic;
    using Microsoft.Extensions.DependencyInjection;
    using PhotoShare.Client.Core.Contracts;
    using PhotoShare.Services.Contracts;

    public class AddTagCommand : ICommand
    {
        // AddTag <tag>
        public string Execute(List<string> data, IServiceProvider serviceProvider)
        {
            ITagService tagService = serviceProvider.GetService<ITagService>();
            string result = tagService.AddTag(data[0]);

            return result;
        }
    }
}
