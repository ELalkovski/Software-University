using System.Collections.Generic;

public interface IBook
{
    string Title { get; }

    int Year { get; }

    IList<string> Authors { get; }
}
