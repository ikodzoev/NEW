// =======================================================
// №38 Задайте массив вещественных чисел. Найдите разницу 
//между максимальным и минимальным элементом массива.
//========================================================

double[] FillArray(int arrayLength, double max) // заполнение массива веществ. числами
{
    double[] array = new double[arrayLength];
    Random num = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round((num.NextDouble() * max), 2);
    }
    return array;
}

void PrintArray(double[] array) // вывод массива
{
    Console.WriteLine("[{0}]", string.Join(", ", array));
}

void PrintData(double diffMaxMin) // вывод результата вычисления
{
    Console.WriteLine("Разница между макс. и мин.: " + diffMaxMin);
}

double GetMaxMin(double[] array) //вычисляем максимальный и минимальный элементы массива
{
    double max = int.MinValue;
    double min = int.MaxValue;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
        if (array[i] < min) min = array[i];
    }
    return (max - min);
}
double[] array = FillArray(10,10);
double res = GetMaxMin(array);

PrintArray(array);
PrintData(res);