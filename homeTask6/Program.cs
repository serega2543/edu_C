﻿// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

Console.Clear();

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());

int balanse = num % 2;

if (balanse == 0)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}