namespace DemoDelegate
{
    public delegate int myDelegate(int x, int y);
    internal class Program
    {
        public int Sum(int x, int y) => x + y;
        public int Sub(int x, int y) => x - y;
        public int Multi(int x, int y) => x * y;
        static void Main(string[] args)
        {
            Program p = new Program();
            int x = 10, y = 3;
            myDelegate my = new myDelegate(p.Multi);

            Console.WriteLine($"Ket qua = {my(x, y)}");
        }
    }
}



