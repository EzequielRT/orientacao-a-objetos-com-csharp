using System;
using ConsoleAppEx16.Services;
using ConsoleAppEx16.Entities;
using System.Globalization;

namespace ConsoleAppEx16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data");
            Console.Write("Number: ");
            int number = Convert.ToInt32(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Date (dd/MM/yyyy): ");
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Contract value: ");
            double totalValue = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Enter number of installments: ");
            int numberOfInstallments = Convert.ToInt32(Console.ReadLine(), CultureInfo.InvariantCulture);

            Contract contract = new Contract(number, date, totalValue);
            ContractService contractService = new ContractService(new PaypalService());
            contractService.ProcessContract(contract, numberOfInstallments);

            Console.WriteLine("Installments:");
            foreach (Installment installment in contract.Installments)
            {
                Console.WriteLine(installment);
            }
        }
    }
}
