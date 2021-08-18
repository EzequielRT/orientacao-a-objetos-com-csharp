using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEx06
{
    class ConversorDeMoeda
    {
        public static double Iof = 6.0;

        public static double Converter(double cotacaoDolar, double qtdDeDolares)
        {
            double valorEmReais = cotacaoDolar * qtdDeDolares;
            return valorEmReais + (valorEmReais * Iof / 100);
        }
    }
}
