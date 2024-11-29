int range;
int First = 1, Second = 1;
int Next;

Console.Write("Enter the range you want to print of: ");
range = int.Parse(Console.ReadLine());

Console.Write($"{First}, {Second}");

for (int i = 3; i <= range; i++) 
{
    Next = First + Second;
    Console.Write($", {Next}");
    First = Second;
    Second = Next;
}