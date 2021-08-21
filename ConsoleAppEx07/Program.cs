using System;
using System.Globalization;

namespace ConsoleAppEx07
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta;

            Console.Write("Entre com o número da conta: ");
            int nmrDaConta = Convert.ToInt32(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Entre com o nome do titular: ");
            string nomeDoTitular = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)? ");
            char resp = Convert.ToChar(Console.ReadLine());

            if (resp.ToString().ToLower() == "s")
            {
                Console.Write("Entre com o valor de depósito inicial: ");
                double depositoInicial = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new ContaBancaria(nomeDoTitular, nmrDaConta, depositoInicial);
            }
            else
            {
                conta = new ContaBancaria(nomeDoTitular, nmrDaConta);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Entre com um valor para depósito: ");
            double quantia = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(quantia);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Entre com um valor para saque: ");
            quantia = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(quantia);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(conta);
        }
    }
}
