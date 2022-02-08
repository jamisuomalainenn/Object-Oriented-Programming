using System;
using System.Collections.Generic;
using BookAndAuthor.Literature;

namespace BookAndAuthor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tehtävä Book!");

             Book book1 = new Book("Jami Suomalainen", "Jere Suomalainen", "Suomalaisten Kirjat Oy", 20.00, "9781345");
             Book book2 = new Book("Linnut eivät lennä", "Jukuri Veiterä", "Tuotantoyhtiö", 37.50, "78412312");
             Book book3 = new Book("Witcher", "Andrzej Sapkowski", "Otava", 95.00, "97841231");
             Book book4 = new Book();

             Console.WriteLine($"Nämä kirjat ovat kategoriassa: {Book.theme}");

             Console.WriteLine();
             book3.GetBookDetails("97841231");
             Console.WriteLine();

             Book.ChangeTheme("Fiktio");
             Console.WriteLine($"Nämä kirjat ovat kategoriassa: {Book.theme}");

             book1.GetBookDetails("9781345");
             Console.WriteLine();
             book2.GetBookDetails("978412312");
             Console.WriteLine();

             Console.WriteLine(book1.Author);
             Console.WriteLine(book3.Author);
             Console.WriteLine();


             Author author1 = new Author("Jere Suomalainen", "1.1.1994", book1);
             author1.PrintInfo();

             Console.WriteLine();
             Author author2 = new Author("Jukuri Veiterä", "1.1.1900", book2);
             author2.PrintInfo();

             Console.WriteLine();
             Author author3 = new Author("Andrzej Sapkowski", "1.1.1950", book3);
             author3.PrintInfo();

             Console.WriteLine();
             Author author4 = new Author("Testi Mies", "7.1.1998", book4);
             author4.PrintInfo();


            Console.WriteLine("________________________________________________________");
            List<Book> books = new List<Book>();

            books.Add(new Book($"Huono kirja", "Kirjailija Kippars", "Otava", 19.99, "9781346"));
            books.Add(new Book($"Hyvä kirja", "Kirjailija Kappars", "Atava", 9.99, "9781335"));
            books.Add(new Book($"Iha OK kirja", "Kirjailija Koppars", "Etava", 99.99, "9781342"));
            books.Add(new Book($"Paras kirja", "Kirjailija Keppars", "Detava", 109.99, "9781341"));
            books.Sort();


            foreach (Book b in books)
            {
                Console.WriteLine(b.ToString());
            }

        }
    }
}
