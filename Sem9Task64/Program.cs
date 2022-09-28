// ============================================================================
// Задача 64: Задайте значение N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// ============================================================================

// Чтение данных из консоли
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Метод, принимает строку, выводит в консоль
void PrintResult(string line)
{
    Console.WriteLine("Натуральные числа в промежутке от N до 1 и обратно: ");
    Console.WriteLine(line);
}

// Рекурсивный метод выведения чисел
string RecurLine(int N) 
{
    if (N == 0) return " ";
    string res = N + " | " + RecurLine(N - 1) + " | " + N;
    return res;
}

int N = ReadData("Введите число N: ");
string result = RecurLine(N);
PrintResult(result);
