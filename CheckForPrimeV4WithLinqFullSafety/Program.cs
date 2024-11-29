
TryAgain:
Console.Write("Enter a Number: ");
bool IsNumber = int.TryParse(Console.ReadLine()!, out int number);

if (IsNumber is not true) 
{
    Console.WriteLine("Your input was not an integer.");
    goto TryAgain;
}
bool isPrime = number > 1 &&
(number == 2 || number == 3 ||
(number % 2 != 0 && number % 3 != 0 &&
               Enumerable.Range(5, Math.Max(0, (int)Math.Sqrt(number) - 4))
                         .Where(i => i % 6 == 1 || i % 6 == 5) // Check only 6k ± 1
                         .All(divisor => number % divisor != 0)));
Console.WriteLine(isPrime
    ? $"{number} is a prime number."
    : $"{number} is not a prime number.");

