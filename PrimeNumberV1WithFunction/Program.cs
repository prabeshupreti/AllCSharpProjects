

int Number;

Console.Write("Enter the number: ");
Number = int.Parse(Console.ReadLine());

bool IsPrime = CheckForPrime(Number);

if (IsPrime)
{
    Console.WriteLine($"{Number} is a prime number.");
}
else
{
    Console.WriteLine($"{Number} is not a prime number.");
}

bool CheckForPrime(int N) 
{
    bool IsPrime = true;

    for (int i = 2; i < N; i++)
    {
        if (N % i == 0)
        {
            IsPrime = false;
            break;
        }
    }
    return IsPrime;
}