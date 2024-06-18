namespace PrimaryConstructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var employee = new Employee("John", "Doe", new DateTime(2021, 1, 1), 50000);
            Console.WriteLine($"Employee: {employee.FirstName} {employee.LastName}");
            Console.WriteLine($"Hire Date: {employee.HireDate}");
            Console.WriteLine($"Salary: {employee.Salary}");
        }
    }

    public class Employee(string firstName, string lastName, DateTime hireDate, decimal salary)
    {
        public string FirstName { get; init; } = firstName;
        public string LastName { get; init; } = lastName;
        public DateTime HireDate { get; init; } = hireDate;
        public decimal Salary { get; init; } = salary;
    }
}
