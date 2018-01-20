namespace BookShop
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Text;
    using BookShop.Data;
    using BookShop.Models;
    using Microsoft.EntityFrameworkCore;

    public class StartUp
    {
        public static void Main()
        {
            using (var db = new BookShopContext())
            {
                RemoveBooks(db);
            }
        }

       // 01. Age Restriction
        public static string GetBooksByAgeRestriction(BookShopContext db, string command)
        {
            string[] titles = db.Books
                .Where(t => t.AgeRestriction.ToString().Equals(command, StringComparison.InvariantCultureIgnoreCase))
                .Select(b => b.Title)
                .OrderBy(t => t)
                .ToArray();

            return string.Join(Environment.NewLine, titles);
        }

        // 02. Golden Books
        public static string GetGoldenBooks(BookShopContext db)
        {
            string[] titles = db.Books
                .Where(b => (int)b.EditionType == 2)
                .Where(b => b.Copies < 5000)
                .OrderBy(b => b.BookId)
                .Select(b => b.Title)
                .ToArray();

            return string.Join(Environment.NewLine, titles);
        }

        // 03. Books by Price
        public static string GetBooksByPrice(BookShopContext db)
        {
            string[] titles = db.Books
                .Where(b => b.Price > 40)
                .OrderByDescending(b => b.Price)
                .Select(b => $"{b.Title} - ${b.Price:f2}")
                .ToArray();

            return string.Join(Environment.NewLine, titles);
        }

        // 04. Not Released In
        public static string GetBooksNotRealeasedIn(BookShopContext db, int publishingYear)
        {
            string[] titles = db.Books
                .Where(b => b.ReleaseDate.Value.Year != publishingYear)
                .OrderBy(b => b.BookId)
                .Select(b => b.Title)
                .ToArray();

            return string.Join(Environment.NewLine, titles);
        }

        // 05. Book Titles by Category
        public static string GetBooksByCategory(BookShopContext db, string input)
        {
            string[] bookCategories = input
                .Split(new[] {' ', '\t'}, StringSplitOptions.RemoveEmptyEntries);

            Book[] books = db.Books
                .Include(b => b.BookCategories)
                .ThenInclude(bc => bc.Category)
                .OrderBy(b => b.Title)
                .ToArray();

            List<string> titles = new List<string>();

            foreach (var book in books)
            {
                foreach (var category in book.BookCategories)
                {
                    if (bookCategories.Contains(category.Category.Name, StringComparer.InvariantCultureIgnoreCase))
                    {
                        titles.Add(book.Title);
                        break;
                    }
                }
            }

            return string.Join(Environment.NewLine, titles);
        }

        // 06. Released Before Date
        public static string GetBooksReleasedBefore(BookShopContext db, string dateString)
        {
            DateTime parsedDate = DateTime.ParseExact(dateString, "dd-MM-yyyy", CultureInfo.InvariantCulture);

            string[] books = db.Books
                .Where(b => DateTime.Compare(b.ReleaseDate.Value, parsedDate) < 0)
                .OrderByDescending(b => b.ReleaseDate)
                .Select(b => $"{b.Title} - {b.EditionType} - ${b.Price:f2}")
                .ToArray();

            return string.Join(Environment.NewLine, books);
        }

        //07. Author Search
        public static string GetAuthorNamesEndingIn(BookShopContext db, string inputString)
        {
            string[] authors = db.Authors
                .Where(a => a.FirstName.EndsWith(inputString))
                .Select(a => $"{a.FirstName} {a.LastName}")
                .OrderBy(a => a)
                .ToArray();

            return string.Join(Environment.NewLine, authors);
        }

        //08. Book Search
        public static string GetBookTitlesContaining(BookShopContext db, string inputString)
        {
            string[] titles = db.Books
                .Where(b => b.Title.IndexOf(inputString, StringComparison.CurrentCultureIgnoreCase) >= 0)
                .Select(b => b.Title)
                .OrderBy(t => t)
                .ToArray();

            return string.Join(Environment.NewLine, titles);
        }

        //09. Book Search by Author
        public static string GetBooksByAuthor(BookShopContext db, string inputString)
        {
            string[] titlesWithAuthors = db.Books
                .Where(b => b.Author.LastName.IndexOf(inputString, StringComparison.CurrentCultureIgnoreCase) == 0)
                .OrderBy(b => b.BookId)
                .Select(b => $"{b.Title} ({b.Author.FirstName} {b.Author.LastName})")
                .ToArray();

            return string.Join(Environment.NewLine, titlesWithAuthors);
        }

        //10. Count Books
        public static int CountBooks(BookShopContext db, int lengthCheck)
        {
            return db.Books
                .Where(b => b.Title.Length > lengthCheck)
                .Count();
        }

        //11. Total Book Copies
        public static string CountCopiesByAuthor(BookShopContext db)
        {
            string[] authors = db.Authors
                .OrderByDescending(a => a.Books.Sum(b => b.Copies))
                .Select(a => $"{a.FirstName} {a.LastName} - {a.Books.Sum(b => b.Copies)}")
                .ToArray();

            return string.Join(Environment.NewLine, authors);
        }

        //12. Profit by Category
        public static string GetTotalProfitByCategory(BookShopContext db)
        {
            string[] categories = db.Categories
                .OrderByDescending(c => c.CategoryBooks.Sum(b => b.Book.Copies * b.Book.Price))
                .Select(c => $"{c.Name} ${(c.CategoryBooks.Sum(b => b.Book.Copies * b.Book.Price)):f2}")
                .ToArray();

            return string.Join(Environment.NewLine, categories);
        }

        //13. Most Recent Books
        public static string GetMostRecentBooks(BookShopContext db)
        {
            var categories = db.Categories
                .OrderBy(c => c.Name)
                .Select(c => new
                {
                    c.Name,
                    Books = c.CategoryBooks
                    .Select(cb => cb.Book)
                    .OrderByDescending(b => b.ReleaseDate)
                    .Take(3)
                })
                .ToArray();

            StringBuilder sb = new StringBuilder();

            foreach (var category in categories)
            {
                sb.AppendLine($"--{category.Name}");

                foreach (var book in category.Books)
                {
                    sb.AppendLine($"{book.Title} ({book.ReleaseDate.Value.Year})");
                }
            }

            return sb.ToString().Trim();
        }

        //14. Increase Prices
        public static void IncreasePrices(BookShopContext db)
        {
            var books = db.Books
                .Where(b => b.ReleaseDate.Value.Year < 2010);

            foreach (var book in books)
            {
                book.Price += 5m;
            }

            db.SaveChanges();
        }

        //15. Remove Books
        public static int RemoveBooks(BookShopContext db)
        {
            var books = db.Books
                .Where(b => b.Copies < 4200)
                .ToList();

            db.RemoveRange(books);
            db.SaveChanges();

            return books.Count();
        }
    }
}
