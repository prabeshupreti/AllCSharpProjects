
int BeginRange, EndRange;

Console.Write("Enter the start range: ");

bool IsNumber = int.TryParse(Console.ReadLine(), out BeginRange);

if (!IsNumber)
{
    Console.WriteLine("The number you entered is not an integer.");
    return;
}

Console.Write("Enter the end range: ");

IsNumber = int.TryParse(Console.ReadLine(), out EndRange);

if (!IsNumber)
{
    Console.WriteLine("The number you entered is not an integer.");
    return;
}

for (int i = BeginRange; i <= EndRange; i++) 
{
    bool IsPrime = true;
    if (i <= 1)
    {
        IsPrime = false;
    }
    else if (i == 2 || i == 3)
    {
        IsPrime = true;
    }
    else if (i % 2 == 0 || i % 3 == 0)
    {
        IsPrime = false;
    }
    else
    {
        for (int j = 5; j * j <= i; j += 6)
        {
            if (i % j == 0 || i % (j + 2) == 0)
            {
                IsPrime = false;
                break;
            }
        }
    }
    if (IsPrime) 
    {
        Console.WriteLine(i);
    }
}