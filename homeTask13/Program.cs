// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6


Console.WriteLine("Введите число:");
int num = int.Parse(Console.ReadLine());
if (num < 0) num = num * -1;
int numStr = num.ToString().Length;

if (numStr > 2)
{
    while (numStr > 3) //привожу число к трёхзначному
    {
        num = num / 10;
        Console.WriteLine(num);
        numStr = num.ToString().Length;
    }
    int thirdNum = num % 10;
    Console.WriteLine(thirdNum);
}
else
{
    Console.WriteLine("третьей цифры нет");
}