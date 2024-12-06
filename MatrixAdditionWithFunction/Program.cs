
int[,] MatrixA = new int[2, 2];
int[,] MatrixB = new int[2, 2];

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

Console.WriteLine();

int[,] Sum = MatrixAddition(MatrixA, MatrixB);
foreach (int i in Enumerable.Range(0, Sum.GetLength(0)))
{
    foreach (int j in Enumerable.Range(0, Sum.GetLength(1)))
    {
        Console.WriteLine(Sum[i, j]);
    }
}

int[,] MatrixAddition(int[,] MatrixA, int[,] MatrixB) 
{
    int[,] MatrixSum = new int[MatrixA.GetLength(0), MatrixA.GetLength(1)];

    foreach (int i in Enumerable.Range(0, MatrixSum.GetLength(0)))
    {
        foreach (int j in Enumerable.Range(0, MatrixSum.GetLength(1)))
        {
            MatrixSum[i, j] = MatrixA[i, j] + MatrixB[i, j];
        }
    }
    return MatrixSum;
}