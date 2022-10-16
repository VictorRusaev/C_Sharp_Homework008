Console.Clear();

int[,] matrix = new int[5, 5];
FillMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine();
SortMatrix(matrix);


void SortMatrix(int[,] matr, int counter = 0)
{
    if(counter < matr.GetLength(0))
    {
        int[] row = MatrixToArray(matr, counter);
        SortArray(row);
        Console.WriteLine();
        counter++;
        SortMatrix(matr, counter);
    }
}

void SortArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        for (int j = i + 1; j < arr.Length; j++)
        {
            if (arr[j] > arr[i])
            {
                int k = arr[j];
                arr[j] = arr[i];
                arr[i] = k;
            }
        }
        Console.Write($"{arr[i]} ");
    }
}

int[] MatrixToArray(int[,] matr, int counter = 0)
{
    int[] array = new int[matr.GetLength(1)];
    int indexArray = 0;

    for (int i = 0; i < matr.GetLength(1); i++)
    {
        array[indexArray] = matr[counter, i];
        indexArray++;
    }
    return array;
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
