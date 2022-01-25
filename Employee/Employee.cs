using System;
using System.Collections.Generic;
using System.Text;

namespace Employee
{
    class Employee
    {
        public string name;
        public string id;
        public string job;
        public double salary;
        public Employee()
        {
            //tässä asetetaan oletusarvoksi 0 tai tyhjä
            this.name = string.Empty;
            this.id = string.Empty;
            this.job = string.Empty;
            this.salary = 0;
        }

        public Employee(string name, string id, string job, double salary)
        {
            this.name = name;
            SetId(id);
            this.job = job;
            this.salary = salary;
        }

        public override string ToString()
        {
            return $"\n\nNimi: {this.name}\n ID: {this.id}\n Tehtävä: {this.job}\n Palkka: {this.salary}";
        }

        public void CompareSalary(Employee employee)
        {
            //this.ToString();
            if (this.salary > employee.salary)
            {
                Console.WriteLine($"{this.name}, {this.salary} palkka on suurempi kuin {employee.name}, {employee.salary}");
            }
            else if (this.salary < employee.salary)
            {
                Console.WriteLine($"{this.name}, {this.salary} palkka on pienempi kuin {employee.name}, {employee.salary}");
            }
            else
            {
                Console.WriteLine($"{this.name}, {this.salary} palkka on sama kuin {employee.name}, {employee.salary}");
            }
                        //tässä verrataan palkkoja

        }

        public void PrintEmployeeInfo()
        {
            Console.WriteLine(this.ToString());
        }

        public void SetId(string idValue)
        {
            //tarkistaa tässä onko ID viisi merkkiä pitkä
            if (idValue.Length == 5)
            {
                this.id = idValue;
            }
            else
            {
                this.id = "Not valid, set 5 number ID";
            }

        }
    }
}
