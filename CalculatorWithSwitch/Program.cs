
float a, b;
bool IsNumber;

Choice:

Console.WriteLine("Select an operation you want to perform:\n");
Console.WriteLine("1. Addition");
Console.WriteLine("2. Subtraction");
Console.WriteLine("3. Multiplication");
Console.WriteLine("4. Division");
Console.Write("\nPick an option: ");

ConsoleKeyInfo KeyInfo = Console.ReadKey();

if (!(KeyInfo.Key == ConsoleKey.D1 ||
    KeyInfo.Key == ConsoleKey.D2 ||
    KeyInfo.Key == ConsoleKey.D3 ||
    KeyInfo.Key == ConsoleKey.D4))
{
    Console.Clear();
    Console.WriteLine("Wrong input selected:");
    goto Choice;
}

Console.WriteLine();

EnterAgain:
Console.WriteLine("Enter two numbers: ");
IsNumber = float.TryParse(Console.ReadLine(), out a);

NotANumber:
if (!IsNumber) 
{
    Console.Clear();
    Console.WriteLine("Only integers are allowed: ");
    goto EnterAgain;
}

IsNumber = float.TryParse(Console.ReadLine(), out b);

if (!IsNumber)
    goto NotANumber;

switch (KeyInfo) 
{
    case ConsoleKeyInfo when KeyInfo.Key == ConsoleKey.D1:
        Console.WriteLine($"The sum is {a + b}");
        break;

    case ConsoleKeyInfo when KeyInfo.Key == ConsoleKey.D2:
        Console.WriteLine($"The difference is {Math.Abs(a - b)}");
        break;

    case ConsoleKeyInfo when KeyInfo.Key == ConsoleKey.D3:
        Console.WriteLine($"The product is {a * b}");
        break;

    case ConsoleKeyInfo when KeyInfo.Key == ConsoleKey.D4:
        Console.WriteLine($"The division is {(float)a / b}");
        break;
}

Console.Write("Do you want to perform more operations (Y): ");
var more = Console.ReadKey();

if (more.Key == ConsoleKey.Y)
{
    Console.WriteLine();
    goto Choice;
}