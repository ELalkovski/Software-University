using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Globalization;

namespace _9.Book_Library
{
    class BookLibrary
    {
        public static void Main()
        {
            var input = File.ReadAllLines("Input.txt");
            var inputLinesQuantity = int.Parse(input[0]);
   
            var allBooks = new Library();
            var listOfBooks = new List<Book>();

            for (int i = 1; i <= inputLinesQuantity; i++)
            {
                var book = new Book();
                var currInput = input[i]
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

            var sumPricesPerAuthor = new Dictionary<string, double>();
            
            for (int i = 0; i < listOfBooks.Count; i++)
            {
                if (!sumPricesPerAuthor.ContainsKey(allBooks.Books[i].Author))
                {
                    sumPricesPerAuthor.Add(allBooks.Books[i].Author, allBooks.Books[i].Price);
                }
                else
                {
                    sumPricesPerAuthor[allBooks.Books[i].Author] += allBooks.Books[i].Price;
                }
            }

            foreach (var author in sumPricesPerAuthor.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine("{0} -> {1:f2}", author.Key, author.Value);
                File.AppendAllText("Output.txt", author.Key + " -> " + author.Value + Environment.NewLine);
            }
        }
    }
}
