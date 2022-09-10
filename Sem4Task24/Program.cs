int ReadData(string line) // чтение данных из консоли
{
    //Выводим сообщение
    Console.WriteLine(line);
    //Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    //Возвращаем значение
    return number;
}

// Метод вывода результатов
void PrintResult(string line)
{
    Console.WriteLine(line);
}
int VariantSumSimple(int numA)
{
    int sumOfNumbers = 0;
    for (int i = 0; i <= numA; i++)
    {
        sumOfNumbers += i;
    }
    return sumOfNumbers;
}

int VariantSumGauss(int numA)
{
    int sumOfNumbers = 0;
    sumOfNumbers = ((1 + numA) * numA) / 2;
    return sumOfNumbers;
}
int numberA = ReadData("Введите число А: ");
int res1 = VariantSumSimple(numberA);
int res2 = VariantSumGauss(numberA);
PrintResult("Сумма чисел от 1 до А равна(простой метод):" + res1);
PrintResult("Сумма чисел от 1 до А равна(метод Гаусса):" + res2);