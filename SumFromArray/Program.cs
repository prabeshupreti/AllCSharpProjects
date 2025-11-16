

int[] Numbers = new int[5];
int Smallest = 0;

Console.WriteLine("Enter the numbers: ");

for (int i = 0; i < Numbers.Length; i++)
{
    Numbers[i] = int.Parse(Console.ReadLine());
}

Smallest = Numbers[0];

for (int i = 1; i < Numbers.Length; i++)
{
    if (Numbers[i] <= Smallest)
    {
        Smallest = Numbers[i];
    }
}

Console.WriteLine($"The Smallest number is {Smallest}.");