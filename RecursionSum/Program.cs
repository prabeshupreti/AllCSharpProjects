

int result = SumNaturalNumbers(5);

int SumNaturalNumbers(int N)
{
    if (N == 0)
    {
        return 0;
    }
    else
    {
        return N + SumNaturalNumbers(N - 1);
    }
}