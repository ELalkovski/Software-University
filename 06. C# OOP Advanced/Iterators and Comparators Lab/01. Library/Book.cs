﻿using System.Collections.Generic;

public class Book : IBook
{
    private string title;
    private int year;
    private List<string> authors;

    public Book(string title, int year, params string[] authors)
    {
        this.title = title;
        this.year = year;
        this.SetAuthors(authors);
    }

    public string Title
    {
        get { return title; }
    }

    public int Year
    {
        get { return year; }
    }

    public IList<string> Authors
    {
        get { return authors.AsReadOnly(); }
    }

    private void SetAuthors(params string[] authors)
    {
        this.authors = new List<string>();

        if (authors.Length > 0)
        {
            foreach (var author in authors)
            {
                this.authors.Add(author);
            }
        }
    }
}
