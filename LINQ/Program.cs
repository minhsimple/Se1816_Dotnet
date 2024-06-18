namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "David", "Jane", "Peter", "John", "Mark" };
            var items = from word in names
                        where word.Contains("a")
                        select word;

            foreach(var item in items)
            {
                Console.WriteLine(item);
            }
        }
    }
}
