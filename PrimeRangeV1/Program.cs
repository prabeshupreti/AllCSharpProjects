
int BeginRange, EndRange;

Console.Write("Enter the start range: ");
BeginRange = int.Parse(Console.ReadLine());

Console.Write("Enter the end range: ");
EndRange = int.Parse(Console.ReadLine());

for (int i = BeginRange; i <= EndRange; i++) 
{
    bool IsPrime = true;
    for (int j = 2; j < i; j++)
    {
        if (i % j == 0)
        {
            IsPrime = false;
            break;
        }
    }
    if (IsPrime) 
    {
        Console.WriteLine(i);
    }
}