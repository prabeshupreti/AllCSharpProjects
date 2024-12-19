using System.Diagnostics;

int MaxRange = 900000;
Stopwatch Stopwatch = Stopwatch.StartNew();

Console.WriteLine("Starting diagnostics: ");

Stopwatch.Start();

Enumerable.Range(Math.Max(1, 2), Math.Max(0, MaxRange - Math.Max(1, 2) + 1))
                       .Where(n => n == 2 || n == 3 ||
                                   (n % 2 != 0 && n % 3 != 0 &&
                                    Enumerable.Range(5, Math.Max(0, (int)Math.Sqrt(n) - 4))
                                              .Where(d => d % 6 == 1 || d % 6 == 5)
                                              .All(divisor => n % divisor != 0)))
                       .ToList();

Stopwatch.Stop();

//Will normally take a second or less. Slower than the version 3 due to LINQ abstractions.
//If not converted to list, Enumeration will talke no time due to defer algorithm.
Console.WriteLine($"Elapsed time to evaluate {MaxRange} is {Stopwatch.Elapsed.ToString(@"mm\:ss\:fffffff")}.");