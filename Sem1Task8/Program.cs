// ===============================================================================================================
// # 8 Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//================================================================================================================
Console.WriteLine("Введите число больше 1: ");
string? inputLineN = Console.ReadLine();

if (inputLineN != null)

{
    int inputN = int.Parse(inputLineN);
    int inputB = 1;

    while (inputB < inputN)
    {
        if (inputB % 2 == 0)
            Console.Write(inputB + ", ");
        inputB = inputB + 1;
    }

    //Console.WriteLine("- все чётные числа до ");
    Console.Write(inputN);
}