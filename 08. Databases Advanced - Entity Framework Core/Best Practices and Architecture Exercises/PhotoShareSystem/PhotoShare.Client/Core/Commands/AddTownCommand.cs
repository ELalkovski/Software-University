namespace PhotoShare.Client.Core.Commands
{
    using System;
    using System.Collections.Generic;
    using Microsoft.Extensions.DependencyInjection;
    using PhotoShare.Client.Core.Contracts;
    using PhotoShare.Services.Contracts;

    public class AddTownCommand : ICommand
    {
        // AddTown <townName> <countryName>
        public string Execute(List<string> data, IServiceProvider serviceProvider)
        {
            ITownService townService = serviceProvider.GetService<ITownService>();
            string result = townService.AddTown(data[0], data[1]);

            return result;
        }
    }
}
