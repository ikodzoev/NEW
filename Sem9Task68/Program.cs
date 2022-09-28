// ==============================================================================
// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// ==============================================================================

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
    if (data == 0) { Console.WriteLine("Введите неотрицательное число!"); }
    else { Console.WriteLine("Результат вычисления функции Аккермана: " + data); }
}

// Рекурсивный метод вычисления функции Аккермана;
int GetRecAkker(int M, int N)
{
    if (N >= 0 && M >= 0)
    {
        if (M == 0) return N + 1;
        if (N == 0 && M != 0) return GetRecAkker(M - 1, 1);
        return (GetRecAkker(M - 1, GetRecAkker(M, N - 1)));
    }
    return 0;
}

int M = ReadData("Введите неотрицательное число M: ");
int N = ReadData("Введите неотрицательное число N: ");

int result = GetRecAkker(M, N);
PrintResult(" ", +result);