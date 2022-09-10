// ===========================================================================================================
//№ 25 Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//============================================================================================================
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
long ExpoNum(int numberA, int numberB) // возводим в степень
{
    long res = 1;
    for (int i = 0; i < numberB; i++)
    {
        res = res * numberA;
    }
    return res;
}

int numberA = ReadData("Введите число A: ");
int numberB = ReadData("Введите число B: ");
long res = ExpoNum(numberA, numberB);
PrintData("Число A в степени B будет: " + res);