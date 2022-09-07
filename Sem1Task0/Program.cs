//===============================================================
//# 0 Напишите программу, которая на вход принимает 
// число и выдаёт его квадрат (число, умноженное на самое себя).
//================================================================
string? inputLine = Console.ReadLine();
if (inputLine != null)
{
    int inputNumber = int.Parse(inputLine);
    int outNumber = inputNumber * inputNumber;
    Console.WriteLine(outNumber);

}