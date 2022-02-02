using System;
using BookAndAuthor.Literature;

namespace BookAndAuthor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tehtävä Book!");

            Book1 book1 = new Book1($"Jami Suomalainen", "Jere Suomalainen", "Suomalaisten Kirjat Oy", 20.00, "9781345");
            Book1 book2 = new Book1($"Linnut eivät lennä", "Jukuri Veiterä", "Tuotantoyhtiö", 37.50, "78412312");
            Book1 book3 = new Book1($"Witcher", "Andrzej Sapkowski", "Otava", 95.00, "97841231");
            Book1 book4 = new Book1();

            Console.WriteLine($"Nämä kirjat ovat kategoriassa: {Book1.theme}");

            Console.WriteLine();
            book3.GetBookDetails("97841231");
            Console.WriteLine();

            Book1.ChangeTheme("Fiktio");
            Console.WriteLine($"Nämä kirjat ovat kategoriassa: {Book1.theme}");

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

          


            Console.WriteLine();
            

        }
    }
}
