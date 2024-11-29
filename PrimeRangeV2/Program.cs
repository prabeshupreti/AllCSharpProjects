using static System.Runtime.InteropServices.JavaScript.JSType;

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
    else if (i == 2)
    {
        IsPrime = true;
    }
    else
    {
        for (int j = 2; j * j <= i; j++)
        {
            if (i % j == 0)
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