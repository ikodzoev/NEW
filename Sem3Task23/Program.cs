//===============================================================================
// № 23 Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.1
//===============================================================================

int ReadData(string line) // чтение данных из сонсоли
{
    //Выводим сообщение
    Console.WriteLine(line);
    //Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    //Возвращаем значение
    return number;
}

string rowNumbers(int numN) // выводим числа
{
    int i = 1;
    string outLine = string.Empty;
    while (i < numN)
    {
        outLine = outLine + i + "\t";
        ++i;
    }
    outLine = outLine + numN;
    return outLine;
}

string rowCubes(int numN) // выводим кубы
{
    int i = 1;
    string outLine = string.Empty;
    while (i < numN)
    {
        outLine = outLine + i * i * i + "\t";
        ++i;
    }
    outLine = outLine + numN * numN * numN;
    return outLine;
}

void PrintData(string line) // выводим данные
{
    Console.WriteLine(line);
}
int num = ReadData("Введите число N: ");
string lineTop = rowNumbers(num);
string lineDown = rowCubes(num);
PrintData(lineTop);
PrintData(lineDown);