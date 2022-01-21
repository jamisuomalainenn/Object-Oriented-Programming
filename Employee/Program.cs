using System;

namespace Employee
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Luodaan Employee-olioita ja tallennetaan ne taulukkoon.");
            Employee[] employees = new Employee[4];
            employees[0] = new Employee("Jami Suomalainen", 12354, "Pomo", 50000);
            employees[1] = new Employee("Miro Miettinen", 45684, "Rivimies", 1000);
            employees[2] = new Employee("Eetu Haimi", 78468, "Sihteeri", 7855);
            employees[3] = new Employee("Niko Keskinen", 45685, "Koodaaja", 32000);
            Console.WriteLine($"employees taulukossa on {employees.Length} Employee-oliota.\n");
            for (int i = 0; i < employees.Length; i++)
            {
                if (i + 1 > employees.Length - 1)
                {
                    employees[i].CompareSalary(employees[0]);
                }
                else
                {
                    employees[i].CompareSalary(employees[i + 1]);
                }
            }
            Console.WriteLine("\n\n");
            for (int u = 0; u < employees.Length; u++)
            {
                employees[u].PrintEmployeeInfo();
            }
        }
    }
}
