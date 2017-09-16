namespace _5.Book_Library
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;

    public class BookLibrary
    {
        public static void Main()
        {
            int booksCount = int.Parse(Console.ReadLine());
            Library bookByAuthor = new Library();
            bookByAuthor.Books = GetBooksList(booksCount);

            Dictionary<string, double> pricePerAuthor = AddValuesToDict(bookByAuthor);

            PrintResults(pricePerAuthor);
        }

        private static List<Book> GetBooksList(int n)
        {
            List<Book> bookLibrary = new List<Book>();

            for (int i = 0; i < n; i++)
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

            return bookLibrary;
        }

        private static Dictionary<string, double> AddValuesToDict(Library booksByAuthor)
        {
            Dictionary<string, double> pricePerAuthor = new Dictionary<string, double>();

            for (int i = 0; i < booksByAuthor.Books.Count; i++)
            {
                if (!pricePerAuthor.ContainsKey(booksByAuthor.Books[i].Author))
                {
                    pricePerAuthor.Add(booksByAuthor.Books[i].Author, 0);
                }

                pricePerAuthor[booksByAuthor.Books[i].Author] += booksByAuthor.Books[i].Price;
            }

            return pricePerAuthor;
        }

        private static void PrintResults(Dictionary<string, double> pricePerAuthor)
        {
            foreach (var author in pricePerAuthor.OrderByDescending(x => x.Value).ThenBy(y => y.Key))
            {
                Console.WriteLine("{0} -> {1:f2}", author.Key, author.Value);
            }
        }
    }
}
