using System;

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
            

        }
    }
}
