double range;

Console.Write("Enter the range you want to print of: ");
range = double.Parse(Console.ReadLine());

Fibonacci(range);

void Fibonacci(double range)
{
    double First = 1, Second = 1;
    double Next;
    Console.Write($"{First}, {Second}");

    for (int i = 3; i <= range; i++)
    {
        Next = First + Second;
        Console.Write($", {Next}");
        First = Second;
        Second = Next;
    }
}
