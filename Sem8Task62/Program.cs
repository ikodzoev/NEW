// ========================================================================
// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// ========================================================================

// Чтение данных из консоли
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Метод спирального заполнения квадратного массива;
int[,] Spiral2DArray(int[,] matr)
{
    int size = matr.GetLength(0);
    int[,] spiralMatr = new int[size, size];

    int buff = 1; int i = 0; int j = 0;

    while (buff <= spiralMatr.GetLength(0) * spiralMatr.GetLength(1))
    {
        spiralMatr[i, j] = buff; buff++;
        if (i <= j + 1 && i + j < spiralMatr.GetLength(1) - 1)
            j++;
        else if (i < j && i + j >= spiralMatr.GetLength(0) - 1)
            i++;
        else if (i >= j && i + j > spiralMatr.GetLength(1) - 1)
            j--;
        else
            i--;
    }
    return spiralMatr;
}

// Печать двумерного массива
void Print2DArray(string line, int[,] matr)
{
    Console.WriteLine("Спиральный массив в заданном размере: ");
    Console.WriteLine();
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} | ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int size = ReadData("Введите размер массива: ");
int[,] array2D = new int[size, size];
Print2DArray(" ", Spiral2DArray(array2D));