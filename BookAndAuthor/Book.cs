using System;
using System.Collections.Generic;
using System.Text;

namespace BookAndAuthor
{
    class Book
    {
        private string name;
        private string author;
        private string publisher;
        private double price;
        private string isbn;
        public static string themeName;
        //private int id;
        //public static int counter = 1;


        public Book()
        {
            this.Name = string.Empty;
            this.author = string.Empty;
            this.publisher = string.Empty;
            this.price = 0;
            this.isbn = string.Empty;
        }

        public string GetBookDetails()
        {
            {
                return $"{this.name} {this.author} {this.isbn} {this.price:F2}";
            }
        }

        public Book(string name)
        {
            this.Name = name;
            this.isbn = "13";
            //counter++;
        }

        public void SetIsbn(string isbnValue)
        {
            //tarkista tässä onko ISBN 13 merkkiä pitkä
            if (isbnValue.Length == 13)
            {
                this.isbn = isbnValue;
            }
            else
            {
                this.isbn = "Not valid, set 5 number ID";
            }
        }
        public string Name 
        {
            get
            {
                return name;
            }
            set
            {
                if (value.Length > MaxLength)
                {
                    Console.WriteLine("Nimi on liian pitkä.");
                }
                else
                {
                    name = value.ToLower();
                }
            }
        }

        //public int Id {
        //    get { return id; }
        //    set { id = value; }
        
    }
}
