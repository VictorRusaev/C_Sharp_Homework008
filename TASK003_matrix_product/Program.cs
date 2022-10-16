Console.Clear();

int[,] matrix1 = new int[3, 3];
int[,] matrix2 = new int[3, 3];
FillMatrix(matrix1);
PrintMatrix(matrix1);
Console.WriteLine();
FillMatrix(matrix2);
PrintMatrix(matrix2);
Console.WriteLine();
int[,] productMatrix = MatrixProduct(matrix1, matrix2);
PrintMatrix(productMatrix);

int[,] MatrixProduct(int[,] matr1, int[,] matr2)
{
    int[,] productMatr = new int[matr1.GetLength(0), matr1.GetLength(1)];

    for (int i = 0; i < matr1.GetLength(0); i++)
    {
        for (int j = 0; j < matr1.GetLength(1); j++)
        {
            productMatr[i,j] = matr1[i, j] * matr2[i, j];
        }
    }
    return productMatr;
}

void FillMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
