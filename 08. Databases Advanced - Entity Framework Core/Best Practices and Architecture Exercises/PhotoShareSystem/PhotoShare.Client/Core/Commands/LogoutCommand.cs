namespace PhotoShare.Client.Core.Commands
{
    using System;
    using System.Collections.Generic;
    using Microsoft.Extensions.DependencyInjection;
    using PhotoShare.Client.Core.Contracts;
    using PhotoShare.Services.Contracts;

    public class LogoutCommand : ICommand
    {
        public string Execute(List<string> data, IServiceProvider serviceProvider)
        {
            IUserService userService = serviceProvider.GetService<IUserService>();
            string result = userService.Logout();

            return result;
        }
    }
}
