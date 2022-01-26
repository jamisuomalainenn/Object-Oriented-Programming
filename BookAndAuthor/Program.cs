using System;

namespace BookAndAuthor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tehtävä Book!");

            Book book1 = new Book("Aapinen");
            book1.Name = "ABC";

            Book book2 = new Book("Witcher");

            Console.WriteLine($"kirjan nimi on: {book1.Name}");
            //Console.WriteLine($"Book-luokan counter = {Book.counter}");

            //Console.WriteLine($"{book2.Id}. kirjan nimi on: {book2.Name}");
            //Console.WriteLine($"Book-luokan counter = {Book.counter}");
        }
    }
}
