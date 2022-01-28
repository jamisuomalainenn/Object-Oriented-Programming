using System;

namespace BookAndAuthor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tehtävä Book!");

            Book book1 = new Book("Jami SUomalainen", "Jere Suomalainen", "Otava", 20.00, );
            book1.name = "Witcher";

            //Book book2 = new Book("Witcher");

            //Console.WriteLine($"kirjan nimi on: {book1.name}");
            //Console.WriteLine($"Book-luokan counter = {Book.counter}");

            //Console.WriteLine($"{book2.Id}. kirjan nimi on: {book2.Name}");
            //Console.WriteLine($"Book-luokan counter = {Book.counter}");

            Author author1 = new Author("Jami Suomalainen", "1.1.1998", book1);
            author1.PrintInfo();
        }
    }
}
