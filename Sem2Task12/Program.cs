//==========================================================================================================================
//  # 12 Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому.
// Если второе число некратно первому, то программа выводит остаток от деления.
//==========================================================================================================================
//Вариант Константина
void Variant1()
{
    Console.Write("Введите первое число: ");
    string? inputLineA = Console.ReadLine();
    Console.Write("Введите второе число: ");
    string? inputLineB = Console.ReadLine();

    int inputNumberA = int.Parse(inputLineA);
    int inputNumberB = int.Parse(inputLineB);

    Console.WriteLine((inputNumberB % inputNumberA == 0) ? ("Второе число кратно первому") : ("Остаток от деления: " + inputNumberB % inputNumberA));
}

Variant1();

//Вариант Евгения

string? inputLineA = Console.ReadLine();
string? inputLineB = Console.ReadLine();

if (inputLineA != null && inputLineB != null)
{
    int inputNumberA = (int)int.Parse(inputLineA);
    int inputNumberB = (int)int.Parse(inputLineB);

    Console.WriteLine(inputNumberB%inputNumberA==0?"Является кратным":inputNumberB%inputNumberA);
}
