//==============================================================================================================
// № 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом
//==============================================================================================================

int ReadData(string line) // чтение данных из сонсоли
{
    //Выводим сообщение
    Console.WriteLine(line);
    //Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    //Возвращаем значение
    return number;
}

bool fiveDigitTest(int numPal) // проверка числа на пятизначность
{
    if (numPal > 9999 && numPal < 100000)
    {
        return true;
    }
    else
    {
        return false;
    }
}

bool PalindromeTest(int numPal) // проверка числа на палиндром
{
    if ((numPal / 10000 == numPal % 10) && (numPal / 1000) % 10 == (numPal / 10) % 10)
    {
        return true;
    }
    else
    {
        return false;
    }
}

void PrintData(int numPal) // вывод данных
{
    if (fiveDigitTest(numPal))
    {
        if (PalindromeTest(numPal))
        {
            Console.WriteLine("Это палиндром");
        }
        else
        {
            Console.WriteLine("Это не палиндром");
        }
    }
    else
    {
        Console.WriteLine("Это не пятизначное число!");
    }
}

int numPal = ReadData("Введите пятизначное число: ");

PrintData(numPal);