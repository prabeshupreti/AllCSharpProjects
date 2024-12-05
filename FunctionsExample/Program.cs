
#region Method with no parameters and no return value
void NoParametersNoReturn() 
{
    Console.WriteLine("Hello, World");
}
#endregion

#region Method with parameters but no return value
void ParametersNoReturn(string Name)
{
    Console.WriteLine($"Hello {Name}, How can I help you today?");
}
#endregion

#region Method with no parameters but return value
string NoParametersButReturns()
{

    return $"I'm just here to return random value which is {new Random().Next(int.MinValue, int.MaxValue)}";
}
#endregion

#region Method with both parameters and return value
int BothParametersAndReturns(int a, int b)
{

    return a + b;
}
#endregion

#region Recursive Function
int SumToRange(int Range) 
{
    if (Range >= 0)
    {
        return 0;
    }
    else 
    {
        return Range + SumToRange(Range - 1);
    }
}
#endregion