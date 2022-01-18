using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyExercise
{
    class Company
    {
        public string title;
        public string address;
        public string phone;
        public double outcome;
        public double expense;

        public Company()
        {
            this.title = string.Empty;
            this.address = string.Empty;
            this.phone = string.Empty;
            this.outcome = 0;
            this.expense = 0;
        }

        public Company(string title, string address, string phone, double outcome, double expense)
        {
            this.title = title;
            this.address = address;
            this.phone = phone;
            this.outcome = outcome;
            this.expense = expense;
        }
        public Company (Company company)
        {
            this.title = company.title;
            this.address = company.address;
            this.phone = company.phone;
            this.outcome = company.outcome;
            this.expense = company.expense;
        }
        public void printInfo()
        {
            Console.WriteLine($"Yrityksen nimi: {this.title}, yrityksen osoite: {this.address}, puhelin: {this.phone}, tulot: {this.outcome}, menot: {this.expense}");
        }

        //public override string ToString()
        //{
        //    return $"Yrityksen nimi: {this.title}, yrityksen osoite: {this.address}, puhelin: {this.phone}, tulot: {this.outcome}, menot: {this.expense}";
        //}
        public void Voitot()
        {
            string low = "Firmalla menee kehnosti: ";
            string passable = "Firmalla menee välttävästi: ";
            string average = "Firmalla menee tyydyttävästi: ";
            string good = "Firmalla menee hyvin: ";

            double voittoPros = ((outcome - expense) / expense * 100);

            if (voittoPros > 300)
            {
                Console.WriteLine(good + voittoPros + "%");
            }
            else if (voittoPros > 200 && voittoPros < 300)
            {
                Console.WriteLine(average + voittoPros + "%");
            }
            else if (voittoPros > 100 && voittoPros < 200)
            {
                Console.WriteLine(passable + voittoPros + "%");
            }
            else if (voittoPros < 100)
            {
                Console.WriteLine(low + voittoPros + "%");
            }
        }
    }
}
