namespace _6.Book_Library_Modification
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Globalization;

    public class BookLibraryModification
    {
        public static void Main()
        {
            int booksCount = int.Parse(Console.ReadLine());
            Library bookByAuthor = new Library();
            List<Book> bookLibrary = new List<Book>();

            for (int i = 0; i < booksCount; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(' ');

                Book book = new Book();

                book.Title = input[0];
                book.Author = input[1];
                book.Publisher = input[2];
                book.ReleaseDate = DateTime.ParseExact(input[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);
                book.IsbnNumber = input[4];
                book.Price = double.Parse(input[5]);

                bookLibrary.Add(book);
            }

            bookByAuthor.Books = bookLibrary;
            DateTime releaseDate = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);
            Dictionary<string, DateTime> datePerAuthor = AddValuesToDict(bookByAuthor);

            PrintResults(datePerAuthor, releaseDate);
        }

        private static Dictionary<string, DateTime> AddValuesToDict(Library booksByAuthor)
        {
            Dictionary<string, DateTime> datePerAuthor = new Dictionary<string, DateTime>();

            for (int i = 0; i < booksByAuthor.Books.Count; i++)
            {

                datePerAuthor[booksByAuthor.Books[i].Title] = booksByAuthor.Books[i].ReleaseDate;

            }

            return datePerAuthor;
        }

        private static void PrintResults(Dictionary<string, DateTime> datePerAuthor, DateTime releaseDate)
        {
            foreach (var author in datePerAuthor.Where(x => x.Value > releaseDate).OrderBy(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine("{0} -> {1}", author.Key, author.Value.ToString("dd.MM.yyyy"));
            }
        }
    }
}
