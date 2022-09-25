//===============================================================================================
// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
//===============================================================================================

// Универсальный метод считывания данных с консоли;
int ReadData(string line)
{
    // Выводим сообщение;
    Console.WriteLine(line);
    // Считываем число;
    int number = int.Parse(Console.ReadLine() ?? "0");
    // Возвращаем значение;
    return number;
}
// Универсальный метод генерации и заполнение двумерного массива;
int[,] Fill2DArray(int numRow, int numCol, int topBorder, int downBorder)
{
    System.Random rand = new System.Random();
    int[,] array2D = new int[numRow, numCol];

    for (int i = 0; i < numRow; i++)
    {
        for (int j = 0; j < numCol; j++)
        {
            array2D[i, j] = rand.Next(topBorder, downBorder + 1);
        }
    }
    return array2D;
}

// Вывод результата подсчёта;
// void PrintData(string prefix, int data) //разбили на две части вывод в консоль
// {
//     if (data == -1)
//     {
//         Console.WriteLine("Такого элемента в массиве нет!");
//     }
//     else
//     {
//         Console.WriteLine("Элемент в заданной позиции: " + data); //сначала выводим prefix + а потом данные data;
//     }
// }
void PrintData(string prefix, int data) //разбили на две части вывод в консоль
{
    if (data == -1) { Console.WriteLine("Такого элемента в массиве нет!"); }
    else { Console.WriteLine("Элемент в заданной позиции: " + data); } //сначала выводим prefix + а потом данные data;
}

// Печать двумерного массива;
void Print2DArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($" | {matr[i, j]}");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

// Метод поиска элемента в двумерном массиве;
int FindElem(int x, int y, int[,] array2D)
{
    if (x < array2D.GetLength(0) && y < array2D.GetLength(1))
    {
        return array2D[x, y];
    }
    else
    {
        return -1;
    }
}

int numRow = 10;
int numCol = 10;
int topBorder = 10;
int downBorder = 25;
int[,] array2D = Fill2DArray(numRow, numCol, topBorder, downBorder);

Print2DArray(array2D);

int y = ReadData("Введите позицию элемента в массиве по горизонтали: ");
int x = ReadData("Введите позицию элемента в массиве по вертикали: ");

PrintData("", FindElem(x, y, array2D));