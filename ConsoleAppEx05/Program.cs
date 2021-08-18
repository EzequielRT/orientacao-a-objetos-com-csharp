using System;
using System.Globalization;

namespace ConsoleAppEx05
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();

            Console.Write("Nome do aluno: ");
            aluno.Nome = Console.ReadLine();

            Console.WriteLine("Digite as três notas do aluno: ");
            aluno.Nota01 = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.Nota02 = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.Nota03 = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

            aluno.CalculaNotaFinal();
            aluno.VerificaSituacaoDoAluno();
        }
    }
}
