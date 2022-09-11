// ====================================================================================
// № 29 Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// Ввести с клавиатуры длину массива и диапазон значений элементов.
// ====================================================================================
int ReadData(string line) // чтение данных из консоли
{
    //Выводим сообщение
    Console.WriteLine(line);
    //Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    //Возвращаем значение
    return number;
}
void PrintArray(int[] array)
{
    string arrString = "";

    for (int i = 0; i < array.Length; i++)
    {
        arrString += array[i];
    }

    Console.WriteLine(arrString);
}
int[] GenArray(int arrayLength, int Start, int Stop)
{
    Random Gen = new Random();
    int[] outArray = new int[arrayLength];
    for (int i = 0; i < arrayLength; i++)
    {
        outArray[i] = Gen.Next(Start, Stop);
    }
    return outArray;
}
int arrayLength = ReadData("Введите длину массива: ");
int Start = ReadData("Введите начало массива: ");
int Stop = ReadData("Введите конец массива: ");
int[] outArray = GenArray(arrayLength, Start, Stop);
PrintArray(outArray);