using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace BookAndAuthor.Literature
{
    class Book : IComparable<Book>
    {
        private const int MaxLength = 13;
        private const string Prefix = "978";
        public string name;
        private string author;
        public string publisher;
        private double price;
        private string isbn;
        public static string theme = "Fantasia";

        public Book()
        {
            this.name = string.Empty;
            this.author = string.Empty;
            this.publisher = string.Empty;
            this.Price = 0;
            this.Isbn = string.Empty;
        }

        public Book(string name, string author, string publisher, double price, string isbn)
        {
            this.name = name;
            this.author = author;
            this.publisher = publisher;
            this.Price = price;
            this.Isbn = isbn;
        }

        public string Isbn
        {
            get { return isbn; }
            set
            {
                if (value.Length > MaxLength)
                {
                    Console.WriteLine("\nToimisto epäonnistui! MAX 13 MERKKIÄ!");
                }
                else if (value.StartsWith(Prefix))
                {
                    
                    isbn = value;
                }
                else
                {
                    Console.WriteLine("\nToiminto epäonnistui! TARKISTA ISBN-KOODI!");
                }
            }
        }

        public double Price
        {
            get { return price; }
            set
            {
                if (value > 30.00)
                {
                    price = Math.Round(value * 0.90, 2);
                }
                else
                {
                    price = value;
                }
            }
        }

        public string Author
        {
            get { return author; }
        }

        public void GetBookDetails(string IsbnValue)
        {
            if (IsbnValue == this.Isbn)
            {
                Console.WriteLine($"Kirjan tiedot: \nNimi: {this.name}\nKirjoittaja:  {this.author}\nJulkaisija: {this.publisher}\nHinta:  {this.price}\nISBN-Tunnus: {this.isbn}");
            }
            else
            {
                Console.WriteLine($"Kirjan '{this.name}' tietoja ei voi tulostaa! Tarkasta ISBN sekä PREFIX!!!");
            }
        }

        public static void ChangeTheme(string changeTheme)
        {
            theme = changeTheme;
        }
        public override string ToString()
        {
            return $"{this.name}, {this.price}";
        }

        public int CompareTo([AllowNull] Book other)       //// IComparable rajapinta - Tehtävä
        {
            return this.price.CompareTo(other.price);
        }
    }
}
