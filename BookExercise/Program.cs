using System;

namespace BookExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is Book exercise!");
            Book book1 = new Book("Matematiikka 1", "Salonen Matti", "12345", 15.99);
            /*book1.title = "Matematiikka 1";
            book1.author = "Salonen " + "Matti";
            book1.id = "00001";                         //Kommentoitu osio on korvattu nopeammalla
            book1.price = 15.99;*/                      //tavalla. Näin saadaan koodi yhdelle riville ja saadaan tilaa
            //book1.SetId("joops");
            Console.WriteLine("Ensimmäinen kirja: " + book1.title);
            
            Book book2 = new Book("Aapinen", "Aaltonen Antti", "00002", 20.00);
            Console.WriteLine("Toinen kirja: " + book2.title);

            Book book3 = new Book("Witcher", "Rosa Nurminen", "00003", 25.90);
            Console.WriteLine("Kolmas kirja: " + book3.title);
            //Console.WriteLine(book3.GetBookInformation());

            book3.CompareBook(book2);

            book2.CompareBook(book3);

            book1.CompareBook(book2);
        }
    }
}
