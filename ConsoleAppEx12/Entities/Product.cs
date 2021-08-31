using System.Text;
using System.Globalization;

namespace ConsoleAppEx12.Entities
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; protected set; }

        public Product()
        {
        }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public virtual string PriceTag()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{Name} ${Price.ToString("F2", CultureInfo.InvariantCulture)}");

            return sb.ToString();
        }
    }
}
