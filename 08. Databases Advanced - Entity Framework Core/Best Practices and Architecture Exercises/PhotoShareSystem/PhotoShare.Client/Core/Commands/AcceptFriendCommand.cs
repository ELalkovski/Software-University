namespace PhotoShare.Client.Core.Commands
{
    using System;
    using System.Collections.Generic;
    using Microsoft.Extensions.DependencyInjection;
    using PhotoShare.Client.Core.Contracts;
    using PhotoShare.Services.Contracts;

    public class AcceptFriendCommand : ICommand
    {
        // AcceptFriend <username1> <username2>
        public string Execute(List<string> data, IServiceProvider serviceProvider)
        {
            IFriendService friendService = serviceProvider.GetService<IFriendService>();
            string result = friendService.AcceptFriend(data[0], data[1]);

            return result;
        }
    }
}
