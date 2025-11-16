
Console.WriteLine(Power(4, 2)); // 16

int Power(int x, int n)
{
    if (n == 0)
        return 1;

    return x * Power(x, n - 1);
}
