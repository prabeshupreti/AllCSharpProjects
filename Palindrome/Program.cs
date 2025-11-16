
int Number;

Console.Write("Enter a number: ");
Number = int.Parse(Console.ReadLine());

int OriginalNumber = Number;
int ReversedNumber = 0;

while (Number != 0)
{
    int Remainder = Number % 10;
    ReversedNumber = ReversedNumber * 10 + Remainder;
    Number = Number / 10;
}

if (OriginalNumber == ReversedNumber)
{
    Console.WriteLine("The given number is palindrome.");
}
else
{
    Console.WriteLine("The given number is not palindrome.");
}