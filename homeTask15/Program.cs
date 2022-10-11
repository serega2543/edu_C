/* Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет */

Console.WriteLine("Введите день недели:");
int num = int.Parse(Console.ReadLine());

if (num > 0 && num < 8)
{
    if (num ==7 | num == 6)
    {
        Console.WriteLine("да");
    }
    else
    {
        Console.WriteLine("нет");
    }
}
else
{
    Console.WriteLine("Ошибка! Некорректные данные.");
}