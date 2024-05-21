// See https://aka.ms/new-console-template for more information
class Program
{
    public static void Main(string[] args)
    {
        A a = new A();
        Console.WriteLine("**********");
        a = new B();
        Console.WriteLine("**********");
        a = new C();
        Console.WriteLine("**********");
        a = new B();

    }
}

class A
{
    static int x = 10;
    int y = 20;

    static A()
    {
        x = 15;
        int z;
        Console.WriteLine("Static Constructor A" + x);
        m1();
    }

    public A()
    {
        Console.WriteLine("Instance Constructor A");
    }

    static void m1()
    {
        Console.WriteLine("Static Method in A");
    }
}

class B : A
{
    static int xb = 10;

    static B()
    {
        xb = 15;
        Console.WriteLine("Static Constructor B" + xb);
    }

    public B()
    {
        Console.WriteLine("Instance Constructor B");
    }
}

class C : B
{
    static int xc = 10;

    static C()
    {
        xc = 15;
        int z;
        Console.WriteLine("Static Constructor C" + xc);
    }

    public C()
    {
        Console.WriteLine("Instance Constructor C");
    }
}
