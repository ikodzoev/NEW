// ==================================================================================================
// # 4  Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//===================================================================================================
Console.WriteLine("Введите три числа: ");
string? inputLineA = Console.ReadLine();
string? inputLineB = Console.ReadLine();
string? inputLineC = Console.ReadLine();
if (inputLineA != null && inputLineB != null && inputLineC != null)
{
    int inputA = int.Parse(inputLineA);
    int inputB = int.Parse(inputLineB);
    int inputC = int.Parse(inputLineC);

    if (inputA > inputB)
        if (inputA > inputC)
        {
            Console.WriteLine("Большее число: {0}", inputA);
        }
        else
        {
            Console.WriteLine("Большее число: {0}", inputC);
        }
    else
    {
        if (inputB > inputC)
        {
            Console.WriteLine("Большее число: {0}", inputB);
        }
        else
        {
            Console.WriteLine("Большее число: {0}", inputC);
        }
    }
}