using System;

namespace BookExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is Book exercise!");
            Book book1 = new Book();
            book1.title = "Matematiikka 1 " + "Salonen " + "Matti ";
            Console.WriteLine("Ensimmäinen kirja: " + book1.title);

            Book book2 = new Book("Aapinen " + "Salonen " + "Matti " + 22.50);
            Console.WriteLine("Toinen kirja: " + book2.title);

            Book book3 = new Book("Historia 4" + " Salonen" + " Matti " + 22.50);
            Console.WriteLine(book3.GetBookInformation());

        }
    }
}
