
int[,] MatrixA = new int[2, 2];

int[,] MatrixB = new int[2, 2];

int[,] Product = new int[2, 2];

Console.WriteLine("Enter the elements of matrix A:");
foreach (int i in Enumerable.Range(0, MatrixA.GetLength(0)))
{
    foreach (int j in Enumerable.Range(0, MatrixA.GetLength(1)))
    {
        MatrixA[i, j] = int.Parse(Console.ReadLine());
    }
}

Console.WriteLine();
Console.WriteLine("Enter the elements of matrix A:");
foreach (int i in Enumerable.Range(0, MatrixA.GetLength(0)))
{
    foreach (int j in Enumerable.Range(0, MatrixA.GetLength(1)))
    {
        MatrixB[i, j] = int.Parse(Console.ReadLine());
    }
}

for (int i = 0; i < 2; i++)
{
    for (int j = 0; j < 2; j++)
    {
        for (int k = 0; k < 2; k++)
        {
            Product[i, j] += MatrixA[i, k] * MatrixB[k, j];
        }
    }
}

Console.WriteLine();
Console.WriteLine("Resultant Matrix:");
foreach (int i in Enumerable.Range(0, Product.GetLength(0)))
{
    Console.Write("| ");
    foreach (int j in Enumerable.Range(0, Product.GetLength(1)))
    {
        Console.Write(Product[i, j] + " ");
    }
    Console.Write(" |");
    Console.WriteLine();
}