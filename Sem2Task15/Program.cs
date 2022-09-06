//============================================================================
// # 15 Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным
//============================================================================
Console.WriteLine("Введите число: ");
string? numberDayOfWeek = Console.ReadLine();
int inputNumber = int.Parse(numberDayOfWeek);
if (inputNumber > 7 || inputNumber == 0)
{
    Console.WriteLine("Такого дня недели нет");
}
else
{
    if (inputNumber == 6 || inputNumber == 7)
    {
        Console.WriteLine("Выходной день");
    }
    else
    {
        Console.WriteLine("Будний");
    }
}