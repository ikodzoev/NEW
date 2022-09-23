//===============================================================================================================
// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//===============================================================================================================

// Универсальный метод генерации и заполнение двумерного массива;
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

// Печать двумерного массива
void Print2DArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]}  |  ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

// Печать одномерного массива
void Print1DArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " | ");
    }
    Console.WriteLine();
}

// Метод подсчёта суммы элементов в каждом столбце в двумерном массиве;
double[] Count(int[,] array2D)
{
    double[] arr = new double[array2D.GetLength(1)];
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            arr[j] = arr[j] + array2D[i, j];
        }
    }
    return arr;
}

// Метод вычисления среднего арифметического в каждом столбце; 
double[] GetArithMean(int[,] array2D)
{
    double[] arr = Count(array2D);
    for (int k = 0; k < array2D.GetLength(1); k++)
    {
        arr[k] = arr[k] / Math.Round((double)array2D.GetLength(0), 1);
    }
    return arr;
}

int[,] array2D = new int[5, 5];

Fill2DArray(array2D, 0, 9);
Print2DArray(array2D);
Print1DArray(GetArithMean(array2D));
