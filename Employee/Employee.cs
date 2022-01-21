using System;
using System.Collections.Generic;
using System.Text;

namespace Employee
{
    class Employee
    {
        public string name;
        public int id;
        public string job;
        public double salary;
        public Employee()
        {

        }

        public Employee(string name, int id, string job, double salary)
        {
            this.name = name;
            this.id = id;
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

            //Console.WriteLine($"Kutsuva olio: {this.name} {this.salary}");

            //Console.WriteLine($"Parametrinä tuleva olio: {employee.name} {employee.salary}");

        }

        public void PrintEmployeeInfo()
        {
            Console.WriteLine(this.ToString());
        }
    }
}
