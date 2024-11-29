
int Number;
bool IsPrime = true;

Console.Write("Enter a number: ");

bool IsNumber = int.TryParse(Console.ReadLine(), out Number);

if (!IsNumber) 
{
    Console.WriteLine("The number you entered is not an integer.");
    return;
}

if (Number <= 1)
{
    IsPrime = false;
}
else if (Number == 2)
{
    IsPrime = true;
}
else 
{
    for (int i = 2; i * i <= Number; i++)
    {
        if (Number % i == 0)
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