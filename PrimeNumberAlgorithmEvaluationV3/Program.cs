using System.Diagnostics;

int MaxRange = 400000;
Stopwatch Stopwatch = Stopwatch.StartNew();

Console.WriteLine("Starting diagnostics: ");

Stopwatch.Start();
for (int i = 1; i <= MaxRange; i++)
{
    bool IsPrime = true;
    if (i <= 1)
    {
        IsPrime = false;
    }
    else if (i == 2 || i == 3)
    {
        IsPrime = true;
    }
    else if (i % 2 == 0 || i % 3 == 0)
    {
        IsPrime = false;
    }
    else
    {
        for (int j = 5; j * j <= i; j += 6)
        {
            if (i % j == 0 || i % (j + 2) == 0)
            {
                IsPrime = false;
                break;
            }
        }
    }
}

Stopwatch.Stop();

//Will normally take 32 miliseconds or less on full CPU power.
Console.WriteLine($"Elapsed time to evaluate {MaxRange} is {Stopwatch.Elapsed.ToString(@"mm\:ss\:fffffff")}.");