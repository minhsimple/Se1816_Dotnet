// See https://aka.ms/new-console-template for more information
Shape p = new Circle();
p.Display();
p.Draw();
Console.WriteLine("---------------------------");
p = new Rectangle();
p.Display();
p.Draw();
p.Print();

public abstract class Shape
{
    public int Height { get; set; }
    public int Width { get; set; }

    public virtual void Draw()
    {
        Console.WriteLine("Performing base class Drawing tasks");
    }

    public void Print()
    {
        Console.WriteLine("Performing base class Printing tasks");
    }

    public abstract void Display();
}

public class Circle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a Circle");
    }

    public override void Display()
    {
        Console.WriteLine("Displaying Circle");
    }
}

public class Rectangle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a Rectangle");
    }

    public override void Display()
    {
        Console.WriteLine("Displaying Rectangle");
    }

    public new void Print()
    {
        Console.WriteLine("Print Rectangle");
    }
}
