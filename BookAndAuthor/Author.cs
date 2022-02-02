using System;
using System.Collections.Generic;
using System.Text;

namespace BookAndAuthor
{
    class Author
    {
        public string name;
        public string birthday;
        private Book1 book;

        public Author()
        {
            this.name = string.Empty;
            this.birthday = string.Empty;
            this.Book = Book1;
        }

        public Author(string name, string birthday, Book1 book)
        {
            this.name = name;
            this.birthday = birthday;
            this.Book = book;
        }

        internal Book1 Book {
            get { return book; }
            set
            {
                if (value.name == book.name)
                {
                    book = value;
                }
                else
                {
                    Console.WriteLine("Tietoja ei tallennettu.");
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
