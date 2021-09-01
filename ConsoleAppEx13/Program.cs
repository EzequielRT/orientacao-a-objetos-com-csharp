using System;
using System.Collections.Generic;
using System.Globalization;
using ConsoleAppEx13.Entities;

namespace ConsoleAppEx13
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TaxPayer> list = new List<TaxPayer>();

            Console.Write("Enter the number of tax payers: ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individual or company (i/c)? ");
                char type = Convert.ToChar(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double anualIncome = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (type == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double healthExpenditures = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Individual(name, anualIncome, healthExpenditures));
                }
                else 
                {
                    Console.Write("Number of employees: ");
                    int quantityEmployees = Convert.ToInt32(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Company(name, anualIncome, quantityEmployees));
                }
            }

            Console.WriteLine();
            double sum = 0.0;
            Console.WriteLine("TAXES PAID:");
            foreach (TaxPayer taxPayer in list)
            {
                Console.WriteLine(taxPayer);
                sum += taxPayer.Tax();
            }

            Console.WriteLine();
            Console.WriteLine($"TOTAL TAXES: $ {sum.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
