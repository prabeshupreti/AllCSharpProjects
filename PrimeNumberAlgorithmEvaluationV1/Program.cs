
using System.Diagnostics;

int MaxRange = 400000;
Stopwatch Stopwatch = Stopwatch.StartNew();

Console.WriteLine("Starting diagnostics: ");

Stopwatch.Start();
for (int i = 1; i <= MaxRange; i++)
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
}

Stopwatch.Stop();

//Will normally take more than 22 seconds on full CPU power.
Console.WriteLine($"Elapsed time to evaluate {MaxRange} is {Stopwatch.Elapsed.ToString(@"mm\:ss\:fffffff")}.");