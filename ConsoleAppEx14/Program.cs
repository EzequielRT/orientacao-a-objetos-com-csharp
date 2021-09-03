using System;
using ConsoleAppEx14.Entities;
using System.Globalization;
using ConsoleAppEx14.Entities.Exceptions;

namespace ConsoleAppEx14
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter account data");
            Console.Write("Number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.Write("Holder: ");
            string holder = Console.ReadLine();
            Console.Write("Initial balance: ");
            double balance = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Withdraw limit: ");
            double withDrawLimit = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

            Account account = new Account(number, holder, balance, withDrawLimit);

            Console.WriteLine();
            Console.Write("Enter amount for withdraw: ");
            double amount = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            try
            {
                account.WithDraw(amount);
                Console.WriteLine($"New balance: {account.Balance.ToString("F2", CultureInfo.InvariantCulture)}");
            }
            catch (DomainException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Error in format: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Unexpected error: " + e.Message);
            }
        }
    }
}
