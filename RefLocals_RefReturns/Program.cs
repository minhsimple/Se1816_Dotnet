// See https://aka.ms/new-console-template for more information
int[] numbers = { 1, 2, 3, 4, 5 };

static ref int FindNumber(int target, int[] numbers)
{
    bool flag = true;
    ref int value = ref numbers[0];
    for (int i = 0; i < numbers.Length && flag == true; i++)
    {
        if (numbers[i] == target)
        {
            value = ref numbers[i];
            flag = false;
        }
    }

    return ref value;
}

Console.Write("Original Sequence:");
Console.WriteLine(string.Join(" ", numbers));
ref int value = ref FindNumber(3, numbers);
value *= 2;
Console.Write("New Sequence:     ");
Console.WriteLine(string.Join(" ", numbers));

