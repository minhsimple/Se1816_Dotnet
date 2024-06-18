namespace Lambda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = 35;
            int n2 = 45;
            int result;

            Func<int, int, int> addNumber = ((a, b) => a + b);
            result = addNumber(n1, n2);
            Console.WriteLine("Addition: " + result);
        }
    }
}
