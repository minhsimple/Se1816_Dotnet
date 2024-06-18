namespace AnonymousMethod
{
    public delegate void MyDele(int value);
    internal class Program
    {
        static void Main(string[] args)
        {
            MyDele printValue = delegate (int value)
            {
                Console.WriteLine("Inside Anonymous method. Value: {0}", value);
            };
            printValue += delegate
            {
                Console.WriteLine("This is Anonymous method");
            };
            printValue(100);
        }
    }
}
