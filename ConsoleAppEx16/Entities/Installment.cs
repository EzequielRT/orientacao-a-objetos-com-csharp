using System;
using System.Globalization;
using System.Text;

namespace ConsoleAppEx16.Entities
{
    class Installment
    {
        public DateTime DueDate { get; set; }
        public double Amount { get; set; }

        public Installment(DateTime dueDate, double amount)
        {
            DueDate = dueDate;
            Amount = amount;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{DueDate.ToString("dd/MM/yyyy")} - {Amount.ToString("F2", CultureInfo.InvariantCulture)}");

            return sb.ToString();
        }
    }
}
