using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Exercise
{
    class Employee
    {
        string name;
        string id;
        string position;
        double salary;

        public Employee()
        {
            this.name = string.Empty;
            this.id = string.Empty;
            this.position = string.Empty;
            this.salary = 0;
        }

        public Employee(string name, string id, string position, double salary)
        {
            this.name = name;
            this.id = id;
            this.position = position;
            this.salary = salary;
        }
        public void CompareSalary(Employee employee)
        {
            if (this.salary > employee.salary)
            {
                Console.WriteLine($"Henkilön {this.name} palkka on suurempi kuin henkilön {employee.name}");
            }
            if (this.salary < employee.salary)
            {
                Console.WriteLine($"Henkilön {employee.name} palkka on suurempi kuin henkilön {this.name}");
            }
            if (this.salary == employee.salary)
            {
                Console.WriteLine("Palkat ovat yhtäsuuria");
            }

        }

        public void PrintEmployeeInfo()
        {
            Console.WriteLine($"{this.name} {this.id} {this.position} {this.salary}");
        }

        public override string ToString()
        {
            return $"{base.ToString()} {this.name} {this.id} {this.position} {this.salary}";
        }
    }
}
