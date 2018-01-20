namespace PhotoShare.Client.Core.Contracts
{
    using System;
    using System.Collections.Generic;

    public interface ICommand
    {
        string Execute(List<string> data, IServiceProvider serviceProvider);
    }
}
