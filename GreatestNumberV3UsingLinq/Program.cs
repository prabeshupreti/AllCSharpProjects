Console.WriteLine("Enter 5 numbers: ");

int[] Numbers = Enumerable.Range(0, 5)
                           .Select(_ => int.Parse(Console.ReadLine()))
                           .ToArray();

Console.WriteLine($"The greatest number is {Numbers.Max()}.");