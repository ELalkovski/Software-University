namespace _5.Book_Library
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;

    class BookLibrary
    {

        public static List<Book> GetBooksList(int n)
        {
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

            return bookLibrary;
        }

        public static Dictionary<string, double> AddValuesToDict(Library booksByAuthor)
        {
            var pricePerAuthor = new Dictionary<string, double>();

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

        public static void PrintResults(Dictionary<string, double> pricePerAuthor)
        {
            foreach (var author in pricePerAuthor.OrderByDescending(x => x.Value).ThenBy(y => y.Key))
            {
                Console.WriteLine("{0} -> {1:f2}", author.Key, author.Value);
            }
        }

        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var bookByAuthor = new Library();
            bookByAuthor.Books = GetBooksList(n);

            var pricePerAuthor = AddValuesToDict(bookByAuthor);
            PrintResults(pricePerAuthor);
        }
    }
}
