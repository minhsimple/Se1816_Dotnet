// See https://aka.ms/new-console-template for more information
void AreaOfCircle(double a)
{
    double ar;
    Console.WriteLine("Radius of circle: " + a);
    ar = 3.14 * a * a;
    Console.WriteLine("Area of circle: " + ar);
    Circumference(a);

    static void Circumference(double radii)
    {
        double cr;
        cr = 2 * 3.14 * radii;
        Console.WriteLine($"Circumference of circle is:{cr:N2}");
    }
}
AreaOfCircle(10);
