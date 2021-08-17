using System;
using System.Globalization;

namespace ConsoleAppEx03
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo retangulo = new Retangulo();

            Console.WriteLine("Entre com a largura e a altura do retângulo:");
            retangulo.Largura = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            retangulo.Altura = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine(retangulo);
        }
    }
}
