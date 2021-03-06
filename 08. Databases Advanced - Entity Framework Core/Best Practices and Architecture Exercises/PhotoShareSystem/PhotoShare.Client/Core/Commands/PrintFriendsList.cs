﻿namespace PhotoShare.Client.Core.Commands
{
    using System;
    using System.Collections.Generic;
    using Microsoft.Extensions.DependencyInjection;
    using PhotoShare.Client.Core.Contracts;
    using PhotoShare.Services.Contracts;

    public class ListFriendsCommand : ICommand 
    {
        // PrintFriendsList <username>
        public string Execute(List<string> data, IServiceProvider serviceProvider)
        {
            IFriendService friendService = serviceProvider.GetService<IFriendService>();
            string result = friendService.ListFriends(data[0]);

            return result;
        }
    }
}
