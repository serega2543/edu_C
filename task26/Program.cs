﻿// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.Clear();
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

int NumberLenght(int number){
    int result = 0;
    // int count = 0;
    while(number>0){
        number = number/10;
        // number /= 10;
        result++;
    }
    return result;
}
Console.WriteLine(NumberLenght(number));
