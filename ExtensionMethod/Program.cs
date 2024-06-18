namespace ExtensionMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            Person person = new Person("John", 25);
            Console.WriteLine(person.GetPersonInfo());

            if(a.IsEven())
            {
                Console.WriteLine($"{a} is even");
            }
            else
            {
                Console.WriteLine($"{a} is odd");
            }
        }
    }

    public class Person(string name, int age)
    {
        public string Name { get; set; } = name;
        public int Age { get; set; } = age;
    }

    public static class PersonExtension
    {
        public static string GetPersonInfo(this Person person)
        {
            return $"Name: {person.Name}, Age: {person.Age}";
        }
    }

    public static class IntExtension
    {
        public static bool IsEven(this int number)
        {
            return number % 2 == 0;
        }
    }
}
