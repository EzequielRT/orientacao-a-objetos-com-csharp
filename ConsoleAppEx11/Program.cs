using ConsoleAppEx11.Entities;
using ConsoleAppEx11.Entities.Enums;
using System.Globalization;
using System;

namespace ConsoleAppEx11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter client data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("E-mail: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthDate = Convert.ToDateTime(Console.ReadLine());

            Client client = new Client(name, email, birthDate);

            Console.WriteLine("Enter order data:");
            Console.Write("Status: ");
            OrderStatus os = Enum.Parse<OrderStatus>(Console.ReadLine());
            Console.Write("How many items to this order? ");
            int n = Convert.ToInt32(Console.ReadLine());

            Order order = new Order(DateTime.Now, os, client);

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} item data:");
                Console.Write("Product name: ");
                string prodName = Console.ReadLine();
                Console.Write("Product price: ");
                double prodPrice = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantity: ");
                int quantity = Convert.ToInt32(Console.ReadLine());


                Product product = new Product(prodName, prodPrice);

                OrderItem orderItem = new OrderItem(quantity, prodPrice, product);

                order.AddItem(orderItem);
            }

            Console.WriteLine();
            Console.WriteLine(order);

        }
    }
}
