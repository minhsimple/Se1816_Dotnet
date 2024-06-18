namespace List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>()
            {
                new Person { FirstName = "John", LastName = "Doe", Age = 25 },
                new Person { FirstName = "Jane", LastName = "Doe", Age = 26 },
                new Person { FirstName = "Tom", LastName = "Smith", Age = 30 }
            };

            Console.WriteLine($"Number of people: {people.Count}");

            foreach(Person p in people)
            {
                Console.WriteLine(p);
            }
        }
    }

    public class Person
    {
        public int Age { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName}, Age: {Age}";
        }
    }
}
