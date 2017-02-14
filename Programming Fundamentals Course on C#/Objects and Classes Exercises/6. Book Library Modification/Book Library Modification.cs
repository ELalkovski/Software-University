namespace _6.Book_Library_Modification
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Globalization;

    class BookLibraryModification
    {

        public static Dictionary<string, DateTime> AddValuesToDict(Library booksByAuthor)
        {
            var datePerAuthor = new Dictionary<string, DateTime>();

            for (int i = 0; i < booksByAuthor.Books.Count; i++)
            {

                datePerAuthor[booksByAuthor.Books[i].Title] = booksByAuthor.Books[i].ReleaseDate;

            }

            return datePerAuthor;
        }

        public static void PrintResults(Dictionary<string, DateTime> datePerAuthor, DateTime releaseDate)
        {
            foreach (var author in datePerAuthor.Where(x => x.Value > releaseDate).OrderBy(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine("{0} -> {1}", author.Key, author.Value.ToString("dd.MM.yyyy"));
            }
        }

        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var bookByAuthor = new Library();

            var bookLibrary = new List<Book>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine()
                    .Split(' ');

                var book = new Book();

                book.Title = input[0];
                book.Author = input[1];
                book.Publisher = input[2];
                book.ReleaseDate = DateTime.ParseExact(input[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);
                book.IsbnNumber = input[4];
                book.Price = double.Parse(input[5]);

                bookLibrary.Add(book);
            }
            bookByAuthor.Books = bookLibrary;
            var releaseDate = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);
            var datePerAuthor = AddValuesToDict(bookByAuthor);

            PrintResults(datePerAuthor, releaseDate);
        }
    }
}
