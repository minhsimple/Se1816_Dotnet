// See https://aka.ms/new-console-template for more information
double salary = 200.234;
string name = "Soren";

string str = $"Name{name,7},Salary{salary,8:N2}";
Console.WriteLine(str);
