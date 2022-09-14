// ==============================================================================
// №34 Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
//===============================================================================

int[] FillArray(int length, int topBorder, int downBorder) // Универсальный метод генерации и заполнение массива
{
    Random rand = new Random();
    int[] array = new int[length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(topBorder, downBorder + 1);
    }
    return array;
}

void PrintArray(int[] array) // вывод массива
{
    Console.WriteLine("[{0}]", string.Join(", ", array));
}

void PrintData(int numberEvenNums) // вывод результата подсчёта
{
    Console.WriteLine(numberEvenNums);
}

int EvenCount(int[] array) // подсчёт кол-ва чётных чисел в массиве
{
    int numberEvenNums = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (EvenTest(array[i])) numberEvenNums++;
    }
    return numberEvenNums;
}

bool EvenTest(int numberEvenNums) // тест на чётность числа
{
    return (numberEvenNums % 2 == 0);
}

int[] array = FillArray(10, 100, 1000);

PrintArray(array);
PrintData(EvenCount(array));