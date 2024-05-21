// See https://aka.ms/new-console-template for more information
Rectangle objRectangle = new Rectangle(10.2F, 20.3F);
ICalculate calculate;
if (objRectangle is ICalculate)
{
    calculate = objRectangle as ICalculate;
    Console.WriteLine("Area : {0:F2}", calculate.Area());
}
else
{
    Console.WriteLine("Interface method not implemented");
}

interface ICalculate
{
    double Area();
}

class Rectangle : ICalculate
{
    float length;
    float width;
    public Rectangle(float x, float y)
    {
        length = x;
        width = y;
    }

    public double Area()
    {
        return length * width;
    }
}
