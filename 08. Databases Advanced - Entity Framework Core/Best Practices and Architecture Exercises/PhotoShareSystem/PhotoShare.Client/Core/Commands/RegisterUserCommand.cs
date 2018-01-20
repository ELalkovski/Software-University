namespace PhotoShare.Client.Core.Commands
{
    using System;
    using System.Collections.Generic;
    using Microsoft.Extensions.DependencyInjection;
    using PhotoShare.Client.Core.Contracts;
    using PhotoShare.Services.Contracts;

    public class RegisterUserCommand : ICommand
    {
        public string Execute(List<string> data, IServiceProvider serviceProvider)
        {
            IUserService userService = serviceProvider.GetService<IUserService>();
            string result = userService.RegisterUser(data[0], data[1], data[2], data[3]);

            return result;
        }
    }
}
