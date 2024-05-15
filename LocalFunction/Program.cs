// See https://aka.ms/new-console-template for more information
int x = 1;
int y = 2;
void AddValue(int a, int b)
{
    Console.WriteLine("Value of a is: {0}", a);
    Console.WriteLine("Value of b is: {0}", b);
    Console.WriteLine("Value of x is: {0}", x);
    Console.WriteLine("Value of y is: {0}", y);
    Console.WriteLine("Sum: {0}", a + b + x + y);
    Console.WriteLine();
}
AddValue(3, 4);
AddValue(5, 6);


