int Number = 0;
bool IsPrime = true;

Console.Write("Enter the number: ");
Number = int.Parse(Console.ReadLine());

for (int i = 2; i < Number; i++)
{
    if (Number % i == 0)
    {
        IsPrime = false;
        break;
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