// ====================================================================================================
// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// ====================================================================================================

// Метод печати двумерного массива;
void Print2DArray(string line, int[,] matr)
{
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

// // Печать результата
// void PrintResult(string prefix, string data)
// {
//     Console.WriteLine(prefix + data);
// }

// Метод заполнения массива случайными числами;
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

// Метод нахождения произведения матриц;
int[,] MultiplyMatrix(int[,] firstMatrix, int[,] secondMatrix, int[,] resultMatrix)
{
    if (MultiplyCorrect(resultMatrix))
    {
        for (int i = 0; i < resultMatrix.GetLength(0); i++)
        {
            for (int j = 0; j < resultMatrix.GetLength(1); j++)
            {
                int sum = 0;
                for (int k = 0; k < firstMatrix.GetLength(1); k++)
                {
                    sum += firstMatrix[i, k] * secondMatrix[k, j];
                }
                resultMatrix[i, j] = sum;
            }
        }
        return resultMatrix;
    }
    else{Console.WriteLine("Матрицы перемножить нельзя!");}
    return resultMatrix;
}

int m = 5;
int n = 5;
int min = 1;
int max = 9;

// Тест на возможность перемножения матриц;
bool MultiplyCorrect(int[,] arr)
{
    if (m == n) { return true; }
    else { return false; }
}

int[,] firstMatrix = new int[m, n];
int[,] secondMatrix = new int[m, n];
int[,] resultMatrix = new int[m, n];

Fill2DArray(firstMatrix, min, max);
Fill2DArray(secondMatrix, min, max);
Print2DArray("Первая матрица: ", firstMatrix);
Print2DArray("Вторая матрица: ", secondMatrix);
Print2DArray("Произведение матриц: ", MultiplyMatrix(firstMatrix, secondMatrix, resultMatrix));
