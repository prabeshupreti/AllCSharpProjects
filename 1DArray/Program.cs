
int[] Numbers = new int[5];

#region Using for loop

for (int i = 0; i < Numbers.Length; i++) 
{
    Numbers[i] = i;
}

for (int i = 0; i < Numbers.Length; i++)
{
    Console.WriteLine(Numbers[i]);
}
Console.WriteLine();

#endregion

#region Using for each loop

foreach (int i in Enumerable.Range(0, Numbers.Length))
{
    Numbers[i] = i;
}

foreach (int Number in Numbers)
{
    Console.WriteLine(Number);
}
Console.WriteLine();

#endregion