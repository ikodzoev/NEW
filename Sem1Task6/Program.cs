// ==================================================================
// # 6 Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).
//===================================================================
Console.WriteLine("Введите число: ");
string? inputLineA = Console.ReadLine();
if (inputLineA != null)
{
    int inputA = int.Parse(inputLineA);
    int R = inputA % 2;

    if (R == 0)
    {
        Console.WriteLine("Введённое число является чётным: {0}", inputA);
    }
    else
    {
        Console.WriteLine("Введённое число является нечётным: {0}", inputA);
    }
}