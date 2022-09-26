// =================================================================
// Задача 54: Задайте двумерный массив. Напишите программу, которая 
// упорядочит по убыванию элементы каждой строки двумерного массива.
// =================================================================

// Печать двумерного массива
// void Print2DArray(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             Console.Write($"{matr[i, j]} ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

void Print2DArray(string line, int[,] matr)
{
    Console.WriteLine();
    Console.WriteLine(line);
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

// Заполняем массив случайными числами
void Fill2DArray(int[,] matr, int min, int max)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(min, max + 1);
        }
    }
}

// Метод сортировки массива по убыванию;
int[,] UpdateArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        List<int> Row = new List<int>();
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Row.Add(arr[i, j]);
            Row.Sort();
            Row.Reverse();
        }
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = Row[j];
        }
    }
    return arr;
}

// // Метод сортировки массива по убыванию;
// int[,] UpdateArray(int[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             for (int k = 0; k < arr.GetLength(1) - 1; k++)
//             {
//                 if (arr[i, k] < arr[i, k + 1])
//                 {
//                     int buf = arr[i, k + 1];
//                     arr[i, k + 1] = arr[i, k];
//                     arr[i, k] = buf;
//                 }
//             }
//         }
//     }
//     return arr;
// }

int m = 5;
int n = 9;
int min = 1;
int max = 9;
int[,] array2D = new int[m, n];

Fill2DArray(array2D, min, max);
Print2DArray("Массив случайных чисел: ", array2D);
Print2DArray("Массив чисел, упорядоченных по убыванию: ", UpdateArray(array2D));