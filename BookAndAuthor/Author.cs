using System;
using System.Collections.Generic;
using System.Text;
using BookAndAuthor.Literature;

namespace BookAndAuthor
{
    class Author
    {
        public string name;
        public string birthday;
        public Book1 book;

        public Author()
        {
            this.name = string.Empty;
            this.birthday = string.Empty;
            this.Book = null;
        }

        public Author(string name, string birthday, Book1 book)
        {
            this.name = name;
            this.birthday = birthday;
            this.Book = book;
        }

        public Book1 Book
        {
            get { return book; }
            set
            {
                if (value.Author == this.name)
                {
                    book = value;
                }
                else
                {
                    Console.WriteLine("Kirjan tietoja ei tallennettu.");
                }
            }

        }

        public void PrintInfo()
        {
            Console.WriteLine($"Kirjailijan nimi: {this.name}");
            Console.WriteLine($"Kirjailijan syntymäaika: {this.birthday}");
            if (this.Book != null)
            {
                Console.WriteLine($"Kirjailijan kirjoittama kirja: {this.Book.ToString()}");
            }
        }
    }
}
