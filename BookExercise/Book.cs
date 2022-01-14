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
            if (idValue.Length == 5)
            {
                this.id = idValue;
            } 
            else
            {
                this.id = "Not valid, set 5 number ID";
            }
            
        }
        
        public void CompareBook(Book book)
        {
            //Vertaa parametrinä olevan olion kappalehintaa kutsuttavan olion kappalehintaan ja palauta tieto kumpi on kalliimpi
            if (this.price > book.price)
            {
                Console.WriteLine($"{this.title} on kalliimpi kuin {book.title}");
            }
            else if (this.price < book.price)
            {
                Console.WriteLine($"{book.title} on kalliimpi kuin {this.title}");
            }
            else
            {
                Console.WriteLine($"{this.title} on saman hintainen kuin {book.title}");
            }

            Console.WriteLine($"Kutsuva olio: {this.title} {this.price}");

            Console.WriteLine($"Parametrinä tuleva olio: {book.title} {book.price}");


        }
            
    }
}
