﻿//============================================================================
// # 13 Напишите программу, которая выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет.
//============================================================================
Console.WriteLine("Введите число: ");
string inputNumber = Console.ReadLine();

//проверка числа на трёхзначность;
if (inputNumber.Length >= 3)
{
    char[] inputNumberArray = inputNumber.ToCharArray();
    Console.WriteLine(inputNumber[2]);
}
else
{
    Console.WriteLine("Третьей цифры у числа нет");
}
//void VitalyVersion()
{
int inputNumber = 0;
int result = 0;

ReadData();
Console.WriteLine("Вариант 1: Цикл");
CalculateData1();
PrintData();
Console.WriteLine("Вариант 2: Логарифм");
CalculateData2();
PrintData();

// Ввод: любое число
void ReadData()
{
    Console.Write("Введите число: ");
    string? inputLine = Console.ReadLine();
    if (inputLine != null) inputNumber = int.Parse(inputLine);

}

// Вычисление: третья цифра, если есть. Вариант 1: цикл.
void CalculateData1()
{
    int temp = inputNumber;
    while (temp >= 1000) temp = temp / 10;
    result = inputNumber < 100 ? -1 : temp % 10;
}

// Вычисление: третья цифра, если есть. Вариант 2: логарифм.
void CalculateData2()
{
    int powNum = (int) Math.Log10(inputNumber);
    result = powNum > 1? inputNumber / (int) Math.Pow(10, powNum - 2) % 10 : -1;
}

// Вывод: результат на консоль
void PrintData() {
    Console.WriteLine(result != -1 ? result : "третьей цифры нет");
}
}