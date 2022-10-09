/* 14. Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
14 -> нет 
46 -> нет 
161 -> да */

Console.Clear;
Console.WriteLine("Введите первое число: ");
int a = int.Parse(Console.ReadLine());

int del_7 = a % 7;
int del_23 = a % 23;


if (del_7 == 0 && del_23 == 0) 
{
   Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет"); 
}