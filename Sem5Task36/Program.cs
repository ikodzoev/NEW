// ==============================================================
// №36 Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// ==============================================================
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

void PrintData(int sumOddPos) // вывод результата подсчёта
{
    Console.WriteLine(sumOddPos);
}

int EvenSumPos(int[] array) //вычисляем сумму чисел на нечётных позициях
{
    int sumOddPos = 0;
    for (int i = 0; i < array.Length; i = i + 2)
    {
        sumOddPos+= (array[i]);
    }
    return sumOddPos;
}
int[] array = FillArray(10, 0, 50);
PrintArray(array);
PrintData(EvenSumPos(array));