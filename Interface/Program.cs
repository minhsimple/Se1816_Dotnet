// See https://aka.ms/new-console-template for more information
public interface IFirst
{
    void Print();
    void Display();
}
public interface ISecond
{
    void Print();
}

public class  MyClass : IFirst, ISecond
{
    void IFirst.Print()
    {
        Console.WriteLine("IFirst Print");
    }

    public void Display()
    {
        Console.WriteLine("Display");
    }

    void ISecond.Print()
    {
        Console.WriteLine("ISecond Print");
    }
}

class Using
{
    public static void Main()
    {
        MyClass obj = new MyClass();
        obj.Display();
        IFirst f  = obj;
        f.Print();
        ISecond s = obj;
        s.Print();
        Console.WriteLine("-------------------------------");
        IFirst f1 = new MyClass();
        f1.Print();
        ISecond s1 = new MyClass();
        s1.Print();
        ((MyClass)s1).Display();

    }
}
