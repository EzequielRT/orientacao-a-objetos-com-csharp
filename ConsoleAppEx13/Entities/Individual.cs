namespace ConsoleAppEx13.Entities
{
    class Individual : TaxPayer
    {
        public double HealthExpenditures { get; set; }

        public Individual()
        {
        }

        public Individual(string name, double anualIncome, double healthExpenditures) : base(name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double Tax()
        {
            double taxIncome = (AnualIncome < 20000.00) ? AnualIncome * 0.15 : AnualIncome * 0.25;
            double discountHealthExpenditures = HealthExpenditures * 0.50;
            double totalTaxes = taxIncome - discountHealthExpenditures;

            return totalTaxes;
        }
    }
}
