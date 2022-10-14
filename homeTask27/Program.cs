/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12 */

Console.Clear();
Console.Write("Введите число:");
int number = int.Parse(Console.ReadLine()!);

Console.WriteLine($"{number} -> {SumNum(number)}");


int SumNum(int num)
{
    int sumNum = 0;
    while (num > 9)
    {
        sumNum = sumNum + num % 10;
        num = num / 10;
    }
    sumNum = sumNum + num;
    return sumNum;
}