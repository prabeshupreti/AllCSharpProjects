
int Number = 9;

Console.Write(Number);

while (Number != 1)
{
    if (Number % 2 != 0)
    {
        Number = 3 * Number + 1;
    }
    else
    {
        Number = Number / 2;
    }
    Console.Write($", {Number}");
}

