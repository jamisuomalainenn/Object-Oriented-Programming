using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee[] employees = new Employee[4];
            employees[0] = new Employee("Mikko", "1234", "Johtaja", 5000);
            employees[1] = new Employee("Anna", "4567", "Sihteeri", 3000);
            employees[2] = new Employee("Martti", "4357", "Työmies", 3500);
            employees[3] = new Employee("Pena", "5678", "Siivooja", 2000);

            Console.WriteLine("Taulukon tulostus PrintEmployeeInfo-metodilla");
            foreach (Employee currentEmployee in employees)
            {
                currentEmployee.PrintEmployeeInfo();
            }

            Console.WriteLine("\nTaulukon tulostus ToString-metodilla");
            foreach (Employee currentEmployee in employees)
            {
                Console.WriteLine(currentEmployee.ToString());
            }


            Console.WriteLine("\nTaulukon palkkojen vertailut:");
            for (int i = 0; i < employees.Length; i++)
            {
                if(i == employees.Length - 1)
                {
                    employees[i].CompareSalary(employees[0]);
                }
                else
                {
                    employees[i].CompareSalary(employees[i + 1]);
                }
            }

            
            Console.ReadLine();
            
        }
    }
}
