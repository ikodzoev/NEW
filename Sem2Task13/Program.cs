//============================================================================
// # 13 Напишите программу, которая выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет.
//============================================================================
Console.WriteLine("Введите число: ");
string inputNumber = Console.ReadLine();

//проверка числа на трёхзначность;
if (inputNumber.Length >= 3)
{
    char[] inputNumberArray = inputNumber.ToCharArray();
    Console.WriteLine(inputNumber[2]);
}
else
{
    Console.WriteLine("Третьей цифры у числа нет");
}