using System;
using System.Text;

namespace _02.Book_Shop
{
    public class Book
    {
        private string title;
        private string author;
        private decimal price;

        public Book(string author, string title, decimal price)
        {
            this.Author = author;
            this.Title = title;
            this.Price = price;
        }

        public virtual decimal Price
        {
            get
            {
                return this.price;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Price not valid!");
                }
                this.price = value;
            }
        }   

        public virtual string Author
        {
            get
            {
                return this.author;
            }
            set
            {
                var nameTokens = value.Split(new []{' '}, StringSplitOptions.RemoveEmptyEntries);

                if (nameTokens.Length > 1)
                {
                    if (char.IsDigit(nameTokens[1][0]))
                    {
                        throw new ArgumentException("Author not valid!");
                    }
                    
                }
                this.author = value;
            }
        }

        public virtual string Title
        {
            get
            {
                return this.title;
            }
            set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Title not valid!");
                }
                this.title = value;
            }
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("Type: ").AppendLine($"{this.GetType().Name}");
            sb.Append("Title: ").AppendLine($"{this.Title}");
            sb.Append("Author: ").AppendLine($"{this.Author}");
            sb.Append($"Price: ").AppendLine($"{this.Price:f1}");

            return sb.ToString();
        }
    }
}
