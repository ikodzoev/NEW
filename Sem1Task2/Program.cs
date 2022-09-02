// =============================================================================================================
// # 2 Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//==============================================================================================================
Console.WriteLine("Введите два числа: ");
string? inputLineA = Console.ReadLine();
string? inputLineB = Console.ReadLine();

if (inputLineA != null && inputLineB != null)

{
    int inputA = int.Parse(inputLineA);
    int inputB = int.Parse(inputLineB);
    if (inputA == inputB)
        Console.WriteLine("Введённые числа равны");
    else
    {
        if (inputA > inputB)
        {
            Console.WriteLine("Большее число: {0}", inputA);
            Console.WriteLine("Меньшее число: {0}", inputB);
        }
        else
        {
            Console.WriteLine("Большее число: {0}", inputB);
            Console.WriteLine("Меньшее число: {0}", inputA);

        }
    }
}