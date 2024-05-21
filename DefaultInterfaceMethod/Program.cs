// See https://aka.ms/new-console-template for more information
string str;
MySample obj = new MySample();
obj.Display();
ISample.Print();
ISample sample = obj;
str = sample.GetString("Jack");
Console.WriteLine(str);

public interface ISample
{
    static void Print()
    {
        Console.WriteLine("Welcome to .Net");
    }

    string GetString(string s)
    {
        return "Hello " + s;
    }

    void Display();
}

public class MySample : ISample
{
    public void Display()
    {
        Console.WriteLine("Hi!");
    }
}



