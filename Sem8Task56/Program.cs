// ======================================================================
// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// ======================================================================

// Печать двумерного массива;
void Print2DArray(int[,] matr)
{
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

// Печать результата;
void PrintResult(string prefix, string data)
{
    Console.WriteLine(prefix + data);
}

// Заполняем массив случайными числами;
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

// Метод поиска строки с наименьшей суммой элементов;
int FindMinRow(int[,] arr)
{
    int outIndexRow = -1;
    int min = int.MaxValue;
    int sum = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++) { sum += arr[i, j]; }
        if (min > sum) { min = sum; outIndexRow = i; }
        sum = 0;
    }
    return outIndexRow + 1;
}

// Метод поиска строки с наименьшей суммой элементов;
// int FindMinRow(int[,] arr)
// {
//     int minSumRow = 0;
//     int Sum = SumRows(arr, 0);
//     for (int i = 1; i < arr.GetLength(0); i++)
//     {
//         int bufSum = SumRows(arr, i);
//         if (Sum > bufSum)
//         {
//             Sum = bufSum;
//             minSumRow = i;
//         }
//     }
//     return minSumRow + 1;
// }

// // Метод нахождения суммы элементов в строке;
// int SumRows(int[,] arr, int i)
// {
//     int Sum = arr[i, 0];
//     for (int j = 1; j < arr.GetLength(1); j++)
//     {
//         Sum += arr[i, j];
//     }
//     return Sum;
// }

int m = 4;
int n = 5;
int min = 1;
int max = 9;

int[,] matrix = new int[m, n];
Fill2DArray(matrix, min, max);
Print2DArray(matrix);
int result = FindMinRow(matrix);
PrintResult("Строка с наименьшей суммой: ", "№ " + result + " сверху вниз");
// PrintResult(" ", "Строка с наименьшей суммой: " + FindMinRow(matrix));
