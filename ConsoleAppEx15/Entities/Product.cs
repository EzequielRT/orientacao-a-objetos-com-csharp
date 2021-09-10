using System.Globalization;

namespace ConsoleAppEx15.Entities
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        public Product(string name, double value, int quantity)
        {
            Name = name;
            Price = value;
            Quantity = quantity;
        }

        public double Total()
        {
            return Price * Quantity;
        }
    }
}
