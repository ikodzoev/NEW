//================================================================================================ 
//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// * При выводе матрицы показывать каждую цифру разного цвета(цветов всего 16).
//================================================================================================

// Универсальный метод генерации и заполнение двумерного массива;
double[,] Fill2DArray(int m, int n, int topBorder, int downBorder)
{
    System.Random rand = new System.Random();
    double[,] array2D = new double[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array2D[i, j] = new Random().NextDouble() * topBorder - downBorder;
        }
    }
    return array2D;
}

// Печать двумерного массива;
void Print2DArray(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"|" + Math.Round(matr[i, j], 1));
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

// Цветовая палитра;
ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.Cyan,
                                        ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
                                        ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
                                        ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
                                        ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,
                                        ConsoleColor.Yellow};

// Печать двумерного массива цветом;
void Print2DArrayColored(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.ForegroundColor = col[new System.Random().Next(0, 16)];
            Console.Write($"|" + Math.Round(matr[i, j], 1));
            Console.ResetColor();
        }
        Console.WriteLine();
    }
}

int topBorder = 20; // верхняя граница;
int downBorder = 10; // нижняя граница;
int m = 4; // количество строк;
int n = 4; // количество столбцов;

double[,] array2D = Fill2DArray(m, n, topBorder, downBorder);
Print2DArray(array2D);
Print2DArrayColored(array2D);