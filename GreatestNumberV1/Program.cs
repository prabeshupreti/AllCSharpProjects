int[] Numbers = new int[5];

Console.WriteLine("Enter the numbers: ");

foreach (int i in Enumerable.Range(0, Numbers.Length).ToArray()) 
{
    Numbers[i] = int.Parse(Console.ReadLine());
}

int Max = Numbers[0];

foreach (int i in Enumerable.Range(1, Numbers.Length - 1).ToArray())
{
    if (Max < Numbers[i]) 
    {
        Max = Numbers[i];
    }
}

Console.WriteLine($"The greatest number is {Max}.");

