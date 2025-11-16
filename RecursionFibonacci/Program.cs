
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(Fibonacci(i));
}

int Fibonacci(int n)
{
    if (n <= 1)
        return n;

    return Fibonacci(n - 1) + Fibonacci(n - 2);
}
