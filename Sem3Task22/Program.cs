// Напишите программу, которая принимает на вход
// число (N) и выдаёт таблицу квадратов чисел от 1 до N.

int ReadData(string line)
{
    //Выводим сообщение
    Console.WriteLine(line);
    //Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    //Возвращаем значение
    return number;
}

// 
// 
string LineNumbers(int numberN, int pow)
{
    int i = 1;
    string outLine = string.Empty;
    while (i < numberN)
    {
        outLine = outLine + Math.Pow(i, pow) + "\t";
        ++i;
    }
    outLine = outLine +  Math.Pow(numberN, pow);
    return outLine;
}

void PrintResult(string line)
{
    Console.WriteLine(line);
}
// string LineNumbers(int numberN)
// {
//     int i = 1;
//     string outLine = string.Empty;
//     while (i < numberN)
//     {
//         outLine = outLine + i + "\t";
//         ++i;
//     }
//     outLine = outLine + numberN;
//     return outLine;
// }

// string LineSquar(int numberN)
// {
//     int i = 1;
//     string outLine = string.Empty;
//     while (i < numberN)
//     {
//         outLine = outLine + i * i + "\t";
//         ++i;
//     }
//     outLine = outLine + numberN * numberN;
//     return outLine;
// }
// void PrintResult(string line)
// int num = ReadData("Введите число N: ");
// string lineTop = LineNumbers(num);
// string lineDown = LineSquar(num);
// PrintResult(lineTop);
// PrintResult(lineDown);
int num = ReadData("Введите число N: ");

PrintResult(LineNumbers(num, 1));
PrintResult(LineNumbers(num, 2));