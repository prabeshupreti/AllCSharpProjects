using static System.Runtime.InteropServices.JavaScript.JSType;

int Number;
bool IsPrime = true;

Console.Write("Enter a number: ");

bool IsNumber = int.TryParse(Console.ReadLine(), out Number);

if (!IsNumber)
{
    Console.WriteLine("The Number you entered is not an integer.");
    return;
}

if (Number <= 1)
{
    IsPrime = false;
}
else if (Number == 2 || Number == 3)
{
    IsPrime = true;
}
else if (Number % 2 == 0 || Number % 3 == 0)
{
    IsPrime = false;
}
else
{
    for (int i = 5; i * i <= Number; i += 6)
    {
        if (Number % i == 0 || Number % (i + 2) == 0)
        {
            IsPrime = false;
            break;
        }
    }
}

if (IsPrime)
{
    Console.WriteLine($"{Number} is a prime number.");
}
else
{
    Console.WriteLine($"{Number} is not a prime number.");
}