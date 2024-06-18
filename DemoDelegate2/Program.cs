namespace DemoDelegate2
{
    public delegate void MyDelegate(string msg);
    internal class Program
    {
        static void InvokeDelegate(MyDelegate dele, string msg) => dele(msg);
        static void Main(string[] args)
        {
            string msg = "Passing delegate as a parameter";
            InvokeDelegate(MyClass.Print, msg);
            InvokeDelegate(MyClass.Show, msg);
        }
    }

    class MyClass
    {
        public static void Print(string msg) => Console.WriteLine($"{msg.ToUpper()}");
        public static void Show(string msg) => Console.WriteLine($"{msg.ToLower()}");
    }
}
