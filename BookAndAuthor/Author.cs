using System;
using System.Collections.Generic;
using System.Text;

namespace BookAndAuthor
{
    class Author
    {
        public string name;
        public string birthday;
        public Book book;

        public Author()
        {
            this.name = string.Empty;
            this.birthday = string.Empty;
            this.book = null;
        }

        public Author(string name, string birthday, Book book)
        {
            this.name = name;
            this.birthday = birthday;
            this.book = book;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Kirjailijan nimi: {this.name}");
            Console.WriteLine($"Kirjailijan syntymäaika: {this.birthday}");
            if (this.book != null)
            {
                Console.WriteLine($"Kirjailijan kirjoittama kirja: {this.book.ToString()}");
            }
        }
    }
}
