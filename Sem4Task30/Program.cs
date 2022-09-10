//=================================================================
// # 30 Напишите программу, которая выводит массив из 8 элементов, 
// заполненный нулями и единицами в случайном порядке.
//=================================================================
void PrintArray(int[] arr)
{
    string arrString = "";

    for (int i = 0; i < arr.Length; i++)
    {
        arrString += arr[i];
    }

    Console.WriteLine(arrString);
}

int[] GenArray(int arrLength)
{
    int[] array = new int[arrLength];

    for (int i = 0; i < arrLength; i++)
    {
        array[i] = new Random().Next(0, 2);
    }
    return array;
}

int[] array = GenArray(8);
PrintArray(array);
