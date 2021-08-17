using System;
using System.Globalization;

namespace ConsoleAppEx02
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario_01 = new Funcionario();
            Funcionario funcionario_02 = new Funcionario();

            Console.WriteLine("Dados do primeiro funcionário:");
            Console.Write("Nome: ");
            funcionario_01.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            funcionario_01.Salario = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do segundo funcionário:");
            Console.Write("Nome: ");
            funcionario_02.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            funcionario_02.Salario = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

            double mediaSalarial = (funcionario_01.Salario + funcionario_02.Salario) / 2.0;

            Console.WriteLine($"Salário médio = {mediaSalarial.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
