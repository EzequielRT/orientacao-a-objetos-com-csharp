using System;
using System.Globalization;

namespace ConsoleAppEx06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é a cotação do dólar? ");
            double cotacao = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantos dólares você vai comprar? ");
            double qdtDeDolares = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine($"Valor a ser pago em reais = R$ {ConversorDeMoeda.Converter(cotacao, qdtDeDolares).ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
