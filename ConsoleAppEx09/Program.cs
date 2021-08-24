using System;
using System.Collections.Generic;
using System.Globalization;

namespace ConsoleAppEx09
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many employees will be registered? ");
            int n = Convert.ToInt16(Console.ReadLine());

            List<Employee> employeesList = new List<Employee>();

            Console.WriteLine();
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Employee: #{i}");
                Console.Write($"Id: ");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.Write($"Name: ");
                string name = Console.ReadLine();
                Console.Write($"Salary: ");
                double salary = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
                employeesList.Add(new Employee(id, name, salary));
                Console.WriteLine();
            }

            Console.Write("Enter the employee id that will have salary increase: ");
            int employeeId = Convert.ToInt32(Console.ReadLine());
            Employee searchEmployee = employeesList.Find(x => x.Id == employeeId);
            
            if (searchEmployee != null)
            {
                Console.Write("Enter the percentage: ");
                double percent = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
                searchEmployee.IncreaseSalary(percent);
            }
            else
            {
                Console.WriteLine("This id does not exist!");
            }

            Console.WriteLine();
            Console.WriteLine("Updated list of employees:");
            foreach (Employee obj in employeesList)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
