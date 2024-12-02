
int[,] MatrixA = new int[2, 2];
int[,] MatrixB = new int[2, 2];
int[,] MatrixSum = new int[2, 2];

Console.WriteLine("Enter the matrix A numbers");
foreach (int i in Enumerable.Range(0, MatrixA.GetLength(0)))
{
    foreach (int j in Enumerable.Range(0, MatrixA.GetLength(1)))
    {
        MatrixA[i, j] = int.Parse(Console.ReadLine());
    }
}

Console.WriteLine();
Console.WriteLine("Enter the matrix B numbers");
foreach (int i in Enumerable.Range(0, MatrixB.GetLength(0)))
{
    foreach (int j in Enumerable.Range(0, MatrixA.GetLength(1)))
    {
        MatrixB[i, j] = int.Parse(Console.ReadLine());
    }
}

foreach (int i in Enumerable.Range(0, MatrixSum.GetLength(0)))
{
    foreach (int j in Enumerable.Range(0, MatrixSum.GetLength(1)))
    {
        MatrixSum[i, j] = MatrixA[i, j] + MatrixB[i, j];
    }
}

Console.WriteLine();
foreach (int i in Enumerable.Range(0, MatrixSum.GetLength(0)))
{
    foreach (int j in Enumerable.Range(0, MatrixSum.GetLength(1)))
    {
        Console.WriteLine(MatrixSum[i, j]);
    }
}

