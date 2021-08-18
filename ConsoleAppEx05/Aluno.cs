using System;
using System.Globalization;

namespace ConsoleAppEx05
{
    class Aluno
    {
        public string Nome;
        public double Nota01, Nota02, Nota03, NotaFinal;

        public void CalculaNotaFinal()
        {
            NotaFinal = Nota01 + Nota02 + Nota03;
        }

        public void VerificaSituacaoDoAluno()
        {
            if (NotaFinal < 60)
            {
                double pontosQueFaltou = 60.00 - NotaFinal;

                Console.WriteLine($"NOTA FINAL = {NotaFinal.ToString("F2", CultureInfo.InvariantCulture)}");
                Console.WriteLine("REPROVADO");
                Console.WriteLine($"FALTARAM {pontosQueFaltou.ToString("F2", CultureInfo.InvariantCulture)} PONTOS");
            }
            else 
            {
                Console.WriteLine($"NOTA FINAL = {NotaFinal.ToString("F2", CultureInfo.InvariantCulture)}");
                Console.WriteLine("APROVADO");
            }
        }
    }
}
