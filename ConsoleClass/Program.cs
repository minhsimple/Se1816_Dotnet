// See https://aka.ms/new-console-template for more information
double d;
int i;
string s;
DateTime date;
Console.WriteLine("************Data Type Parsing**********");
Console.Write("Enter a String value:");
s = Console.ReadLine();
Console.Write("Enter a Double value:");
d = double.Parse(Console.ReadLine());
Console.Write("Enter an Integer value:");
i = int.Parse(Console.ReadLine());
Console.Write("Enter a Date value:");
date = DateTime.Parse(Console.ReadLine());
Console.WriteLine($"Value of s:{s}, i:{i}, d:{d}, date:{date:dd/MM/yyyy}");
