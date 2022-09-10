//======================================================================================
// № 27 Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//======================================================================================
int ReadData(string line) // чтение данных из консоли
{
    //Выводим сообщение
    Console.WriteLine(line);
    //Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    //Возвращаем значение
    return number;
}
void PrintData(string line) // выводим данные
{
    Console.WriteLine(line);
}
int SumDigitNumb(int numberN) // суммируем
{
    int sum = 0;
    while (numberN > 0)
    {
        sum += numberN % 10;
        numberN = numberN / 10;
    }
    return sum;
}
int numberN = ReadData("Введите число: ");
int sum = SumDigitNumb(numberN);
PrintData("Сумма цифр в числе: " + sum);