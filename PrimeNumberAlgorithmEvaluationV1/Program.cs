
using System.Diagnostics;

int MaxRange = 900000;
Stopwatch Stopwatch = Stopwatch.StartNew();

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

//Will normally take more than 2 minutes.
Console.WriteLine($"Elapsed time to evaluate {MaxRange} is {Stopwatch.Elapsed.ToString(@"mm\:ss\:fffffff")}.");