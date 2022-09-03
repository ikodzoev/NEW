//=====================================================================
// # 10 Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.
//=====================================================================
Console.WriteLine("Введите трёхзначное число");
string threeDigitNumber = Console.ReadLine();

//проверка числа на трёхзначность;
if (threeDigitNumber.Length == 3)
{
    char[] threeDigitNumberArray = threeDigitNumber.ToCharArray();
    Console.WriteLine(threeDigitNumber[1]);
}
else
{
    Console.WriteLine("число не трёхзначное");
}