namespace _09.Collection_Hierarchy.Interfaces
{
    using System.Collections.Generic;

    public interface IAddable
    {
        IList<string> Collection { get; }

        string AddItem(string item);
    }
}
