Console.Clear();

int[,] matrix = new int[5, 4];
FillMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine();
int[] sum = new int[matrix.GetLength(0)];
ArrayOfSums(sum, matrix);
// Console.Write(String.Join(", ", sum));
// Console.WriteLine();
Console.WriteLine($"Минимальная сумма элементов в {FindMin(sum)} строке.");

int FindMin(int[] arr)
{
    int minResult = 100;
    int minIndex = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i] < minResult)
        {
            minResult = arr[i];
            minIndex = i;
        }
    }
    return minIndex + 1;
}

int[] ArrayOfSums(int[] arr, int[,] matr, int counter = 0)
{
    if (counter < matr.GetLength(0))
    {
        int[] row = MatrixToArray(matr, counter);
        arr[counter] = ArraySum(row);
        counter++;
        ArrayOfSums(arr, matr, counter);
    }
    return arr;
}

int ArraySum(int[] arr)
{
    int arraySum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        arraySum = arraySum + arr[i];
    }
    return arraySum;
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
