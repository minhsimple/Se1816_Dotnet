// See https://aka.ms/new-console-template for more information
dynamic myValue = 0;
Console.WriteLine("myValue is a: {0}", myValue.GetType().Name);
myValue = true;
Console.WriteLine("myValue is a: {0}", myValue.GetType().Name);
myValue = "Hello World!";
Console.WriteLine("myValue is a: {0}", myValue.GetType().Name);
myValue = 0.5;
Console.WriteLine("myValue is a: {0}", myValue.GetType().Name);