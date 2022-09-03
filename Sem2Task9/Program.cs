// =======================================================================
// # 9 Напишите программу, которая выводит случайное число из отрезка [10, 99] 
// и показывает наибольшую цифру числа.
//========================================================================
void MyVariant()
{
    Console.WriteLine("Метод1");
    System.Random numberGenerator = new System.Random();

    int number = numberGenerator.Next(10, 100);

    Console.WriteLine(number);

    int firstDigit = number / 10;
    int secondDigit = number % 10;
    // Вариант 1

    if (firstDigit > secondDigit)
    {
        Console.WriteLine(firstDigit);
    }
    else
    {
        Console.WriteLine(secondDigit);
    }
}
void EvgeniyVariant()
{
    Console.WriteLine("Метод2");
    // вариант Евгения
    System.Random numberGenerator = new System.Random();

    int number = numberGenerator.Next(10, 100);

    Console.WriteLine(number);

    int firstDigit = number / 10;
    int secondDigit = number % 10;
    Console.WriteLine((firstDigit > secondDigit) ? firstDigit : secondDigit);
}
void charVariant()
{
    Console.WriteLine("Метод3");
    //Вариант char
    System.Random numberGenerator = new System.Random();

    int number = numberGenerator.Next(10, 100);

    Console.WriteLine(number);

    int firstDigit = number / 10;
    int secondDigit = number % 10;
    char[] charArray = number.ToString().ToCharArray();
    Console.WriteLine(((int)charArray[0] > (int)charArray[1]) ? charArray[0] : charArray[1]);
}
MyVariant();

EvgeniyVariant();

charVariant();