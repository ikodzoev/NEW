// ==================================================================
// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// ==================================================================

// Чтение данных из консоли
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Метод, принимает строку, выводит в консоль
void PrintResult(string prefix, int data)
{
    if (data == 0) { Console.WriteLine("Число N должно быть больше или равно M!"); }
    else { Console.WriteLine("Сумма натуральных чисел в промежутке от M до N: " + data); }
}

// Рекурсивный метод;
int RecurSum(int M, int N)
{
    if (N >= M)
    {
        if (M == N) { return M; }
        else { return M + RecurSum(M + 1, N); }
    }
    else return 0;
}

int M = ReadData("Введите число M: ");
int N = ReadData("Введите число N: ");

int result = RecurSum(M, N);
PrintResult(" ", +result);