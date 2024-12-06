int Number;

Console.Write("Enter the number: ");
Number = int.Parse(Console.ReadLine());

Console.WriteLine($"The factorial of {Number} is {Factorial(Number)}.");

int Factorial(int N)
{
    int F = 1;
    for (int i = N; i >= 1; i--)
    {
        F *= i;
    }
    return F;
}