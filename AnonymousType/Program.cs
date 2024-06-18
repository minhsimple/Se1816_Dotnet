namespace AnonymousType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var obj = new { id = 1000, name = "jack" };
            Console.WriteLine($"Id: {obj.id}, Name: {obj.name}");

            dynamic obj2 = new { id = 2000, name = "john" };
            Console.WriteLine($"Id: {obj2.id}, Name: {obj2.name}");
        }
    }
}
