namespace ObjectInitialize
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ObjectInitialize
            var customer = new Customer() { Age = "20", Name = "John" };

            //Using Extension Method
            Console.WriteLine(customer.GetCustomerName());
        }
    }

    public class Customer
    {
        public string Name { get; set; }
        public string Age { get; set; }
    }

    public static class CustomerExtension
    {
        public static string GetCustomerName(this Customer customer)
        {
            return $"Name: {customer.Name}, Age: {customer.Age}";
        }
    }
}
