
var fibonacciSeries = Enumerable.Range(0, 10)
            .Select(n => (int)Math.Round((Math.Pow((1 + Math.Sqrt(5)) / 2, n) - Math.Pow((1 - Math.Sqrt(5)) / 2, n)) / Math.Sqrt(5)));

foreach (int i in fibonacciSeries) 
{
    Console.WriteLine($"{i} ");
}