namespace MulticastDelegate
{
    public delegate void MyDelegate(string message);
    internal class Program
    {
        static void Main(string[] args)
        {
            string msg = "Multicast Delegate";

            MyDelegate myDele01 = MyClass.Print;
            MyDelegate myDele02 = MyClass.Show;
            Console.WriteLine("***Combine myDele01 + myDele02***");
            MyDelegate myDele = myDele01 + myDele02;
            myDele(msg);
            Console.WriteLine("***Combine myDele01 + myDele02 + myDele03***");
            MyDelegate myDele03 = MyClass.Display;
            myDele += myDele03;
            myDele(msg);
            Console.WriteLine("---------------------------");
            Console.WriteLine("***Remove myDele02***");
            myDele -= myDele02;
            myDele("Hello World !");
        }
    }

    class MyClass
    {
        public static void Print(string message) => Console.WriteLine($"{message.ToUpper()}");
        public static void Show(string message) => Console.WriteLine($"{message.ToLower()}");
        public static void Display(string message) => Console.WriteLine($"{message}");
    }
}
