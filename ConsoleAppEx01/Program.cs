using System;

namespace ConsoleAppEx01
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa1 = new Pessoa();
            Pessoa pessoa2 = new Pessoa();
           
            Console.WriteLine("Digite os dados da 1ª pessoa:");
            Console.Write("Nome: ");
            pessoa1.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            pessoa1.Idade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite os dados da 2ª pessoa:");
            Console.Write("Nome: ");
            pessoa2.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            pessoa2.Idade = Convert.ToInt32(Console.ReadLine());

            if (pessoa1.Idade > pessoa2.Idade)
            {
                Console.WriteLine($"Pessoa mais velha {pessoa1.Nome}");
            }
            else
            {
                Console.WriteLine($"Pessoa mais velha {pessoa2.Nome}");
            }
        }
    }
}
