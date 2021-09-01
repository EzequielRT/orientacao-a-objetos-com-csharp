namespace ConsoleAppEx13.Entities
{
    class Company : TaxPayer
    {
        public int NumberEmployees { get; set; }

        public Company()
        {
        }

        public Company(string name, double anualIncome, int numberEmployees) : base(name, anualIncome)
        {
            NumberEmployees = numberEmployees;
        }

        public override double Tax()
        {
            double totalTaxes = (NumberEmployees > 10) ? AnualIncome * 0.14 : AnualIncome * 0.16;

            return totalTaxes;
        }
    }
}
