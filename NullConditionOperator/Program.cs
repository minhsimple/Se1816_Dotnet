// See https://aka.ms/new-console-template for more information
int[] array1 = null;
Console.WriteLine($"{array1?.Length.ToString() ?? "Array is null"}");

array1 = new int[] { 2, 1, 3 };
dynamic[] array2 = { array1, null };
var s = array2?[0]?.Length ?? "Array is null";
Console.WriteLine($"{s}");
s = array2?[1]?.Length ?? "Array is null";
Console.WriteLine($"{s}");

