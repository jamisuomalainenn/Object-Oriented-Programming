using System;
using System.Collections.Generic;
using System.Text;

namespace BookAndAuthor
{
    class Book
    {
        private const int MaxLength = 13;
        private const string Prefix = "978";
        public string name;
        private string author;
        public string publisher;
        private double price;
        private string isbn;
        public static string theme = "fantasia";
        //private int id;
        //public static int counter = 1;


        public Book()
        {
            this.name = string.Empty;
            this.author = string.Empty;
            this.publisher = string.Empty;
            this._price = 0;
            this.ISBN = string.Empty;
        }

        public Book(string name, string author, string publisher, double price, string isbn, string iSBN)
        {
            this.name = name;
            this.author = author;
            this.publisher = publisher;
            _price = price;
            _isbn = isbn;
            ISBN = iSBN;
        }

        //public double Price

        public string ISBN
        {
            get { return isbn; }
            set
            {
                if (value.Length > MaxLength)
                {
                    Console.WriteLine("\nToimisto epäonnistui! MAX 13 MERKKIÄ!");
                }
                else if (value.StartsWith(Prefix))
                {
                    isbn = value;
                }
                else
                {
                    Console.WriteLine("\nToiminto epäonnistui! TARKISTA ISBN-KOODI!");
                }
            }
        }

        public string GetBookDetails(string isbnValue)
        {
            if (isbnValue == this.ISBN)
            {
                Console.WriteLine($"{this.name} {this.author} {this._isbn} {this._price:F2}");
            }
            else
            {
                Console.WriteLine("Tietoja ei voida tulostaa.");
            }
        }

        //public Book(string name)
        //{
        //    this.Name = name;
        //    //this.isbn = "13";
        //    //counter++;
        //}

        //public void SetIsbn(string isbnValue)
        //{
        //    //tarkista tässä onko ISBN 13 merkkiä pitkä
        //    if (isbnValue.Length == 13)
        //    {
        //        this.isbn = isbnValue;
        //    }
        //    else
        //    {
        //        this.isbn = "Not valid, set 5 number ID";
        //    }
        //}
        //public string Name 
        //{
        //    get
        //    {
        //        return name;
        //    }
        //    set
        //    {
        //        if (value.Length > MaxLength)
        //        {
        //            Console.WriteLine("Nimi on liian pitkä.");
        //        }
        //        else
        //        {
        //            name = value.ToLower();
        //        }

        public string Author
        {
            get
            {
                return this.author;
            }
        }
    }
}

        //public int Id {
        //    get { return id; }
        //    set { id = value; }
        

