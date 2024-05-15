// See https://aka.ms/new-console-template for more information
string[] stringArrays = { "12", "Hello", "3.14", "20" };
for (int i = 0; i < stringArrays.Length; i++)
{
    if (int.TryParse(stringArrays[i], out _))
    {
        Console.WriteLine($"{stringArrays[i]}: valid");
    }
    else
    {
        Console.WriteLine($"{stringArrays[i]}: invalid");
    }
}

static (string first, string middle, string last) SplitNames(string fullname)
{
    string[] strArray = fullname.Split(' ');
    return (strArray[0], strArray[1], strArray[2]);
}

var (first, _, last) = SplitNames("Philip F Japikse");
Console.WriteLine($"{first}:{last}");

