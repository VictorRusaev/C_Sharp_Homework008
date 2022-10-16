Console.Clear();

int[,] matrix = new int[4, 4];
FillSpiralMatrix(matrix);
PrintMatrix(matrix);

void FillSpiralMatrix(int[,] matr, int i = 0, int j = 0)
{
    int number = 1;
    while (number <= matr.GetLength(0) * matr.GetLength(1))
    {
        matr[i, j] = number;
        number++;
        if (i <= j + 1 && i + j < matr.GetLength(1) - 1)
        {
            j++;
        }
        else if (i < j && i + j >= matr.GetLength(0) - 1)
        {
            i++;
        }
        else if (i >= j && i + j > matr.GetLength(1) - 1)
        {
            j--;
        }
        else
        {
            i--;
        }
    }
}

void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (matr[i, j] < 10)
            {
                Console.Write($"0{matr[i, j]} ");
            }
            else
            {
                Console.Write($"{matr[i, j]} ");
            }
        }
        Console.WriteLine();
    }
}

//Поскольку матрица фиксированного размера,
//и в задании не задано значение первого элемента,
//считаю такое тупое решение тоже имеющим право на жизнь))
// int[,] FillMatrix(int[,] matr)
// {
//     matr[0,0] = 1;
//     matr[0,1] = 2;
//     matr[0,2] = 3;
//     matr[0,3] = 4;
//     matr[1,0] = 12;
//     matr[1,1] = 13;
//     matr[1,2] = 14;
//     matr[1,3] = 5;
//     matr[2,0] = 11;
//     matr[2,1] = 16;
//     matr[2,2] = 15;
//     matr[2,3] = 6;
//     matr[3,0] = 10;
//     matr[3,1] = 9;
//     matr[3,2] = 8;
//     matr[3,3] = 7;
//     return matr;
// }

// void PrintMatrix(int[,] matr)
// {
//     Console.Write($"0{matr[0,0]} ");
//     Console.Write($"0{matr[0,1]} ");
//     Console.Write($"0{matr[0,2]} ");
//     Console.Write($"0{matr[0,3]} ");
//     Console.WriteLine();
//     Console.Write($"{matr[1,0]} ");
//     Console.Write($"{matr[1,1]} ");
//     Console.Write($"{matr[1,2]} ");
//     Console.Write($"0{matr[1,3]} ");
//     Console.WriteLine();
//     Console.Write($"{matr[2,0]} ");
//     Console.Write($"{matr[2,1]} ");
//     Console.Write($"{matr[2,2]} ");
//     Console.Write($"0{matr[2,3]} ");
//     Console.WriteLine();
//     Console.Write($"{matr[3,0]} ");
//     Console.Write($"0{matr[3,1]} ");
//     Console.Write($"0{matr[3,2]} ");
//     Console.Write($"0{matr[3,3]} ");
//     Console.WriteLine();
// }
