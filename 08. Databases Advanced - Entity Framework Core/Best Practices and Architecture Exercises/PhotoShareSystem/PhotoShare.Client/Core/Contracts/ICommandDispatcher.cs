namespace PhotoShare.Client.Core.Contracts
{
    using System;

    public interface ICommandDispatcher
    {
        string DispatchCommand(string[] commandParameters, IServiceProvider serviceProvider);
    }
}
