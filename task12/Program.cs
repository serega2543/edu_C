/* 12. Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа
выводит остаток от деления.
34, 5 -> не кратно, остаток 4 
16, 4 -> кратно */

Console.WriteLine("Введите первое число: ");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int b = int.Parse(Console.ReadLine());

if (a%b !=0)
{
    var ost = a%b;
    Console.WriteLine($"не кратно, остаток {ost}");
}
else
{
    Console.WriteLine("кратно");
}


/* int num = new Random().Next(100, 1000);
int a1 = num / 100;
int a2 = num % 10;

Console.WriteLine(num);

int a4 = int.Parse($"{a1}{a2}");

Console.WriteLine($"{num} -> {a1}{a2}"); */