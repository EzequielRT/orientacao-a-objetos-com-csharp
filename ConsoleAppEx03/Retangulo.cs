using System;
using System.Globalization;

namespace ConsoleAppEx03
{
    class Retangulo
    {
        public double Largura;
        public double Altura;

        public double Area()
        {
            return Largura * Altura;
        }

        public double Perimetro()
        {
            return (Largura + Altura) * 2;
        }

        public double Diagonal()
        {
            return Math.Sqrt(Math.Pow(Altura, 2) + Math.Pow(Largura, 2));
        }

        public override string ToString()
        {
            return 
                $"AREA = {Area().ToString("F2", CultureInfo.InvariantCulture)}\n" +
                $"PERIMETRO = {Perimetro().ToString("F2", CultureInfo.InvariantCulture)}\n" +
                $"DIAGONAL = {Diagonal().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
