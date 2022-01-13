using System;
using System.Collections.Generic;
using System.Text;

namespace BookExercise
{
    public class Book
    { 
        public string title;
        public string author;
        public string id;
        public double price;
        
        //empty constructor
        public Book()
        {
            this.title = string.Empty;
            this.author = string.Empty;
            this.id = string.Empty;
            this.price = 0;
        }
        //constructor
        public Book(string title)
        {
            this.title = title;
            this.author = string.Empty;
            this.id = string.Empty;
            this.price = 0;

        }

        public Book(string title, string author, string id, double price) : this(title)
        {
            this.title = title;
            this.author = author;
            //  this.id = id;
            SetId(id);
            this.price = price;
        }

        public string GetBookInformation()
        {
            return $"{this.author} {this.title} {this.id} {this.price:F2}";
        }
            
        public void SetId(string idValue)
        {
            //tarkista tässä onko ID viisi merkkiä pitkä
            this.id = idValue;
        }
        
        public void CompareBook(Book book)
        {
            //Vertaa parametrinä olevan olion kappalehintaa kutsuttavan olion kappalehintaan ja palauta tieto kumpi on kalliimpi
            Console.WriteLine($"Kutsuva olio: {this.title}");
            Console.WriteLine($"Parametrinä tuleva olio: {book.title}");


        }
            
    }
}
