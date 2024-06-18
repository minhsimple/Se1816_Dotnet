namespace DemoSingleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DemoSingleton demoSingleton = DemoSingleton.GetInstance();
            Console.WriteLine("Trying to get another instance");
            DemoSingleton demoSingleton2 = DemoSingleton.GetInstance();
            Console.WriteLine($"Total instances: {demoSingleton2.GetTotalInstances()}");
            if(demoSingleton.Equals(demoSingleton2))
            {
                Console.WriteLine("Both demoSingleton and demoSingleton2 are the same");
            }
            else
            {
                Console.WriteLine("demoSingleton and demoSingleton2 are different");
            }
        }
    }

    //sealed class: This class cannot be inherited
    public sealed class DemoSingleton
    {
        private static readonly DemoSingleton instance;

        private static int totalInstances = 0;

        private DemoSingleton() => Console.WriteLine("Private constructor is called");

        static DemoSingleton()
        {
            Console.WriteLine("Static constructor is called");
            instance = new DemoSingleton();
            totalInstances++;
            Console.WriteLine($"DemoSingleton instance is created. Number of instances: {totalInstances}");
            Console.WriteLine("Exit from static constructor");
        }

        public static DemoSingleton GetInstance() => instance;
        public int GetTotalInstances() => totalInstances;
    }
}
