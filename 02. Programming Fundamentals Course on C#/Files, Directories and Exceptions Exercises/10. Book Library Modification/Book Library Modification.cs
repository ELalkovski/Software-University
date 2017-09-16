namespace _10.Book_Library_Modification
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.IO;
    using System.Globalization;

    public class BookLibraryModified
    {
        public static void Main()
        {
            string[] input = File.ReadAllLines("Input.txt");
            int inputLinesQuantity = int.Parse(input[0]);
            DateTime startDate = DateTime.ParseExact(input[6], "dd.MM.yyyy", CultureInfo.InvariantCulture);

            Library allBooks = new Library();
            List<Book> listOfBooks = new List<Book>();

            for (int i = 1; i <= inputLinesQuantity; i++)
            {
                Book book = new Book();
                List<string> currInput = input[i]
                    .Split(' ')
                    .ToList();

                book.Title = currInput[0];
                book.Author = currInput[1];
                book.Publisher = currInput[2];
                book.ReleaseDate = DateTime.ParseExact(currInput[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);
                book.Isbn = currInput[4];
                book.Price = double.Parse(currInput[5]);

                listOfBooks.Add(book);

            }

            allBooks.Name = "Library";
            allBooks.Books = listOfBooks;

            Dictionary<string, DateTime> titleByReleaseDate = new Dictionary<string, DateTime>();

            foreach (var title in listOfBooks)
            {
                if (title.ReleaseDate > startDate)
                {
                    if (!titleByReleaseDate.ContainsKey(title.Title))
                    {
                        titleByReleaseDate.Add(title.Title, title.ReleaseDate);
                    }
                    else
                    {
                        titleByReleaseDate[title.Title] = title.ReleaseDate;
                    }
                }
                
            }

            foreach (var title in titleByReleaseDate.OrderBy(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine("{0} -> {1}", title.Key, title.Value.ToString("dd.MM.yyyy"));
                File.AppendAllText("Output.txt", title.Key + " -> " + title.Value.ToString("dd.MM.yyyy") + Environment.NewLine);
            }
        }
    }
}
