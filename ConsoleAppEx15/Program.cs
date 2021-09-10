using System;
using System.Globalization;
using ConsoleAppEx15.Entities;
using System.IO;

namespace ConsoleAppEx15
{
    class Program
    {
        static void Main(string[] args)
        {
            // Cria diretório
            string dir = Path.GetTempPath() + @"\Products";
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }

            // Cria subdiretórios
            string subdirIn = dir + @"\In";
            if (!Directory.Exists(subdirIn))
            {
                Directory.CreateDirectory(subdirIn);
            }

            string subdirOut = dir + @"\Out";
            if (!Directory.Exists(subdirOut))
            {
                Directory.CreateDirectory(subdirOut);
            }

            try
            {
                // Cria CSV
                var sourcePath = new FileInfo(subdirIn + @"\itens.csv");
                using (StreamWriter sw = sourcePath.CreateText())
                {
                    sw.WriteLine("TV LED,1290.99,1");
                    sw.WriteLine("Video Game Chair,350.50,3");
                    sw.WriteLine("Iphone X,900.00,2");
                    sw.WriteLine("Samsung Galaxy 9,850.00,2");
                }

                // Cria resumo
                string[] lines = File.ReadAllLines(subdirIn + @"\itens.csv");

                using (StreamWriter sw = File.CreateText(subdirOut + @"\summary.csv"))
                {
                    foreach (string line in lines)
                    {
                        string[] fields = line.Split(',');
                        string name = fields[0];
                        double price = Convert.ToDouble(fields[1], CultureInfo.InvariantCulture);
                        int qtt = Convert.ToInt32(fields[2]);

                        Product prod = new Product(name, price, qtt);

                        sw.WriteLine($"{name},{prod.Total().ToString("F2", CultureInfo.InvariantCulture)}");
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }

        }
    }
}
