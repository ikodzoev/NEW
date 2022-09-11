// ====================================================================================
// № 29 Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// ====================================================================================
// int ReadData(string line) // чтение данных из консоли
// {
//     //Выводим сообщение
//     Console.WriteLine(line);
//     //Считываем число
//     int number = int.Parse(Console.ReadLine() ?? "0");
//     //Возвращаем значение
//     return number;
// }
void PrintArray(int[] array) // выводим на экран
{
    string arrString = "";

    for (int i = 0; i < array.Length; i++)
    {
        arrString += array[i];
    }

    Console.WriteLine(arrString);
}
int[] GenArray(int arrayLength) // генерируем массив
{
    Random Gen = new Random();
    int[] outArray = new int[arrayLength];
    for (int i = 0; i < arrayLength; i++)
    {
        outArray[i] = Gen.Next(1, 9);
    }
    return outArray;
}
int arrayLength = 8;
int[] outArray = GenArray(arrayLength);
PrintArray(outArray);