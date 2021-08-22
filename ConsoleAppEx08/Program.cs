using System;

namespace ConsoleAppEx08
{
    class Program
    {
        static void Main(string[] args)
        {
            Estudante[] quartoAlugado = new Estudante[10];

            Console.Write("Quantos quartos serão alugados? ");
            int qtdDeQuartosAlugados = Convert.ToInt16(Console.ReadLine());
            
            for (int i = 1; i <= qtdDeQuartosAlugados; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Aluguel #{i}:");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("E-mail: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int nmrQuarto = Convert.ToInt16(Console.ReadLine());

                quartoAlugado[nmrQuarto] = new Estudante { Nome = nome, Email = email };
            }

            Console.WriteLine();
            Console.WriteLine("Quartos ocupados:");
            for (int i = 0; i < quartoAlugado.Length; i++)
            {
                if (quartoAlugado[i] != null)
                {
                    Console.WriteLine($"{i}: {quartoAlugado[i]}");
                }
            }

        }
    }
}