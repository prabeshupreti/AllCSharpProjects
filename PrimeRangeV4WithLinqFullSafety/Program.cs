
TryAgain:
Console.WriteLine("Enter the range (start and end):");
if (!int.TryParse(Console.ReadLine(), out int BeginRange) || 
    !int.TryParse(Console.ReadLine(), out int EndRange))
{
    Console.WriteLine("Your input was not an integer.");
    goto TryAgain;
}

Enumerable.Range(Math.Max(BeginRange, 2), Math.Max(0, EndRange - Math.Max(BeginRange, 2) + 1))
                       .Where(n => n == 2 || n == 3 ||
                                   (n % 2 != 0 && n % 3 != 0 &&
                                    Enumerable.Range(5, Math.Max(0, (int)Math.Sqrt(n) - 4))
                                              .Where(d => d % 6 == 1 || d % 6 == 5)
                                              .All(divisor => n % divisor != 0)))
                       .ToList()
                        .ForEach(x => Console.Write($"{x} "));