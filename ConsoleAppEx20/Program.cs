using System;
using System.Globalization;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using ConsoleAppEx20.Entities;

namespace ConsoleAppEx20
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Cria Diretorio
            string dir = Path.GetTempPath() + @"\Employees";
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }
            #endregion

            #region Cria CSV
            var sourcePath = new FileInfo(dir + @"\employees.csv");
            using (StreamWriter sw = sourcePath.CreateText())
            {
                sw.WriteLine("Maria,maria@gmail.com,3200.00");
                sw.WriteLine("Alex,alex@gmail.com,1900.00");
                sw.WriteLine("Marco,marco@gmail.com,1700.00");
                sw.WriteLine("Bob,bob@gmail.com,3500.00");
                sw.WriteLine("Anna,anna@gmail.com,2800.00");
            }
            #endregion

            Console.Write("Enter salary: ");
            double salary = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

            List<Employee> list = new List<Employee>();

            try
            {               
                using (StreamReader sr = File.OpenText(dir + @"\employees.csv"))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] fields = sr.ReadLine().Split(',');
                        string name = fields[0];
                        string email = fields[1];
                        double employeeSalary = Convert.ToDouble(fields[2], CultureInfo.InvariantCulture);

                        list.Add(new Employee(name, email, employeeSalary));
                    }
                }

                var listEmails = list.Where(emp => emp.Salary > salary).OrderBy(emp => emp.Email).Select(emp => emp.Email);

                Console.WriteLine($"Email of people whose salary is more than {salary.ToString("F2", CultureInfo.InvariantCulture)}:");
                foreach (var email in listEmails)
                {
                    Console.WriteLine(email);
                }

                var sum = list.Where(emp => emp.Name[0] == 'M').Sum(emp => emp.Salary);

                Console.Write($"Sum of salary of people whose name starts with 'M': {sum.ToString("F2", CultureInfo.InvariantCulture)}");
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
