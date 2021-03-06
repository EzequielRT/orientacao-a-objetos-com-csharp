namespace ConsoleAppEx20.Entities
{
    class Employee
    {
        public string Name { get; private set; }
        public string Email { get; private set; }
        public double Salary { get; set; }

        public Employee(string name, string email, double salary)
        {
            Name = name;
            Email = email;
            Salary = salary;
        }
    }
}
